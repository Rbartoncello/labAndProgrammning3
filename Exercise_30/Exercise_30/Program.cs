using Entidades;
namespace Exercise_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia ganPrix = new Competencia(4, 200);
            AutoF1 McQueen = new AutoF1("cars", 95);
            AutoF1 Messi = new AutoF1("torino", 78);
            AutoF1 Fort = new AutoF1("fort", 42);
            AutoF1 Chevrolet = new AutoF1("chevrolet", 84);
            AutoF1 Tesla = new AutoF1("tesla", 22);

            bool ingreso = ganPrix - McQueen;
            ingreso = ganPrix + Tesla;
            ingreso = ganPrix - Messi;
            ingreso = ganPrix + Fort;
            ingreso = ganPrix + Fort;
            ingreso = ganPrix + Tesla;
            ingreso = ganPrix + Chevrolet;

            Console.WriteLine($"{ganPrix.MostrarDatos()}");
        }
    }
}