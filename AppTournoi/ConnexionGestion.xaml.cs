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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace AppTournoi
{


    public partial class ConnexionGestion : Window
    {
        private bddtournoi bdd;

        public ConnexionGestion(bddtournoi bdd)
        {
            InitializeComponent();
            this.bdd = bdd;
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bdd.ConnexionGestionnaire(tbLoginGestionnaire.Text, tbGestMDP.Password))
                {
                    Properties.Settings.Default.CoGestionnaire = true;
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    Properties.Settings.Default.CoGestionnaire = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Veuillez vérifier vos paramètres de connexion ", "Connexion gestionnaire impossible",MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : " + ex);
            }
           
        }

    }
}
