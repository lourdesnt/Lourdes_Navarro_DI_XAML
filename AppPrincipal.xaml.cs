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
    // Ventana donde se encuentran los diferentes apartados de la aplicacion
    public partial class AppPrincipal : Window
    {
        public AppPrincipal()
        {
            InitializeComponent();
        }

        //Metodo para acceder a la ventana de control de piscinas
        private void goControl(object sender, RoutedEventArgs e)
        {
            new ControlWindow().Show();
            this.Close();

        }

        //Metodo para acceder a la ventana de salas del acuario
        private void goSalas(object sender, RoutedEventArgs e)
        {
            new Salas().Show();
            this.Close();

        }

        //Metodo para acceder a la ventana de minijuego
        private void goMinijuego(object sender, RoutedEventArgs e)
        {
            new Minijuego().Show();
            this.Close();

        }

        //Metodo para acceder a la ventana de contacto
        private void goContacto(object sender, RoutedEventArgs e)
        {
            new Contacto().Show();
            this.Close();

        }

        //Metodo para volver a la ventana de inicio
        private void Home(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
