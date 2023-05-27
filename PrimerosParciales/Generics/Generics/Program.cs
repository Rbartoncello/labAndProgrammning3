using Entidades;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiClaseGenerica<int> miClase = new MiClaseGenerica<int>();
            MiClaseGenerica<string> miClaseString = new MiClaseGenerica<string>();

            miClase.ImprimirValor(10);
            miClaseString.ImprimirValor("Hello, world");

        }
    }
}