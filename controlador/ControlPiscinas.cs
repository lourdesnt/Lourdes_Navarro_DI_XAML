using Lourdes_Navarro_DI_XAML.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lourdes_Navarro_DI_XAML.controlador
{
    //Clase para la lógica del control de piscinas
    public class ControlPiscinas
    {
        //Lista de piscinas
        public ObservableCollection<Piscina> ListaPiscinas { get; set; }

        //Constructor donde inicializamos la lista de piscina y añadimos una
        public ControlPiscinas()
        {
            ListaPiscinas = new ObservableCollection<Piscina>();
            ListaPiscinas.Add(new Piscina("Tropical", "20ºC", "Cangrejo, Langosta, Percebe", new DateTime(2021, 11, 23), "Desinfección de la piscina"));
        }

        //Metodo para agregar una piscina a la lista
        public void Agregar(Piscina piscina)
        {
            ListaPiscinas.Add(piscina);
        }

        //Metodo para modificar una piscina de la lista
        public void Modificar(int index, Piscina piscina)
        {
            ListaPiscinas[index] = piscina;
        }

        //Metodo para eliminar una piscina de la lista
        public void Eliminar(int index)
        {
            ListaPiscinas.RemoveAt(index);
        }
    }
}
