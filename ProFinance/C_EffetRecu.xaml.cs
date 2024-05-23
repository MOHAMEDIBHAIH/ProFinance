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
    /// Logique d'interaction pour C_EffetRecu.xaml
    /// </summary>
    public partial class C_EffetRecu : UserControl
    {
        public C_EffetRecu()
        {
            InitializeComponent(); lisst.ItemsSource = li;
        }
        public Cheque[] li = new Cheque[]
{
               new Cheque { Type = "Itccccccccccccccccccccccccccccccccccccem 1.1", Carnet = "Item 1.2",Société = "Item 1.1", Banque = "Item 1.2",Compte = "Item 1.1", N_de_Chéque = "Item 1.2" , Date = "Item 1.1", Delai_de_Paiement = "Item 1.2",Bénéficiaires = "Item 1.1", Montant = "Item 1.2",Remis = "Item 1.1", Référence = "Item 1.2"  },
               new Cheque { Type = "Item 1.1", Carnet = "Item 1.2",Société = "Item 1.1", Banque = "Item 1.2",Compte = "Item 1.1", N_de_Chéque = "Item 1.2" , Date = "Item 1.1", Delai_de_Paiement = "Item 1.2",Bénéficiaires = "Item 1.1", Montant = "Item 1.2",Remis = "Item 1.1", Référence = "Item 1.2"  },
               new Cheque { Type = "Item 1.1", Carnet = "Item 1.2",Société = "Item 1.1", Banque = "Item 1.2",Compte = "Item 1.1", N_de_Chéque = "Item 1.2" , Date = "Item 1.1", Delai_de_Paiement = "Item 1.2",Bénéficiaires = "Item 1.1", Montant = "Item 1.2",Remis = "Item 1.1", Référence = "Item 1.2"  },
               new Cheque { Type = "Item 1.1", Carnet = "Item 1.2",Société = "Item 1.1", Banque = "Item 1.2",Compte = "Item 1.1", N_de_Chéque = "Item 1.2" , Date = "Item 1.1", Delai_de_Paiement = "Item 1.2",Bénéficiaires = "Item 1.1", Montant = "Item 1.2",Remis = "Item 1.1", Référence = "Item 1.2"  },
               new Cheque { Type = "Item 1.1", Carnet = "Itecccccccccccccccccccccccccccm 1.2",Société = "Item 1.1", Banque = "Item 1.2",Compte = "Item 1.1", N_de_Chéque = "Item 1.2" , Date = "Item 1.1", Delai_de_Paiement = "Item 1.2",Bénéficiaires = "Item 1.1", Montant = "Item 1.2",Remis = "Item 1.1", Référence = "Item 1.2"  }            };

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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
