using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace ProFinance
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Perform logout action
            // For example:
            MessageBox.Show("Logout clicked");
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border button = (Border)sender;
            button.ContextMenu.PlacementTarget = button;
            button.ContextMenu.IsOpen = true;
        }

        private void btn_cheque_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (cheque.Height == 140)
            {
                cheque.Height = 60;
                btn_cheque_parent.RowDefinitions[1].Height = new GridLength(0);
                btn_cheque_parent.RowDefinitions[2].Height = new GridLength(0);

                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = 0;
                seemoreincheque.RenderTransform = rotateTransform;

                seemoreincheque.RenderTransformOrigin = new Point(0.5, 0.5);
            }
            else
            {
                cheque.Height = 140;
                btn_cheque_parent.RowDefinitions[1].Height = new GridLength(40);
                btn_cheque_parent.RowDefinitions[2].Height = new GridLength(40);

                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = 90;
                seemoreincheque.RenderTransform = rotateTransform;

                seemoreincheque.RenderTransformOrigin = new Point(0.5, 0.5);
            }


        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (virement.Height == 140)
            {
                virement.Height = 60;
                btn_virement_parent.RowDefinitions[1].Height = new GridLength(0);
                btn_virement_parent.RowDefinitions[2].Height = new GridLength(0);

                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = 0;
                seemoreinvirement.RenderTransform = rotateTransform;

                seemoreinvirement.RenderTransformOrigin = new Point(0.5, 0.5);
            }
            else
            {
                virement.Height = 140;
                btn_virement_parent.RowDefinitions[1].Height = new GridLength(40);
                btn_virement_parent.RowDefinitions[2].Height = new GridLength(40);


                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = 90;
                seemoreinvirement.RenderTransform = rotateTransform;

                seemoreinvirement.RenderTransformOrigin = new Point(0.5, 0.5);

            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            main_panel.Children.Clear();
            C_Dashborad c_Dashborad = new C_Dashborad();
            main_panel.Children.Add(c_Dashborad);
        }
        private void dashborad_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Dashborad c_Dashborad = new C_Dashborad();
            main_panel.Children.Add(c_Dashborad);

        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Cheque C_Cheque = new C_Cheque();
            main_panel.Children.Add(C_Cheque);
        }

        private void Grid_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_ChequeEmis c_ChequeEffetsxaml = new C_ChequeEmis();
            main_panel.Children.Add(c_ChequeEffetsxaml);
        }

        private void remise_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Remise c_Remise = new C_Remise();
            main_panel.Children.Add(c_Remise);
        }

        private void Grid_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_VirementRecu C_VirementRecu = new C_VirementRecu();
            main_panel.Children.Add(C_VirementRecu);
        }

        private void Grid_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_VirementEmis C_VirementEmis = new C_VirementEmis();
            main_panel.Children.Add(C_VirementEmis);
        }

        private void compte_bancaire_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_CompteBanquaire C_CompteBanquaire = new C_CompteBanquaire();
            main_panel.Children.Add(C_CompteBanquaire);
        }

        private void Beneficiaires_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Beneficiaires C_CompteBanquaire = new C_Beneficiaires();
            main_panel.Children.Add(C_CompteBanquaire);
        }

        private void societe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Société C_CompteBanquaire = new C_Société();
            main_panel.Children.Add(C_CompteBanquaire);
        }

        private void repport_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Repport C_CompteBanquaire = new C_Repport();
            main_panel.Children.Add(C_CompteBanquaire);
        }

        private void settings_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Settings C_CompteBanquaire = new C_Settings();
            main_panel.Children.Add(C_CompteBanquaire);
        }

        private void btn_effet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (effet.Height == 140)
            {
                effet.Height = 60;
                btn_effet_parent.RowDefinitions[1].Height = new GridLength(0);
                btn_effet_parent.RowDefinitions[2].Height = new GridLength(0);
                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = 0;
                seemoreineffet.RenderTransform = rotateTransform;
                seemoreineffet.RenderTransformOrigin = new Point(0.5, 0.5);
            }
            else
            {
                effet.Height = 140;
                btn_effet_parent.RowDefinitions[1].Height = new GridLength(40);
                btn_effet_parent.RowDefinitions[2].Height = new GridLength(40);


                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = 90;
                seemoreineffet.RenderTransform = rotateTransform;
                seemoreinvirement.RenderTransformOrigin = new Point(0.5, 0.5);

            }
        }

        private void Grid_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_EffetRecu C_EffetRecu = new C_EffetRecu();
            main_panel.Children.Add(C_EffetRecu);
        }

        private void Grid_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_EffetEmis C_EffetEmis = new C_EffetEmis();
            main_panel.Children.Add(C_EffetEmis);
        }
        private void Carnet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            main_panel.Children.Clear();
            C_Carnet C_Carnet = new C_Carnet();
            main_panel.Children.Add(C_Carnet);
        }
    }
}
