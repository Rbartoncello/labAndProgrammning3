namespace Exersice7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dia de nacimiento");
            int dayBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes de nacimiento");
            int monthBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de nacimiento");
            int yearBorn = int.Parse(Console.ReadLine());

            DateTime dateBorn = new DateTime(yearBorn, monthBorn, dayBorn);
            DateTime dateNow = DateTime.Now;

            TimeSpan diffSubtract = dateNow.Subtract(dateBorn);

            Console.WriteLine("Dias vividos {0}", diffSubtract.Days);
        }
    }
}