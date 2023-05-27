using Entidades.Classes;

namespace Exercise_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otra = new OtraClase();
                otra.MetodoInstancia();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                while (e.InnerException is not null)
                {
                    e = e.InnerException;
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}