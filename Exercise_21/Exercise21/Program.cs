using Temperature;
namespace Exercise21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius c = 25;
            Kelvin k = 25;
            Fahrenheit f = 25;

            Console.WriteLine(((Kelvin)c).getTemperature());
            Console.WriteLine(((Kelvin)f).getTemperature());
            Console.WriteLine(((Celsius)f).getTemperature());
            Console.WriteLine(((Celsius)k).getTemperature());
            Console.WriteLine(((Fahrenheit)c).getTemperature());
            Console.WriteLine(((Fahrenheit)k).getTemperature());

            Console.WriteLine($"{c.getTemperature()}c° + {f.getTemperature()}f° = {(c + f).getTemperature()}c°");
            Console.WriteLine($"{c.getTemperature()}c° + {f.getTemperature()}f° = {(f + c).getTemperature()}f°");



        }
    }
}