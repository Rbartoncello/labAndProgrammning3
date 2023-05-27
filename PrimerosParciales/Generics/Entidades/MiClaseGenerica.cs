namespace Entidades
{
    public class MiClaseGenerica<T>
    {


        public void ImprimirValor(T generico)
        {
            Console.WriteLine(generico);
        }
    }
}