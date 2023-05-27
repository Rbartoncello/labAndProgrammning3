using Entidades;

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
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                while(ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}