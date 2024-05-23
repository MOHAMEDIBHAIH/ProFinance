using ProFinance.Models;
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

namespace ProFinance
{
    /// <summary>
    /// Logique d'interaction pour C_CompteBanquaire.xaml
    /// </summary>
    public partial class C_CompteBanquaire : UserControl
    {
        /*public Compte_bancaire[] Li = new Compte_bancaire[]
{
              new Compte_bancaire { Société = "Itccccccccccccccccccccccccccccccccccccem 1.1", Banque = "Item 1.2",N_de_Compte = "Item 1.1", Agence = "Item 1.2"  },
              new Compte_bancaire { Société = "Item 1.1", Banque = "Item 1.2",N_de_Compte = "Item 1.1", Agence = "Item 1.2"  },
              new Compte_bancaire { Société = "Item 1.1", Banque = "Item 1.2",N_de_Compte = "Item 1.1", Agence = "Item 1.2"  },
              new Compte_bancaire { Société = "Item 1.1", Banque = "Item 1.2",N_de_Compte = "Item 1.1", Agence = "Item 1.2"  },
              new Compte_bancaire { Société = "Item 1.1", Banque = "Itecccccccccccccccccccccccccccm 1.2",N_de_Compte = "Item 1.1", Agence = "Item 1.2" }            };*/

        public C_CompteBanquaire()
        {
            InitializeComponent();
           // lisst.ItemsSource = Li;
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

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
