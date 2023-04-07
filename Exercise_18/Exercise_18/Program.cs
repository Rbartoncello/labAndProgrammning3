using Geometria;
namespace Exercise_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto point1 = new Punto(1, 1);
            Punto point2 = new Punto(4, 5);

            Rectangulo rec = new Rectangulo(point1, point2);

            rec.Mostrar();
        }
    }
}