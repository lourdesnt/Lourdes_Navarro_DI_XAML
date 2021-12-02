using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lourdes_Navarro_DI_XAML
{
    /// <summary>
    /// Lógica de interacción para Minijuego.xaml
    /// </summary>
    public partial class Minijuego : Window
    {
        public Minijuego()
        {
            InitializeComponent();

        }
        private void isStar(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
            Star.Visibility = Visibility.Visible;
            new Win().Show();
            this.Close();
        }
        private void isErizo1(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
            Erizo1.Visibility = Visibility.Visible;
            new GameOver().Show();
            this.Close();
        }
        private void isErizo2(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
            Erizo2.Visibility = Visibility.Visible;
            new GameOver().Show();
            this.Close();
        }
        private void isErizo3(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
            Erizo3.Visibility = Visibility.Visible;
            new GameOver().Show();
            this.Close();
        }

        private void isEmpty(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            new AppPrincipal().Show();
            this.Close();
        }


    }
}
