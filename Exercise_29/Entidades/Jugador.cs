namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugador;
        private int promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugador = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugador = totalPartidos;
        }

        private void CalcularPromedioGoles()
        {
            if (this.partidosJugador > 0)
            {
                this.promedioGoles = this.totalGoles / this.partidosJugador;
            }
        }

        public float GetPromedioGoles()
        {
            this.CalcularPromedioGoles();
            return this.promedioGoles;
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public string MostrarDatos()
        {
            return $"Jugador: {this.nombre} \n " +
                   $"Dni: {this.dni} \n " +
                   $"Partidos jugados: {this.partidosJugador} \n " +
                   $"Promedio de goles: {this.promedioGoles} \n " +
                   $"Total de goles: {this.totalGoles} \n";
        }

        public static bool operator ==(Jugador jugagor1, Jugador jugagor2)
        {
            return jugagor1.Dni == jugagor2.Dni;
        }

        public static bool operator !=(Jugador jugagor1, Jugador jugagor2)
        {
            return !(jugagor1.Dni == jugagor2.Dni);
        }
    }
}