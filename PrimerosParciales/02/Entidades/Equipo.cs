using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string _nombre;
        protected int _partidosEmpatados;
        protected int _partidosGanados;
        protected int _partidosJugados;
        protected int _partidosPerdidos;
        protected int _puntacion;


        protected Equipo(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre => _nombre;

        public string Tipo => GetType().Name;

        protected int PE
        {
            get => _partidosEmpatados;
            set => _partidosEmpatados = value;
        }

        protected int PG
        {
            get => _partidosGanados;
            set => _partidosGanados = value;
        }

        protected int PJ
        {
            get => _partidosJugados;
            set => _partidosJugados = value;
        }

        protected int PP
        {
            get => _partidosPerdidos;
            set => _partidosPerdidos = value;
        }

        protected int Puntacion
        {
            get => _puntacion;
            set => _puntacion = value;
        }

        public override bool Equals(object? obj)
        {
            Equipo? that = obj as Equipo;
            return that?.Tipo == Tipo;
        }

        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return equipo1.Equals(equipo2) && equipo1.Nombre == equipo2.Nombre;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        protected string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nombre}");
            return sb.ToString();
        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if (!equipoA.Equals(equipoB)) 
                return false;

            equipoA.PJ++;
            equipoB.PJ++;

            if (equipoA.GetDificultad() > equipoB.GetDificultad())
            {
                equipoA.PG++;
                equipoA.Puntacion += 3;
                equipoB.PP++;
            }
            else if (equipoB.GetDificultad() > equipoA.GetDificultad())
            {
                equipoB.PG++;
                equipoB.Puntacion += 3;
                equipoA.PP++;
            }
            else
            {
                equipoA.PE++;
                equipoB.PE++;
                equipoA.Puntacion += 1;
                equipoB.Puntacion += 1;
            }

            return true;

        }

        public abstract int GetDificultad();
    }
}