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

namespace jogo_dos_7_erros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool imgErro1 = false;
        bool imgErro2 = false;
        bool imgErro3 = false;
        bool imgErro4 = false;
        bool imgErro5 = false;
        bool imgErro6 = false;
        bool imgErro7 = false;

        public MainWindow()
        {
            InitializeComponent();
            imgVazio1.Visibility = Visibility.Visible;
            imgDoErro1.Visibility = Visibility.Hidden;

            imgVazio2.Visibility = Visibility.Visible;
            imgDoErro2.Visibility = Visibility.Hidden;

            imgVazio3.Visibility = Visibility.Visible;
            imgDoErro3.Visibility = Visibility.Hidden;

            imgVazio4.Visibility = Visibility.Visible;
            imgDoErro4.Visibility = Visibility.Hidden;

            imgVazio5.Visibility = Visibility.Visible;
            imgDoErro5.Visibility = Visibility.Hidden;

            imgVazio6.Visibility = Visibility.Visible;
            imgDoErro6.Visibility = Visibility.Hidden;

            imgVazio7.Visibility = Visibility.Visible;
            imgDoErro7.Visibility = Visibility.Hidden;
        }


        private void erro1(object sender, MouseButtonEventArgs e)
        {
            imgDoErro1.Visibility = Visibility.Visible;
            imgErro1 = true;
            VerificaErros();
        }

        private void erro2(object sender, MouseButtonEventArgs e)
        {
            imgDoErro2.Visibility = Visibility.Visible;
            imgErro2 = true;
            VerificaErros();
        }

        private void erro3(object sender, MouseButtonEventArgs e)
        {
            imgDoErro3.Visibility = Visibility.Visible;
            imgErro3 = true;
            VerificaErros();
        }

        private void erro4(object sender, MouseButtonEventArgs e)
        {
            imgDoErro4.Visibility = Visibility.Visible;
            imgErro4 = true;
            VerificaErros();
        }

        private void erro5(object sender, MouseButtonEventArgs e)
        {
            imgDoErro5.Visibility = Visibility.Visible;
            imgErro5 = true;
            VerificaErros();
        }

        private void erro6(object sender, MouseButtonEventArgs e)
        {
            imgDoErro6.Visibility = Visibility.Visible;
            imgErro6 = true;
            VerificaErros();
        }

        private void erro7(object sender, MouseButtonEventArgs e)
        {
            imgDoErro7.Visibility = Visibility.Visible;
            imgErro7 = true;
            VerificaErros();
        }
        
        private void VerificaErros()
        {
            if (imgErro1 == true && imgErro2 == true && imgErro3 == true && imgErro4 == true &&
                imgErro5 == true && imgErro6 == true && imgErro7 == true)
            {
                MessageBoxResult result = MessageBox.Show(
                    "Você encontrou todos os erros.",
                    "Parabéns!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                    imgDoErro1.Visibility = Visibility.Hidden;
                    imgDoErro2.Visibility = Visibility.Hidden;
                    imgDoErro3.Visibility = Visibility.Hidden;
                    imgDoErro4.Visibility = Visibility.Hidden;
                    imgDoErro5.Visibility = Visibility.Hidden;
                    imgDoErro6.Visibility = Visibility.Hidden;
                    imgDoErro7.Visibility = Visibility.Hidden;

                    imgErro1 = false;
                    imgErro2 = false;
                    imgErro3 = false;
                    imgErro4 = false;
                    imgErro5 = false;
                    imgErro6 = false;
                    imgErro7 = false;
            }
        } 
        
    }
}
