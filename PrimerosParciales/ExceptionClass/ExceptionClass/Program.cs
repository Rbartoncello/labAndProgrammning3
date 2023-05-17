using Entidades.Models;
namespace ExceptionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroA;
            string numeroB;
            Calculadora calculadora;
            Console.WriteLine("Ingrese numero");
            numeroA = Console.ReadLine();

            Console.WriteLine("Ingrese numero");
            numeroB = Console.ReadLine();

            try
            {
                calculadora = new Calculadora(numeroA, numeroB);
                Console.WriteLine($"{calculadora.Dividir()}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}