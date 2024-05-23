using ProFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace ProFinance
{
    /// <summary>
    /// Logique d'interaction pour C_Remise.xaml
    /// </summary>
    public partial class C_Remise : UserControl
    {
        public C_Remise()
        {
            InitializeComponent();

        }
        public Remise[] Li = new Remise[]
        {
               new Remise { Type = "Itccccccc 1.1", Numéro = "Item 1.2",Date = "Item 1.1", Montant = "Item 1.2",Compte_de_dépôt = "Item 1.1", Remis_par = "Item 1.2" , Nombre = "Item 1.1"  },
               new Remise { Type = "Item 1.1", Numéro = "Item 1.2",Date = "Item 1.1", Montant = "Item 1.2",Compte_de_dépôt = "Item 1.1", Remis_par = "Item 1.2" , Nombre = "Item 1.1" },
               new Remise { Type = "Item 1.1", Numéro = "Item 1.2",Date = "Item 1.1", Montant = "Item 1.2",Compte_de_dépôt = "Item 1.1", Remis_par = "Item 1.2" , Nombre = "Item 1.1"  },
               new Remise { Type = "Item 1.1", Numéro = "Item 1.2",Date = "Item 1.1", Montant = "Item 1.2",Compte_de_dépôt = "Item 1.1", Remis_par = "Item 1.2" , Nombre = "Item 1.1" },
               new Remise { Type = "Item 1.1", Numéro = "Itecccccccccccccccccccccccccccm 1.2",Date = "Item 1.1", Montant = "Item 1.2",Compte_de_dépôt = "Item 1.1", Remis_par = "Item 1.2" } 
        };
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lisst.ItemsSource = Li;
        }
   

        private void lisst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            var listView = sender as ListView;
            var gridView = listView.View as GridView;

            if (gridView != null)
            {
                double totalAvailableWidth = listView.ActualWidth - SystemParameters.VerticalScrollBarWidth; // Exclude scrollbar width

                foreach (var column in gridView.Columns)
                {
                    column.Width = totalAvailableWidth / gridView.Columns.Count;
                }
            }
        }
    }
}
