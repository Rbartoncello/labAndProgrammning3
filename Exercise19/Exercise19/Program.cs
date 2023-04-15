using Operaciones;
namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador s = new Sumador();

            Console.WriteLine(s.Sumar(4, 5));
            Console.WriteLine(s.Sumar("Hello", "World"));

            Sumador s2 = new Sumador(5);
            Sumador s3 = new Sumador(7);

            Console.WriteLine(s2 + s3);
            Console.WriteLine(s2 | s3);
            Console.WriteLine((int)s2);
        }
    }
}