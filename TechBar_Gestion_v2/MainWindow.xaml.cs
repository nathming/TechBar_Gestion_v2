using System;
using System.Collections.Generic;
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

using TechBar_Gestion_v2.View.ViewRFID;
using TechBar_Gestion_v2.View.ViewUsers;
using TechBar_Gestion_v2.View.ViewStorage;

namespace TechBar_Gestion_v2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    
    //pour créer le dossier modèle de la classe nous utilisons la commande suivante
    ///*Base First Connection*/
    //Scaffold-DbContext "server=localhost;port=3306;user=root;password=;database=bdd_bar" Pomelo.EntityFrameworkCore.MySql -OutputDir Model_bdd_bar -f

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid_RFID.Children.Clear(); //permet de se rendre sur les utilisateur au lancement de l'application
            PageUsers pageusers = new PageUsers();
            Grid_RFID.Children.Add(pageusers);
        }

        private void BTN_Nav_RFID_Click(object sender, RoutedEventArgs e) //renvoit a la page RFID
        {
            Grid_RFID.Children.Clear();
            PageRFID pagerfid = new PageRFID();
            Grid_RFID.Children.Add(pagerfid);
        }

        private void BTN_Nav_User_Click(object sender, RoutedEventArgs e) //renvoit a la page utilisateur
        {
            Grid_RFID.Children.Clear();
            PageUsers pageusers = new PageUsers();
            Grid_RFID.Children.Add(pageusers);
        }

        private void BTN_Nav_Storage_Click(object sender, RoutedEventArgs e) //renvoit sur la page de gestion du stock
        {
            Grid_RFID.Children.Clear();
            PageStorage pagestorage = new PageStorage();
            Grid_RFID.Children.Add(pagestorage);
        }
    }
}
