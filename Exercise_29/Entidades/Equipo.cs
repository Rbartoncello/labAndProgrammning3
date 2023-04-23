using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre): this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }

        private void agregarJugador(Jugador j)
        {
            this.jugadores.Add(j);
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool existeJugador = false;

            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                {
                    existeJugador = true;
                    break;
                }
            }

            if (!existeJugador && e.jugadores.Count <= e.cantidadDeJugadores)
                e.agregarJugador(j);

            return (!existeJugador && e.jugadores.Count <= e.cantidadDeJugadores);
        }

        public void Mostrar()
        {
            string mensaje = $"{this.nombre} \n Jugadores: \n";

            foreach (Jugador jugador in this.jugadores)
            {
                mensaje += $"{jugador.MostrarDatos()}\n";
            }

            Console.WriteLine(mensaje);
        }

    }
}