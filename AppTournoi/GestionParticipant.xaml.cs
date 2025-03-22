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

    public partial class GestionParticipant : Window
    {
        private bddtournoi bdd;
        public GestionParticipant(bddtournoi bdd)
        {
            InitializeComponent();
            this.bdd = bdd;

            try
            {
                this.DataGridParticipantsGestion.ItemsSource = bdd.GetAllParticipant();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
            }
        }

        private void MenuContextSupprimerParticipant_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Participant ptcpSelection = this.DataGridParticipantsGestion.SelectedItem as Participant;
                    if (MessageBox.Show("Voulez vous vraiment supprimer définitivement ce participant " + ptcpSelection.Nom + " " +
                    ptcpSelection.Prenom + " ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        bdd.SupprimerParticipant(ptcpSelection);
                        MessageBox.Show("La suppression du champion " + ptcpSelection.Nom + " " + ptcpSelection.Prenom + "est réussie!", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
                this.DataGridParticipantsGestion.ItemsSource = bdd.GetAllParticipant();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du participant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MenuContextModifierParticipant_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Participant ptcpSelection = this.DataGridParticipantsGestion.SelectedItem as Participant;
                    AjoutParticipant ap = new AjoutParticipant(bdd,ptcpSelection);
                    ap.ShowDialog();
                }
                this.DataGridParticipantsGestion.ItemsSource = bdd.GetAllParticipant();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la modification du participant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutParticipant ap = new AjoutParticipant(bdd,null);
            ap.ShowDialog();
            try
            {
                this.DataGridParticipantsGestion.ItemsSource = bdd.GetAllParticipant();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
            }

        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
