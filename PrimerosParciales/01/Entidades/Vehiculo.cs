using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private string _patente;
        private DateTime _horaIngreso;
        private DateTime _horaEgreso;
        public enum EVehiculos
        {
            Automovil,
            Moto
        }

        public Vehiculo(DateTime horaIngreso, string patente)
        {
            this.HoraIngreso = horaIngreso;
            Patente = patente;
        }

        private bool ValidarPatente(string patente)
        {
            return patente.Length is 6 or 7;
        }

        public string Patente
        {
            get => this._patente;
            set
            {
                if (this.ValidarPatente(value))
                    this._patente = value;
                
            }
        }

        public DateTime HoraIngreso { get; }

        

        public abstract string Desciption
        {
            get;
        }

        public abstract double CostoEstadia
        {
            get;
        }

        public DateTime HoraEgreso
        {
            get => _horaEgreso;
            set
            {
                if(value > _horaIngreso)
                    _horaEgreso = value;
            }
        }

        protected virtual double CargoEstacionamiento()
        {
            TimeSpan tiempoTranscurrido = _horaEgreso - HoraIngreso;

            return tiempoTranscurrido.TotalMinutes;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {Patente}");
            sb.AppendLine($"Hora de ingreso {HoraIngreso}");

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}