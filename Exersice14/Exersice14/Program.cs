using Calculo;

namespace Exersice14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double sideSquare = 5;
            const double baseTriangle = 5;
            const double heightTriangle = 10;
            const double radioCircule = 5;
            Console.WriteLine("El area de: un cuadrado de {0} es {1}, un triangulo de {2} base y de {3} altura es {4} y un circulo de {5} de radio es {6}", sideSquare, Calculo.Area.CalcularCuadrado(sideSquare), baseTriangle, heightTriangle, Calculo.Area.CalcularTriangulo(baseTriangle, heightTriangle), radioCircule, Calculo.Area.CalcularCirculo(radioCircule));
        }
    }
}