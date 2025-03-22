using BddtournoiContext;
using DllTournois;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public partial class GestionSport : Window
    {

        private bddtournoi bdd;
        private int id;
        public GestionSport(bddtournoi bdd)
        {
            InitializeComponent();
            this.bdd = bdd;
            try
            {
                this.lvSportGestion.ItemsSource = bdd.GetAllSport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
            }
            this.id = -1;
        }

        private void MenuContextSupprimerSport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Sport spSelection = this.lvSportGestion.SelectedItem as Sport;
                    if (MessageBox.Show("Voulez vous vraiment supprimer définitivement le sport " + spSelection.Intitule + " ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        bdd.SupprimerSport(spSelection);
                        MessageBox.Show("La suppression du sport " + spSelection.Intitule + " est réussie!", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
                this.lvSportGestion.ItemsSource = bdd.GetAllSport();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du sport", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MenuContextModifierSport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Sport spSelection = this.lvSportGestion.SelectedItem as Sport;
                    this.id = spSelection.IdSport;
                    tbSport.Text = spSelection.Intitule;
                    ButtonAjouterSport.Content = "Modifier sport";
                    ButtonAjouterSport.Click -= Ajouter_Click;
                    ButtonAjouterSport.Click += Modifier_Click;
                }
                this.lvSportGestion.ItemsSource = bdd.GetAllSport();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du sport", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tbSportModif(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSport.Text)&&
                !bdd.GetSport(tbSport.Text))
            {
                this.ButtonAjouterSport.IsEnabled = true;
            }
            else
            {
                this.ButtonAjouterSport.IsEnabled = false;
            }
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bdd.ModificationSport(tbSport.Text.Trim().ToLower(),this.id);

                MessageBox.Show("Sport modifié avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                tbSport.Text = "";
                ButtonAjouterSport.IsEnabled = false;
                this.lvSportGestion.ItemsSource = bdd.GetAllSport();
                ButtonAjouterSport.Content = "Ajouter le sport";
                ButtonAjouterSport.Click += Modifier_Click;
                ButtonAjouterSport.Click -= Ajouter_Click;
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

                bdd.InsertionSport(tbSport.Text.Trim().ToLower());

                MessageBox.Show("Sport ajouté avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                tbSport.Text = "";
                ButtonAjouterSport.IsEnabled = false;
                this.lvSportGestion.ItemsSource = bdd.GetAllSport();

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
