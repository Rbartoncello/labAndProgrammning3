using Conversion;

namespace Exersice13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int number = 52;
            Console.WriteLine("{0} to binary {1}", number, Conversion.Conversion.DecimalBinario(number));
            Console.WriteLine("{0} to decimal {1}", Conversion.Conversion.DecimalBinario(number), Conversion.Conversion.BinarioDecimal(Conversion.Conversion.DecimalBinario(number)));
        }
    }
}