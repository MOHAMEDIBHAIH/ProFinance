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
    /// Logique d'interaction pour C_Société.xaml
    /// </summary>
    public partial class C_Société : UserControl
    {
        public C_Société()
        {
            InitializeComponent();
        }
       /* public Société[] Li = new Société[]
        {
               new Société { Logo = "Itccccccc 1.1", Raison_Social = "Item 1.2",Forme_juridique = "Item 1.1", ville = "Item 1.2"  },
               new Société { Logo = "Item 1.1", Raison_Social = "Item 1.2",Forme_juridique = "Item 1.1", ville = "Item 1.2" },
               new Société { Logo = "Item 1.1", Raison_Social = "Item 1.2",Forme_juridique = "Item 1.1", ville = "Item 1.2"  },
               new Société { Logo = "Item 1.1", Raison_Social = "Item 1.2",Forme_juridique = "Item 1.1", ville = "Item 1.2" },
               new Société { Logo = "Item 1.1", Raison_Social = "Itecccccccccccccccccccccccccccm 1.2",Forme_juridique = "Item 1.1", ville = "Item 1.2", }
        };*/

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //lisst.ItemsSource = Li;
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            
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
