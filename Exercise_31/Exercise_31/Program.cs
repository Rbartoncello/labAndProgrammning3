using AtencionAlCliente;
namespace Exercise_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negocio elMaxiKiosko = new Negocio("El Maxi Kiosko");
            Cliente cliente1 = new Cliente("Juan", PuestoAtencion.NumeroActual);
            Cliente cliente2 = new Cliente("Leo",PuestoAtencion.NumeroActual);
            Cliente cliente3 = new Cliente("Julian",PuestoAtencion.NumeroActual);
            Cliente cliente4 = new Cliente("Ricky",PuestoAtencion.NumeroActual);

            elMaxiKiosko.Cliente = cliente1;
            elMaxiKiosko.Cliente = cliente2;
            elMaxiKiosko.Cliente = cliente1;
            elMaxiKiosko.Cliente = cliente4;

            foreach (Cliente cliente in elMaxiKiosko.Clientes)
            {
                Console.Write($"{cliente.Nombre} ");
            }

            Console.WriteLine(elMaxiKiosko == cliente1);
            Console.WriteLine(elMaxiKiosko == cliente3);
            Console.WriteLine(elMaxiKiosko + cliente3);
            Console.WriteLine(elMaxiKiosko == cliente3);
            Console.WriteLine(~elMaxiKiosko);
            Console.WriteLine(elMaxiKiosko == cliente1);
            Console.WriteLine(elMaxiKiosko + cliente2);

            foreach (Cliente cliente in elMaxiKiosko.Clientes)
            {
                Console.Write($"{cliente.Nombre} ");
            }
            Console.WriteLine(elMaxiKiosko.ClientesPendientes);

        }
    }
}