using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace Lourdes_Navarro_DI_XAML.modelo
{

    public class Piscina : INotifyPropertyChanged, IDataErrorInfo
    {
        public static List<string> Salas = new List<string>() { "Tropical", "Crustáceos", "Mamíferos", "Tiburones", "Medusas" };

        public string sala;
        public string Sala
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

        private string especies;
        public string Especies
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

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "Temperatura")
                {
                    if (string.IsNullOrEmpty(temperatura))
                        result = "Este campo no puede estar vacío";
                }
                if (columnName == "Especies")
                {
                    if (string.IsNullOrEmpty(especies))
                        result = "Este campo no puede estar vacío";
                }
                if (columnName == "UltimaRevision")
                {
                    if (ultimaRevision.ToString().Equals(null))
                        result = "Este campo no puede estar vacío";
                }
                if (columnName == "Tratamiento")
                {
                    if (string.IsNullOrEmpty(tratamiento))
                        result = "Este campo no puede estar vacío";
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Piscina()
        {

        }

        public Piscina(string sala, string temperatura, string especies, DateTime ultimaRevision, string tratamiento)
        {
            this.sala = sala;
            this.temperatura = temperatura;
            this.especies = especies;
            this.ultimaRevision = ultimaRevision;
            this.tratamiento = tratamiento;
        }

        
    }
}
