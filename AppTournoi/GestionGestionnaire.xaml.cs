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

    public partial class GestionGestionnaire : Window
    {

        private bddtournoi bdd;
        private int id;
        public GestionGestionnaire(bddtournoi bdd)
        {
            InitializeComponent();
            this.bdd = bdd;
            try
            {
                this.lvGestionnaireGestion.ItemsSource = bdd.GetAllGestionnaireApplis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
            }
            this.id = -1;
        }

        private void tbChanger(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLogin.Text) &&
                !string.IsNullOrEmpty(tbMDP.Password) &&
                !string.IsNullOrEmpty(tbVerifMDP.Password)&&
                !bdd.GetGestionnaire(tbLogin.Text, tbMDP.Password)&&
                tbMDP.Password==tbVerifMDP.Password)
            {
                this.ButtonAjouterGestionnaire.IsEnabled = true;
            }
            else
            {
                this.ButtonAjouterGestionnaire.IsEnabled = false;
            }
        }
        private void MenuContextSupprimerGesionnaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Gestionnairesappli tnSelection = this.lvGestionnaireGestion.SelectedItem as Gestionnairesappli;
                    if (MessageBox.Show("Voulez vous vraiment supprimer définitivement le gestionnaire " + tnSelection.Login + 
                       " ?", "Confirmation", MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        bdd.SupprimerGestionnaire(tnSelection);
                        MessageBox.Show("La suppression du tournoi " + tnSelection.Login + " est réussie!", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
                this.lvGestionnaireGestion.ItemsSource = bdd.GetAllGestionnaireApplis();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du sport","Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MenuContextModifierGestionnaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    Gestionnairesappli gaSelection = this.lvGestionnaireGestion.SelectedItem as Gestionnairesappli;
                    tbLogin.Text = gaSelection.Login;
                    tbMDP.Password = gaSelection.MotDpass;
                    tbVerifMDP.Password = gaSelection.MotDpass;
                    ButtonAjouterGestionnaire.Content = "Modifier";
                    ButtonAjouterGestionnaire.Click -= Ajouter_Click;
                    ButtonAjouterGestionnaire.Click += Modifier_Click;
                    this.id = gaSelection.IdGestionnaire;
                    text.Content = "Modifier un Gestionnaire : ";

                }
                this.lvGestionnaireGestion.ItemsSource = bdd.GetAllGestionnaireApplis();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du sport", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bdd.InsertionGestionnaire(tbLogin.Text.Trim().ToLower(),tbMDP.Password);

                MessageBox.Show("Gestionnaire ajouté avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                tbLogin.Text = "";
                tbMDP.Password = "";
                tbVerifMDP.Password = "";
                lvGestionnaireGestion.ItemsSource = bdd.GetAllGestionnaireApplis();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            bdd.ModificationGestionnaire(tbLogin.Text, tbMDP.Password, this.id);
            this.id = -1;
            tbLogin.Text = "";
            tbMDP.Password = "";
            tbVerifMDP.Password = "";
            ButtonAjouterGestionnaire.Content = "Ajouter le gestionnaire";
            ButtonAjouterGestionnaire.Click -= Modifier_Click;
            ButtonAjouterGestionnaire.Click += Ajouter_Click;
            text.Content = "Ajouter un Gestionnaire : ";
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Deco_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.CoGestionnaire = false;
            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
