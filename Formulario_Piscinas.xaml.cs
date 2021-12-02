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
        public static List<string> Salas = new List<string>() { "Tropical", "Crustáceos", "Mamíferos", "Tiburones", "Medusas" };

        public Formulario_Piscinas()
        {
            InitializeComponent();
            this.index = -1;
            piscina = new Piscina();
            foreach(string s in Salas)
            {
                ComboBoxSalas.Items.Add(s);
            }
            ComboBoxSalas.SelectedIndex = 0;
            this.DataContext = piscina;
        }

        public Formulario_Piscinas(int index)
        {
            InitializeComponent();
            this.index = index;
            piscina = new Piscina();
            foreach (string s in Salas)
            {
                ComboBoxSalas.Items.Add(s);
            }
            ComboBoxSalas.SelectedItem = ControlWindow.logica.ListaPiscinas.ElementAt(index).Sala;
            this.DataContext = ControlWindow.logica.ListaPiscinas.ElementAt(index);
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if(index > -1)
            {
                piscina = new Piscina(ComboBoxSalas.Text, tb_temp.Text, tb_esp.Text, (DateTime)dp_revision.SelectedDate, tb_tratam.Text);
                ControlWindow.logica.Modificar(index, piscina);
                this.Close();
            } else
            {
                ControlWindow.logica.Agregar(piscina);
                this.Close();
            }
            piscina = new Piscina();
            this.DataContext = piscina;
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        int errores;
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            } else
            {
                errores--;
            }
            if (errores == 0)
            {
                BtnAgregar.IsEnabled = true;
            } else
            {
                BtnAgregar.IsEnabled = false;
            }
        }
    }
}
