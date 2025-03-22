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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bddtournoi bdd;
        private byte[] imageBytes = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnexionBdd_Click(object sender, RoutedEventArgs e)
        {
            try {

                 this.bdd = new bddtournoi(
                     Properties.Settings.Default.NomUtil,
                     Properties.Settings.Default.MDP,
                     Properties.Settings.Default.AdresseIP,
                     Properties.Settings.Default.Port
                     );
                List<Sport> sports = bdd.GetAllSport();
                this.lvSports.ItemsSource = sports;
                this.miListParticipant.IsEnabled = true;
                this.miCoGestionnaire.IsEnabled = true;
                Properties.Settings.Default.CoGestionnaire = false;
                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ","Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
                this.lvSports.ItemsSource= null;
                this.miListParticipant.IsEnabled = false;
                this.miCoGestionnaire.IsEnabled= false;
                this.miGestPart.IsEnabled = false;
                this.miGestSport.IsEnabled = false;
                this.miGestTournois.IsEnabled = false;
                this.lvParticipants.ItemsSource = null;
                this.lvTournois.ItemsSource = null;
                this.tbNom.Text = "";
                this.tbPrenom.Text = "";
                this.tbSport.Text = "";
                this.tbTournoi.Text = "";
                this.tbDateTournoi.Text = "";
            }
            

        }

        private void ListParticipant_Click(Object sender, RoutedEventArgs e)
        {
            ListParticipant lp = new ListParticipant(bdd);
            lp.ShowDialog();
        }

        private void ParametreBdd_Click(Object sender, RoutedEventArgs e)
        {
            configBDD conf = new configBDD();
            conf.ShowDialog();
        }

        private void GestTournois_Click(Object sender, RoutedEventArgs e)
        {
            
            try
            {   
                GestionTournoi gestionTournoi = new GestionTournoi(bdd);
                gestionTournoi.ShowDialog();
                this.lvSports.ItemsSource = bdd.GetAllSport();
            }catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void GestSport_Click(Object sender, RoutedEventArgs e)
        {
            GestionSport gestionSport = new GestionSport(bdd);
            gestionSport.ShowDialog();
        }

        private void GestParticipant_Click(Object sender, RoutedEventArgs e)
        {
            GestionParticipant gestionParticipant = new GestionParticipant(bdd);
            gestionParticipant.ShowDialog();
        }


        private void Gestionnaire_Click(Object sender, RoutedEventArgs e)
        {
            //suivant la connexion de gestionnaire on affiche pas la même pas
            if(Properties.Settings.Default.CoGestionnaire == true)
            {
                GestionGestionnaire gestGestionnaire = new GestionGestionnaire(bdd);
                gestGestionnaire.ShowDialog();
            }else
            {
                ConnexionGestion coGestion = new ConnexionGestion(bdd);
                coGestion.ShowDialog();
            }

            //Active les boutons en fonction de si la connexion au gestionnaire est faire ou non
            if (Properties.Settings.Default.CoGestionnaire == true)
            {
                this.miGestPart.IsEnabled = true;
                this.miGestSport.IsEnabled = true;
                this.miGestTournois.IsEnabled = true;
            }
            else
            {
                this.miGestPart.IsEnabled = false;
                this.miGestSport.IsEnabled = false;
                this.miGestTournois.IsEnabled = false;
            }

        }

        private void lvSports_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (sender is ListView)
                {
                    Sport spSelect = (Sport)(sender as ListView).SelectedItem;
                    if (spSelect != null)
                    {
                        List<Tournoi> tournois = bdd.GetAllTournoiBySport(spSelect);
                        this.lvTournois.ItemsSource = tournois;
                        this.tbSport.Text = spSelect.Intitule;
                        this.lvParticipants.ItemsSource = "";
                        this.tbTournoi.Text = "";
                        this.tbDateTournoi.Text = "";
                        this.tbNom.Text = "";
                        this.tbPrenom.Text = "";
                        imgDynamic.Source = new BitmapImage(new Uri("sport6.jpg", UriKind.Relative));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvTournois_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (sender is ListView)
                {
                    Tournoi tSelect = (Tournoi)(sender as ListView).SelectedItem;
                    if (tSelect != null)
                    {
                        List<Participant> participants = bdd.GetAllParticipantByTournoi(tSelect);
                        this.lvParticipants.ItemsSource = participants;
                        this.tbTournoi.Text = tSelect.Intitule;
                        this.tbDateTournoi.Text = tSelect.DateTournoi.ToShortDateString();
                        this.tbNom.Text = "";
                        this.tbPrenom.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void lvParticipants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (sender is ListView)
                {
                    Participant pSelect = (Participant)(sender as ListView).SelectedItem;
                    if (pSelect != null)
                    {
                        this.tbNom.Text = pSelect.Nom;
                        this.tbPrenom.Text = pSelect.Prenom;
                        this.imageBytes = pSelect.Photo;
                        imgDynamic.Source = gestionPhoto.ConvertByteArrayToBitmapImage(this.imageBytes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
