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

using TechBar_Gestion_v2.Service;
using TechBar_Gestion_v2.Model_bdd_bar;
using TechBar_Gestion_v2.RFID;
using System.Collections.ObjectModel;

namespace TechBar_Gestion_v2.View.ViewUsers
{
    /// <summary>
    /// Logique d'interaction pour PageUsers.xaml
    /// </summary>
    public partial class PageUsers : UserControl
    {
        DAO_User dao_user; //on importe la calsse rfid pour utiliser ses focntion et le dao utilisateur car nous allons l'utiliser
        LecteurRfid rfid;

        public PageUsers()
        {
            InitializeComponent();

            dao_user = new DAO_User();
            rfid = new LecteurRfid();

            FX_RefreshUser(); //au lancerment de la page on affiche les information mise a jour
        }

        /************/
        /* function */
        /************/
        public string FX_RefreshUser()
        {
            DatagridUser.ItemsSource = dao_user.FX_GetAllUser();

            return "Refresh succed";
        }


        /*********/
        /* event */
        /*********/

        /* mod */

        public void Click_BTN_Mod(object sender, RoutedEventArgs e)
        {
            popup_modcontact.IsOpen = true;
        }

        public void Click_BTN_Cancel_mod(object sender, RoutedEventArgs e)
        {
            popup_modcontact.IsOpen = false;
        }

        public void Click_BTN_Confirm_mod(object sender, RoutedEventArgs e)
        {
            popup_modcontact.IsOpen = false;

            User us = new User(); //récupère l'utilisateur a modifier
            us = DatagridUser.SelectedValue as User;

            dao_user.FX_ModUser(us);
            FX_RefreshUser();

        }

        /* remove */

        public void Click_BTN_Remove(object sender, RoutedEventArgs e)
        {
            popup_delcontact.IsOpen = true;
        }

        public void Click_BTN_Cancel_del(object sender, RoutedEventArgs e)
        {
            popup_delcontact.IsOpen = false;
        }

        public void Click_BTN_Confirm_del(object sender, RoutedEventArgs e)
        {
            popup_delcontact.IsOpen = false;

            User us = new User(); //récupère l'utilisateur a modifier
            us = DatagridUser.SelectedValue as User;

            dao_user.FX_DelUser(us);
            FX_RefreshUser();
        }

        /* use rfidreader */

        public void Click_BTN_rfidcontact(object sender, RoutedEventArgs e)
        {
            popup_rfidcontact.IsOpen = true;
        }

        public void Click_BTN_Cancel_rfidcontact(object sender, RoutedEventArgs e)
        {
            popup_rfidcontact.IsOpen = false;
        }

        public void Click_BTN_Confirm_rfidcontact(object sender, RoutedEventArgs e)
        {
            popup_rfidcontact.IsOpen = false;

            User us = new User(); //récupère l'utilisateur a modifier
            us = DatagridUser.SelectedValue as User;

            try
            {
                rfid.connectionRs();
                us.Rfidnumber = rfid.GetCardID();

                dao_user.FX_ModUser(us);
                FX_RefreshUser();
            }
            catch
            {
                try
                {
                    TB_RFIDNumber.Text = rfid.GetCardID();
                }
                catch { }
            }

            
        }

        /* add user */

        public void Click_BTN_adduser(object sender, RoutedEventArgs e)
        {
            popup_adduser.IsOpen = true;
        }
        
        public void BTN_add_Cancel(object sender, RoutedEventArgs e)
        {
            popup_adduser.IsOpen = false;

            TB_Email.Text = "";
            TB_LastName.Text = "";
            TB_Name.Text = "";
            TB_RFIDNumber.Text = "";
        }

        public void BTN_add_Confirm(object sender, RoutedEventArgs e)
        {
            popup_adduser.IsOpen = false;

            try
            {
                User us = new User()
                {
                    Name = TB_Name.Text,
                    LastName = TB_LastName.Text,
                    Email = TB_Email.Text,
                    Rfidnumber = TB_RFIDNumber.Text,
                    Credit = int.Parse(TB_Credit.Text)
                };

                dao_user.FX_AddUser(us);

                FX_RefreshUser();

                TB_Email.Text = "";
                TB_LastName.Text = "";
                TB_Name.Text = "";
                TB_RFIDNumber.Text = "";
                TB_Credit.Text = "";
            }
            catch
            {

            }

        }

        /* refresh */


        public void Click_BTN_Refresh(object sender, RoutedEventArgs e)
        {
            FX_RefreshUser();
        }


    }
}
