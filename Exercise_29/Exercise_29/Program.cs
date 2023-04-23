using Entidades;
namespace Exercise_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo River = new Equipo(22, "River Plate");

            Jugador Enzo = new Jugador(42662995, "Enzo Perez");

            Jugador Julian = new Jugador(42332995, "Julian Alvarez");

            Jugador Pedro = new Jugador(43362995, "Pedro Pascal");

            bool pudoAgregar = River + Enzo;
            bool pudoAgregar2 = River + Julian;
            bool pudoAgregar3 = River + Pedro;

            River.Mostrar();
        }
    }
}