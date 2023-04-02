namespace Exerise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountNumber = 0;
            int number = 1;
            int acountTemp = 0;
            const int END_NUMBER = 4;

            while (amountNumber < END_NUMBER)
            {
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        acountTemp += i;
                    }
                }
                if(acountTemp == number)
                {
                    Console.WriteLine(number);
                    amountNumber++;
                }
                acountTemp = 0;
                number++;
            }
        }
    }
}