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

namespace TechBar_Gestion_v2.View.ViewStorage
{
    /// <summary>
    /// Logique d'interaction pour PageStorage.xaml
    /// </summary>
    public partial class PageStorage : UserControl
    {

        DAO_Beer dao_beer;

        public PageStorage()
        {
            InitializeComponent();

            dao_beer = new DAO_Beer();

            FX_RefreshBeer();
        }


        /************/
        /* function */
        /************/
        public string FX_RefreshBeer()
        {
            DatagridBeer.ItemsSource = dao_beer.FX_GetAllBeer();

            return "Refresh succed";
        }


        /*********/
        /* event */
        /*********/

        /* mod */

        public void Click_BTN_Mod(object sender, RoutedEventArgs e)
        {
            popup_modbeer.IsOpen = true;
        }

        public void Click_BTN_Cancel_mod(object sender, RoutedEventArgs e)
        {
            popup_modbeer.IsOpen = false;
        }

        public void Click_BTN_Confirm_mod(object sender, RoutedEventArgs e)
        {
            popup_modbeer.IsOpen = false;

            Beer beer = new Beer(); //récupère la bière à modifier
            beer = DatagridBeer.SelectedValue as Beer;

            dao_beer.FX_ModBeer(beer);
            FX_RefreshBeer();

        }

        /* remove */

        public void Click_BTN_Remove(object sender, RoutedEventArgs e)
        {
            popup_delbeer.IsOpen = true;
        }

        public void Click_BTN_Cancel_del(object sender, RoutedEventArgs e)
        {
            popup_delbeer.IsOpen = false;
        }

        public void Click_BTN_Confirm_del(object sender, RoutedEventArgs e)
        {
            popup_delbeer.IsOpen = false;

            Beer beer = new Beer(); //récupère la bière à supprimer
            beer = DatagridBeer.SelectedValue as Beer;

            dao_beer.FX_DelBeer(beer);
            FX_RefreshBeer();
        }

        /* add beer */

        public void Click_BTN_addbeer(object sender, RoutedEventArgs e)
        {
            popup_addbeer.IsOpen = true;
        }

        public void BTN_add_Cancel(object sender, RoutedEventArgs e)
        {
            popup_addbeer.IsOpen = false;

            TB_Description.Text = "";
            TB_Name.Text = "";
        }

        public void BTN_add_Confirm(object sender, RoutedEventArgs e)
        {
            popup_addbeer.IsOpen = false;

            try
            {
                Beer beer = new Beer()
                {
                    Nom = TB_Name.Text,
                    Description = TB_Description.Text,
                };

                dao_beer.FX_AddBeer(beer);

                FX_RefreshBeer();

                TB_Description.Text = "";
                TB_Name.Text = "";
            }
            catch
            {

            }

        }

        /* refresh */


        public void Click_BTN_Refresh(object sender, RoutedEventArgs e)
        {
            FX_RefreshBeer();
        }

    }
}
