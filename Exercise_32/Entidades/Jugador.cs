namespace Entidades
{
    public class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private int _totalGoles;

        private Jugador()
        {
            this._partidosJugados = 0;
            this._totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            _dni = dni;
            _nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }

        public int Dni
        {
            get => this._dni;
            set => _dni = value;
        }

        public int PartidosJugados => _partidosJugados;

        public int PromedioGoles {
            get
            {
                if (this.PartidosJugados > 0)
                    return this.TotalGoles / this.PartidosJugados;
                return 0;
            }
        }

        public int TotalGoles => _totalGoles;

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string MostrarDatos()
        {
            return $"Jugador: {this.Nombre} \n " +
                   $"Dni: {this.Dni} \n " +
                   $"Partidos jugados: {this.PartidosJugados} \n " +
                   $"Promedio de goles: {this.PromedioGoles} \n " +
                   $"Total de goles: {this.TotalGoles} \n";
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.Dni == jugador2.Dni;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}