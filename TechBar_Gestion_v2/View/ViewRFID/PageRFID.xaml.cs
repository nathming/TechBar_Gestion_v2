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

using TechBar_Gestion_v2.RFID;
using TechBar_Gestion_v2.Service;

namespace TechBar_Gestion_v2.View.ViewRFID
{
    /// <summary>
    /// Logique d'interaction pour PageRFID.xaml
    /// </summary>
    public partial class PageRFID : UserControl
    {
        LecteurRfid rfid; //on importe la calsse rfid pour utiliser ses focntion et le dao utilisateur car nous allons l'utiliser
        DAO_User dao_user;

        public PageRFID()
        {
            InitializeComponent();

            rfid = new LecteurRfid();
            dao_user = new DAO_User();

            FX_RFIDRead(); //lance cette fonction au lancement de la page pour ne pas avoir a tojours cliquer sur le bouton lire
        }

        /************/
        /* function */
        /************/

        public string FX_RFIDRead() //cette fonction lis et renvoi les information en rapport avec la carte RFID lue.
        {
            rfid.connectionRs();
            LB_CardNumber.Content = rfid.GetCardID();

            try
            {
                var UserByRFID = dao_user.FX_GetUserByRFID(LB_CardNumber.Content.ToString()); //ici on récupère les données en lien avec la carte lue
                LB_Name.Content = UserByRFID.Name;
                LB_Lastname.Content = UserByRFID.LastName;
                LB_Email.Content = UserByRFID.Email;
                LB_Credit.Content = UserByRFID.Credit.ToString();

            }
            catch
            {
                LB_Name.Content = "";
                LB_Lastname.Content = "";
                LB_Email.Content = "";
                LB_Credit.Content = "";
            }

            return "Read succed";
        }

        /*********/
        /* event */
        /*********/

        private void BTN_Read_Click(object sender, RoutedEventArgs e) //lis la carte quand on clique sur le bouton lire
        {
            FX_RFIDRead();
        }
    }
}
