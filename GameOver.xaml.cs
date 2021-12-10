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
    //Ventana de derrota
    public partial class GameOver : Window
    {
        public GameOver()
        {
            InitializeComponent();
        }

        //Metodo para volver a la pantalla de minijuego
        private void Game(object sender, RoutedEventArgs e)
        {
            new Minijuego().Show();
            this.Close();
        }

        //Metodo para volver a la ventana del menú
        private void Home(object sender, RoutedEventArgs e)
        {
            new AppPrincipal().Show();
            this.Close();
        }
    }
}
