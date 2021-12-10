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
    //Ventana de la sala de crustaceos
    public partial class SalaCrustaceos : Window
    {
        public SalaCrustaceos()
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
