namespace Exersice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año de inicio");
            int startYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de fin");
            int finishYear = int.Parse(Console.ReadLine());

            for (int year = startYear; year <= finishYear; year++)
            {
                if (year % 4 == 0)
                {
                    if(year % 100 == 0){
                        if (year % 400 == 0)
                            Console.WriteLine(year);
                    } else 
                        Console.WriteLine(year);
                }
            }
        }
    }
}