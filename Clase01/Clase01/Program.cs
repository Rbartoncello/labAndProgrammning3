namespace Clase01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresae numero!");
            int number = int.Parse(Console.ReadLine());

            while (number <= 0)
            {
                Console.WriteLine("ERROR. Reingresae numero!");
                Console.WriteLine("Ingresae numero!");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El cuadro es {0} y el cubo {1}", Math.Pow(number, 2), Math.Pow(number, 3));
        }
    }
}