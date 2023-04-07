using Validate;


namespace Exercise11

{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            const int min = -100;
            const int maxNumbers = 10;
            int number;
            int maxNumber = 0;
            int minNumber = 0;
            double accumulator = 0;

            for (int i = 0; i < maxNumbers; i++)
            {
                Console.WriteLine("Ingrese un numero entre {0} y {1}", min, max);
                int.TryParse(Console.ReadLine(), out number);
                while (!Validate.Validate.ValidateRange(number, max, min))
                {
                    Console.WriteLine("Error!!!!. Ingrese un numero entre {0} y {1}", min, max);
                    int.TryParse(Console.ReadLine(), out number);
                }
                if (i == 0)
                    minNumber = number;

                accumulator += number;
                if(number > maxNumber)
                    maxNumber = number;
                else if (number < minNumber)
                    minNumber = number;
            }
            Console.WriteLine("El numero maximo fue {0}, el numero minimo fue {1} y el promedio {2}", maxNumber, minNumber, accumulator / maxNumbers);

        }
    }
}