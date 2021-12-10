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
    //Ventana de la sala de tiburones
    public partial class SalaTiburones : Window
    {
        public SalaTiburones()
        {
            InitializeComponent();
        }

        //Metodo para volver a la pantalla de las salas
        private void Atras(object sender, RoutedEventArgs e)
        {
            new Salas().Show();
            this.Close();
        }
    }
}
