using Conversion;
namespace Exercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario b = "1001";
            NumeroDecimal d = 9;


            Console.WriteLine(b + d);
            Console.WriteLine(b - d);
            Console.WriteLine(d + b);
            Console.WriteLine(d - b);
        }
    }
}