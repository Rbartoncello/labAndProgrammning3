using Validations;

namespace Exersice12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            char answer = 'n';

            while (!Validations.AnswerValidations.ValidaS_N(answer))
            { 
                Console.WriteLine("Ingrese un numero");
                sum += int.Parse(Console.ReadLine());
                Console.WriteLine("Continuar ? (S / N).");
                char.TryParse(Console.ReadLine(), out answer);
            }
            Console.WriteLine("lA SUMA FUE {0}", sum);

        }
    }
}