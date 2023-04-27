using Libro;
using Libro = Libro.Libro1;

namespace Exercise_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro1 libr = new Libro1();

            libr[0] = "hola";
            libr[1] = "mundo";
            libr[2] = "soy";
            libr[3] = "german";
            libr[50] = "garmendia";

            Console.WriteLine("Hello, World!");
        }
    }
}