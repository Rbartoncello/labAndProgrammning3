namespace Exersice10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int height = int.Parse(Console.ReadLine());
            string row = "*";
            int amuntEspaces = height-1;
            string espaces = "";

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= amuntEspaces; j++)
                {
                    espaces += " ";
                }
                Console.WriteLine("{0} - \t{1}", i, espaces + row);
                row += "**";
                espaces = "";
                amuntEspaces--;
            }
        }
    }
}