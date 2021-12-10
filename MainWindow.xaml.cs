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

namespace Lourdes_Navarro_DI_XAML
{
    // Ventana principal de la Aplicacion
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Metodo para acceder a la ventana con los diferentes apartados
        private void goApp(object sender, RoutedEventArgs e)
        {
            new AppPrincipal().Show();
            this.Close();
        }
    }
}
