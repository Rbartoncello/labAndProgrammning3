namespace Exersice_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            Random rnd = new Random();
            int numb = rnd.Next(-100, 100);
            for (int i = 0; i < 20; i++)
            {
                if(numb != 0)
                    numbers[i] = numb;
                numb = rnd.Next(-100, 100);
            }

            int countPositiveInt = 0;
            int countNegativeInt = 0;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                if (number > 0)
                    countPositiveInt++;
                else
                    countNegativeInt++;
            }

            int[] numbersPositiveInts = new int[countPositiveInt];
            int[] numbersNegativerInts = new int[countNegativeInt];
            int k = 0, j = 0;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    numbersNegativerInts[k] = number;
                    k++;
                }
                else
                {
                    numbersPositiveInts[j] = number;
                    j++;
                }
            }

            Array.Sort(numbersPositiveInts);
            Array.Reverse(numbersPositiveInts);
            Array.Sort(numbersNegativerInts);

            foreach (int number in numbersPositiveInts)
                Console.Write($" {number} | ");

            Console.WriteLine("\n---------------");


            foreach (int number in numbersNegativerInts)
                Console.Write($"{number} | ");


        }
    }
}