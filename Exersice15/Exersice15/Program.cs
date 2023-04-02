using Calculadora;
namespace Exersice15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            double numeroTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion");
            char operation = char.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} = {3}", numeroOne, operation, numeroTwo,
                Calculadora.Calculadora.Calcular(numeroOne, numeroTwo, operation));
        }
    }
}