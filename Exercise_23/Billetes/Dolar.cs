namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizRespectoDolar): this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static double getCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.getCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.getCotizacion());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.getCantidad() + ((Dolar)e).getCantidad());
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.getCantidad() + ((Dolar)p).getCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.getCantidad() - ((Dolar)e).getCantidad());
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.getCantidad() - ((Dolar)p).getCantidad());
        }
    }
}