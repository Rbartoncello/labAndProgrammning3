using entidades;
namespace Exersice17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo penBlue = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo penRed = new Boligrafo(ConsoleColor.Red, 6);

            string draw = string.Empty;


            if (penRed.Pintar(5, out draw))
            {
                Console.ForegroundColor = penRed.GetColor();
                Console.WriteLine(draw);
            }
            if (penBlue.Pintar(5, out draw))
            {
                Console.ForegroundColor = penBlue.GetColor();
                Console.WriteLine(draw);
            }
            draw = string.Empty;
            if (penRed.Pintar(5, out draw))
            {
                Console.ForegroundColor = penRed.GetColor();
                Console.WriteLine(draw);
            }

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}