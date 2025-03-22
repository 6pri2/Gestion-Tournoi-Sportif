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
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class ListParticipant : Window
    {
        private bddtournoi bdd;

        public ListParticipant(bddtournoi mainbdd)
        {
            this.bdd = mainbdd;
            InitializeComponent();
            try
            {
                this.DataGridParticipants.ItemsSource = bdd.GetAllParticipant();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez rééssayer plus tard si le problème viens du serveur ou" +
                    " vérifier vos paramètres de connexion ", "Connexion impossible à la base de données", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine("Exception : "+ex);
            }
        }

        private void tbRecherche_Changed(Object sender, RoutedEventArgs e)
        {
            this.DataGridParticipants.ItemsSource = bdd.GetAllParticipantByName(this.tbRecherche.Text);
        }

    }
}
