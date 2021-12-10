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
    //Ventana del formulario
    public partial class Formulario_Piscinas : Window
    {
        public Piscina piscina; //Piscina que vamos a agregar o modificar
        private int index; //Index de la piscina
        public static List<string> Salas = new List<string>() { "Tropical", "Crustáceos", "Mamíferos", "Tiburones", "Medusas" }; //Listado de salas del acuario

        //Constructor que utilizaremos para agregar una piscina
        public Formulario_Piscinas()
        {
            InitializeComponent();
            this.index = -1; //-1 indica que no está en el Datagrid
            piscina = new Piscina();
            foreach(string s in Salas)
            {
                ComboBoxSalas.Items.Add(s);
            }
            ComboBoxSalas.SelectedIndex = 0;
            this.DataContext = piscina;
        }

        //Constructor que utilizaremos para modificar una piscina
        public Formulario_Piscinas(int index)
        {
            InitializeComponent();
            this.index = index; //El index corresponde con la piscina seleccionada en el Datagrid
            piscina = new Piscina();
            foreach (string s in Salas)
            {
                ComboBoxSalas.Items.Add(s);
            }
            ComboBoxSalas.SelectedItem = ControlWindow.logica.ListaPiscinas.ElementAt(index).Sala;
            this.DataContext = ControlWindow.logica.ListaPiscinas.ElementAt(index);
        }

        //Método para agregar una piscina
        private void Agregar(object sender, RoutedEventArgs e)
        {
            if(index > -1) //Modificar
            {
                piscina = new Piscina(ComboBoxSalas.Text, tb_temp.Text, tb_esp.Text, (DateTime)dp_revision.SelectedDate, tb_tratam.Text);
                ControlWindow.logica.Modificar(index, piscina);
                this.Close();
            } else //Insertar
            {
                ControlWindow.logica.Agregar(piscina);
                this.Close();
            }
            piscina = new Piscina();
            this.DataContext = piscina;
        }

        //Metodo para cerrar la ventana
        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Metodo para la validacion del formulario

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
