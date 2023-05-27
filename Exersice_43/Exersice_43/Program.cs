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
                Competencia c = new Competencia(1, 2, Competencia.ETipoCompetencia.F1);
                if (c != a1 && c + a1)
                {
                    Console.WriteLine(a1.ToString());
                }
                if (c != a2 && c + a2)
                {
                    Console.WriteLine(a2.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                while (e.InnerException is not null)
                {
                    e = e.InnerException;
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}