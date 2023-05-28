using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> _equipos;
        private string _nombre;

        public Torneo(string nombre)
        {
            this._nombre = nombre;
            this._equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            return t.Equipos.Contains(e);
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t==e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            if(t == e)
                return false;
            t.Equipos.Add(e);
            return true;
        }

        public string Nombre => _nombre;

        public List<T> Equipos => _equipos;

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.Nombre}");
            this.Equipos.ForEach(e => { sb.AppendLine(e.Ficha());});
            return sb.ToString();
        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random rd = new Random();

            return $"{equipo1.Nombre} {rd.Next(0,10)} - {rd.Next(0, 10)} {equipo2.Nombre}";
        }

        public string JugarPartido
        {
            get
            {
                Random rd = new Random();
                int rdIndex1 = rd.Next(0, this.Equipos.Count);
                int rdIndex2 = rd.Next(0, this.Equipos.Count);

                return this.CalcularPartido(this.Equipos[rdIndex1], this.Equipos[rdIndex2]);
            }
        }
    }
}