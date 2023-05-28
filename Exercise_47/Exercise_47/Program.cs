using Entidades;
namespace Exercise_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("LPF");
            Torneo<EquipoBasquet> torneoBasket = new Torneo<EquipoBasquet>("NBA");

            EquipoFutbol river = new EquipoFutbol("river", DateTime.Today);
            EquipoFutbol boca = new EquipoFutbol("boca", DateTime.Today);
            EquipoFutbol independiente = new EquipoFutbol("independiente", DateTime.Today);
            EquipoBasquet miami = new EquipoBasquet("miami", DateTime.Today);
            EquipoBasquet la = new EquipoBasquet("la", DateTime.Today);
            EquipoBasquet orlando = new EquipoBasquet("orlando", DateTime.Today);

            if (torneoFutbol + river && torneoFutbol + boca && torneoFutbol + independiente)
            {
                Console.WriteLine(torneoFutbol.Mostrar());
                Console.WriteLine(torneoFutbol.JugarPartido);
                Console.WriteLine(torneoFutbol.JugarPartido);
                Console.WriteLine(torneoFutbol.JugarPartido);
            }
            if (torneoBasket + miami && torneoBasket + la && torneoBasket + orlando)
            {
                Console.WriteLine(torneoBasket.Mostrar());
                Console.WriteLine(torneoBasket.JugarPartido);
                Console.WriteLine(torneoBasket.JugarPartido);
                Console.WriteLine(torneoBasket.JugarPartido);
            }

        }
    }
}