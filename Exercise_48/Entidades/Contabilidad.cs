namespace Entidades
{
    public class Contabilidad<T,U> 
        where T : Documento
        where U : Documento, new()
    {
        List<T> _egresos;
        List<U> _ingreso;
        public Contabilidad()
        {
            _egresos = new List<T>();
            _ingreso = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.Egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.Ingreso.Add(ingreso);
            return c;
        }

        public List<T> Egresos => _egresos;

        public List<U> Ingreso => _ingreso;
    }
}