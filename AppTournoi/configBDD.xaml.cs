using BddtournoiContext;
using DllTournois;
using System;
using System.Security.Cryptography;
using System.Windows;

namespace AppTournoi
{

    public partial class configBDD : Window
    {

        public configBDD()
        {
            InitializeComponent();
            tbAddIP.Text = Properties.Settings.Default.AdresseIP;
            tbPort.Text = Properties.Settings.Default.Port;
            tbUtil.Text = Properties.Settings.Default.NomUtil;
            tbMDP.Password = Properties.Settings.Default.MDP;

        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            string adresseIP = tbAddIP.Text;
            string port = tbPort.Text;
            string utilisateur = tbUtil.Text;
            string motDePasse = tbMDP.Password;

            Properties.Settings.Default.AdresseIP = adresseIP;
            Properties.Settings.Default.Port = port;
            Properties.Settings.Default.NomUtil = utilisateur;
            Properties.Settings.Default.MDP= motDePasse;
            Properties.Settings.Default.Save();

            this.Close();

        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
