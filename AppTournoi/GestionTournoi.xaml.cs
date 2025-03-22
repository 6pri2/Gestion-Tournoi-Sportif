using BddtournoiContext;
using DllTournois;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class GestionTournoi : Window
    {
        private bddtournoi bdd;
        private int id;
        public GestionTournoi(bddtournoi bdd)
        {
            InitializeComponent();
            this.bdd = bdd;
            this.id = -1;
            try
            {
                this.lvTournoiGestion.ItemsSource = bdd.GetAllTournoi();
                this.lvSport.ItemsSource = bdd.GetAllSport();
            }catch(Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
            }

            this.dpDate.BlackoutDates.AddDatesInPast();
        }

        private void ChampModifier(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIntitule.Text) &&
                dpDate.SelectedDate.HasValue &&
                lvSport.SelectedItem != null )
            {
                
                int idSport = ((Sport)lvSport.SelectedItem).IdSport;
                if (!bdd.GetTournoi(tbIntitule.Text, dpDate.SelectedDate.Value, idSport))
                {
                    this.ButtonAjouter.IsEnabled = true;
                }
                else
                {
                    this.ButtonAjouter.IsEnabled = false;
                }
                

            }
            else
            {
                this.ButtonAjouter.IsEnabled = false;
            }
        }

        private void MenuContextSupprimerTournoi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Tournoi tnSelection = this.lvTournoiGestion.SelectedItem as Tournoi;
                    if (MessageBox.Show("Voulez vous vraiment supprimer définitivement le tournoi " + tnSelection.Intitule + " ayant lieu le "
                        + tnSelection.DateTournoi.ToShortDateString() + " ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        bdd.SupprimerTournoi(tnSelection);
                        MessageBox.Show("La suppression du tournoi " + tnSelection.Intitule + "à date du " + tnSelection.DateTournoi.ToShortDateString() + " est réussie!", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
                this.lvTournoiGestion.ItemsSource = bdd.GetAllTournoi();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du sport", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MenuContextModifierTournoi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Tournoi tnSelection = this.lvTournoiGestion.SelectedItem as Tournoi;
                    this.id = tnSelection.IdTournoi;
                    this.tbIntitule.Text = tnSelection.Intitule;
                    this.dpDate.SelectedDate = tnSelection.DateTournoi;
                    this.lvSport.SelectedValue = bdd.GetSportById(tnSelection.Sport);
                    this.ButtonAjouter.Content = "Modifier";
                    ButtonAjouter.Click -= Ajouter_Click;
                    ButtonAjouter.Click += Modifier_Click;
                }
                this.lvTournoiGestion.ItemsSource = bdd.GetAllTournoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la modification du tournoi", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idSport = ((Sport)lvSport.SelectedItem).IdSport;
                bdd.ModificationTournoi(tbIntitule.Text.Trim().ToLower(), dpDate.SelectedDate.Value, idSport, this.id);

                tbIntitule.Text = "";
                this.lvTournoiGestion.ItemsSource = bdd.GetAllTournoi();
                this.ButtonAjouter.Content = "Ajouter";
                ButtonAjouter.Click -= Modifier_Click;
                ButtonAjouter.Click += Ajouter_Click;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string intitule = tbIntitule.Text.Trim().ToLower();

                int idSport = ((Sport)lvSport.SelectedItem).IdSport;

                bdd.InsertionTournoi(intitule, dpDate.SelectedDate.Value, idSport);


                MessageBox.Show("Tournoi ajouté avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                this.lvTournoiGestion.ItemsSource = bdd.GetAllTournoi();
                this.tbIntitule.Text = "";
                this.dpDate.SelectedDate = null;
                this.lvSport.UnselectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
