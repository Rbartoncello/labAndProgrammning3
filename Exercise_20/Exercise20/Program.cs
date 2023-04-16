using Billetes;
namespace Exercise20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso peso = 400;

            Dolar dolar = (Dolar)peso;
            Console.WriteLine(dolar.getCantidad());
        }
    }
}