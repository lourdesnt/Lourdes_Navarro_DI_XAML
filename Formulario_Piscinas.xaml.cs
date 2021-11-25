using Lourdes_Navarro_DI_XAML.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Lógica de interacción para Formulario_Piscinas.xaml
    /// </summary>
    public partial class Formulario_Piscinas : Window
    {
        public Piscina piscina;
        private int index;

        public Formulario_Piscinas()
        {
            InitializeComponent();
            this.index = -1;
            piscina = new Piscina();
            ComboBoxSalas.ItemsSource = Piscina.Salas;
            this.DataContext = piscina;
        }

        public Formulario_Piscinas(int index)
        {
            InitializeComponent();
            this.index = index;
            piscina = new Piscina();
            ComboBoxSalas.ItemsSource = Piscina.Salas;
            ComboBoxSalas.SelectedItem = ControlWindow.logica.ListaPiscinas.ElementAt(index).Sala;
            this.DataContext = ControlWindow.logica.ListaPiscinas.ElementAt(index);
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if(index > -1)
            {
                piscina = new Piscina(ComboBoxSalas.SelectedItem.ToString(), tb_temp.Text, tb_esp.Text, (DateTime)dp_revision.SelectedDate, tb_tratam.Text);
                ControlWindow.logica.Modificar(index, piscina);
                this.Close();
            } else
            {
                ControlWindow.logica.Agregar(piscina);
            }
            piscina = new Piscina();
            this.DataContext = piscina;
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
