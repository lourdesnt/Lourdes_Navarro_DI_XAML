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
    //Ventana de contacto
    public partial class Contacto : Window
    {
        public Contacto()
        {
            InitializeComponent();
        }

        //Metodo para volver al menú
        private void Home(object sender, RoutedEventArgs e)
        {
            new AppPrincipal().Show();
            this.Close();
        }
    }
}
