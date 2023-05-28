using Entidades;
namespace Exercise_48_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo = new Recibo();
            Factura factura = new Factura(10);

            Contabilidad<Factura, Recibo> contab = new Contabilidad<Factura, Recibo>();

            contab += factura;
            contab += recibo;

            foreach (var e in contab.Egresos)
            {
                Console.WriteLine(e.Numero);
            }
            foreach (var r in contab.Ingreso)
            {
                Console.WriteLine(r.Numero);
            }


        }
    }
}