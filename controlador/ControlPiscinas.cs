using Lourdes_Navarro_DI_XAML.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lourdes_Navarro_DI_XAML.controlador
{
    public class ControlPiscinas
    {
        public ObservableCollection<Piscina> ListaPiscinas { get; set; }

        public ControlPiscinas()
        {
            ListaPiscinas = new ObservableCollection<Piscina>();
            ListaPiscinas.Add(new Piscina(Piscina.Salas[1], "20ºC", "Cangrejo, Langosta, Percebe", new DateTime(2021, 11, 23), "Desinfección de la piscina"));
        }

        public void Agregar(Piscina piscina)
        {
            ListaPiscinas.Add(piscina);
        }

        public void Modificar(int index, Piscina piscina)
        {
            ListaPiscinas[index] = piscina;
        }

        public void Eliminar(int index)
        {
            ListaPiscinas.RemoveAt(index);
        }
    }
}
