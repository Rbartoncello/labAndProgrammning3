using Entidades;

namespace Exersice_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AutoF1 a1 = new AutoF1("a1", 1);
                AutoF1 a2 = new AutoF1("a2", 2);
                Competencia c = new Competencia(0, 2, Competencia.ETipoCompetencia.F1);
                if (c != a1 && c + a1)
                {
                    Console.WriteLine(a1.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}\n");
                while (e.InnerException is not null)
                {
                    e = e.InnerException;
                    Console.WriteLine($"{e}\n");
                }
            }
        }
    }
}