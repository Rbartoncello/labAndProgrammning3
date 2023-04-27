using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre): this()
        {
            this._nombre = nombre;
            this._cantidadDeJugadores = cantidadDeJugadores;
        }

        private void AgregarJugador(Jugador j)
        {
            this._jugadores.Add(j);
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool existeJugador = e._jugadores.Any(jugador => jugador == j);

            if (!existeJugador && e._jugadores.Count <= e._cantidadDeJugadores)
                e.AgregarJugador(j);

            return (!existeJugador && e._jugadores.Count <= e._cantidadDeJugadores);
        }

        public void Mostrar()
        {
            string mensaje = $"{this._nombre} \n Jugadores: \n";

            foreach (Jugador jugador in this._jugadores)
            {
                mensaje += $"{jugador.MostrarDatos()}\n";
            }

            Console.WriteLine(mensaje);
        }

    }
}