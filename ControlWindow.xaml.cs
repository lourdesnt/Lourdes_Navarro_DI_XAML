using Lourdes_Navarro_DI_XAML.controlador;
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
    /// Lógica de interacción para ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        public static ControlPiscinas logica = new ControlPiscinas();
        public ControlWindow()
        {
            InitializeComponent();
            DataGridPiscinas.DataContext = logica;
        }

        private void AgregarPiscina(object sender, RoutedEventArgs e)
        {
            new Formulario_Piscinas().Show();
        }

        private void EditarPiscina(object sender, RoutedEventArgs e)
        {
            if(DataGridPiscinas.SelectedIndex != -1)
            {
                new Formulario_Piscinas(DataGridPiscinas.SelectedIndex).Show();
            }
        }
        private void EliminarPiscina(object sender, RoutedEventArgs e)
        {
            if (DataGridPiscinas.SelectedIndex != -1)
            {
                logica.Eliminar(DataGridPiscinas.SelectedIndex);
            }
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            new AppPrincipal().Show();
            this.Close();
        }
    }
}
