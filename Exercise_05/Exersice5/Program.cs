namespace Exerise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int acountTempLeft = 0;
            int acountTempRigth = 0;
            int iPost;

            int END_NUMBER = int.Parse(Console.ReadLine());

            while (number < END_NUMBER)
            {
                for (int i = 1; i < number; i++)
                {
                        acountTempLeft+= i;
                }
                iPost = number + 1;
                while(acountTempLeft > acountTempRigth)
                {
                    acountTempRigth += iPost;
                    iPost++;
                }
                if (acountTempLeft == acountTempRigth)
                {
                    Console.WriteLine(number);
                }
                number++;
                acountTempLeft = 0;
                acountTempRigth = 0;
            }
        }
    }
}