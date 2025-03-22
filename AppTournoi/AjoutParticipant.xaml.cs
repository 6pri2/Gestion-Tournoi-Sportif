using BddtournoiContext;
using DllTournois;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

using Image = System.Drawing.Image;

namespace AppTournoi
{
    public partial class AjoutParticipant : Window
    {
        private bddtournoi bdd;
        private Participant part;

        private byte[] imageBytes = null;
        public AjoutParticipant(bddtournoi bdd, Participant part)
        {
            InitializeComponent();
            this.bdd = bdd;
            this.part = part;
            try
            {
                this.lvTournoi.ItemsSource = bdd.GetAllTournoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données");
                Debug.WriteLine("Exception : " + ex);
            }
            //gestion de la date dans le datetime picker
            DateTime minDate = DateTime.Today.AddYears(-8);
            this.dpDateNaissance.BlackoutDates.Add(new CalendarDateRange(minDate.AddDays(+1), DateTime.MaxValue));
            this.dpDateNaissance.DisplayDate = minDate;

            if(part != null)
            {
                tbNom.Text = part.Nom;
                tbPrenom.Text = part.Prenom;
                if (part.Sexe == "feminin")
                {
                    comboBoxSexe.SelectedIndex = 1;
                }
                else if (part.Sexe == "masculin")
                {
                    comboBoxSexe.SelectedIndex = 0;
                }
                dpDateNaissance.SelectedDate = part.DateNaissance;
                this.lvTournoi.SelectedItem = bdd.GetTournoiById(part.Tournoi);
                imgDynamic.Source = gestionPhoto.ConvertByteArrayToBitmapImage(part.Photo);
                this.imageBytes = part.Photo;
                ButtonEnregistrer.Content = "Modifier";
                ButtonEnregistrer.Click -= Enregistrer_Click;
                ButtonEnregistrer.Click += Modifier_Click;
            }


        }

        private void ChampModifier(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbNom.Text) &&
               !string.IsNullOrWhiteSpace(tbPrenom.Text) &&
               dpDateNaissance.SelectedDate.HasValue &&
               comboBoxSexe.SelectedItem != null &&
               lvTournoi.SelectedItem != null &&
               this.imageBytes !=null &&
               !bdd.GetParticipant(
                   tbPrenom.Text,
                   tbNom.Text,
                   dpDateNaissance.SelectedDate.Value,
                   ((ComboBoxItem)comboBoxSexe.SelectedItem).Content.ToString(),
                   ((Tournoi)lvTournoi.SelectedItem).IdTournoi
                   )
               )
            {
                this.ButtonEnregistrer.IsEnabled = true;
            }
            else
            {
                this.ButtonEnregistrer.IsEnabled = false;
            }
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nom = tbNom.Text.Trim().ToUpper();
                string prenom = tbPrenom.Text.Trim().ToLower();
                DateTime dateNaissance = dpDateNaissance.SelectedDate.Value;
                string sexe = ((ComboBoxItem)comboBoxSexe.SelectedItem).Content.ToString();
                int idTournoi = ((Tournoi)lvTournoi.SelectedItem).IdTournoi;

                bdd.ModificationParticipant(nom, prenom, dateNaissance, sexe, this.imageBytes, idTournoi, part.Id);
                ButtonEnregistrer.Click -= Modifier_Click;
                ButtonEnregistrer.Click += Enregistrer_Click;
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            //fonction de création d'un participant
            try
            {
                string nom = tbNom.Text.Trim().ToUpper();
                string prenom = tbPrenom.Text.Trim().ToLower();
                DateTime dateNaissance = dpDateNaissance.SelectedDate.Value;
                string sexe = ((ComboBoxItem)comboBoxSexe.SelectedItem).Content.ToString();
                int idTournoi = ((Tournoi)lvTournoi.SelectedItem).IdTournoi;

                bdd.InsertionParticipant(nom, prenom, dateNaissance, sexe, this.imageBytes , idTournoi);

                MessageBox.Show("Participant ajouté avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InsererImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == true)
                {
                    string photoFilePath = openFileDialog.FileName;
                    Image image = Image.FromFile(photoFilePath);
                    this.imageBytes = gestionPhoto.ConvertImageToByteArray(image);
                    imgDynamic.Source =gestionPhoto.ConvertByteArrayToBitmapImage(this.imageBytes);
                    ChampModifier(sender,e);
                    this.ButtonEnregistrer.IsEnabled = true ;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'image: " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
