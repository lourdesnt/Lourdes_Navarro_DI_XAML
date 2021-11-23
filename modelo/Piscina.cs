using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lourdes_Navarro_DI_XAML.modelo
{
    public enum Sala { Tropical, Crustaceos, Mamiferos };
    public class Piscina : INotifyPropertyChanged
    {
        public Sala sala;
        public Sala Sala
        {
            get { return sala; }
            set
            {
                this.sala = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Sala"));
            }
        }

        private string temperatura;
        public string Temperatura
        {
            get { return temperatura; }
            set
            {
                this.temperatura = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Temperatura"));
            }
        }

        private string[] especies;
        public string[] Especies
        {
            get { return especies; }
            set
            {
                this.especies = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Especies"));
            }
        }

        private DateTime ultimaRevision;
        public DateTime UltimaRevision
        {
            get { return ultimaRevision; }
            set
            {
                this.ultimaRevision = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("UltimaRevision"));
            }
        }

        private string tratamiento;
        public string Tratamiento
        {
            get { return tratamiento; }
            set
            {
                this.tratamiento = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Tratamiento"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Piscina()
        {

        }

        public Piscina(Sala sala, string temperatura, string[] especies, DateTime ultimaRevision, string tratamiento)
        {
            this.sala = sala;
            this.temperatura = temperatura;
            this.especies = especies;
            this.ultimaRevision = ultimaRevision;
            this.tratamiento = tratamiento;
        }

    }
}
