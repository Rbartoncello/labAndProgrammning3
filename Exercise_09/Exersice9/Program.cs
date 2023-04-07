namespace Exersice9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int height = int.Parse(Console.ReadLine());
            string row = "*";
            int flag = 1;

            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine("{0} - {1}",i,row);
                row += "**";
            }
        }
    }
}