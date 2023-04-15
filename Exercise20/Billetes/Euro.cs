namespace Billetes;

public class Euro
{
    private double cantidad;
    private static double cotizRespectoDolar;

    static Euro()
    {
        Euro.cotizRespectoDolar = 0.9053;
    }
    public Euro(double cantidad)
    {
        this.cantidad = cantidad;
    }

    public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
    {
        Euro.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double getCantidad()
    {
        return this.cantidad;
    }

    public static double getCotizacion()
    {
        return Euro.cotizRespectoDolar;
    }

    public static implicit operator Euro(double d)
    {
        return new Euro(d);
    }

    public static explicit operator Dolar(Euro e)
    {
        return new Dolar(e.cantidad / Euro.getCotizacion());
    }

    public static explicit operator Peso(Euro e)
    {
        return (Peso)((Dolar)e);
    }

    public static bool operator ==(Euro e1, Euro e2)
    {
        return e1.cantidad == e2.cantidad;
    }

    public static bool operator !=(Euro e1, Euro e2)
    {
        return !(e1 == e2);
    }

    public static bool operator ==(Euro e, Dolar d)
    {
        return d == (Dolar)e;
    }

    public static bool operator !=(Euro e, Dolar d)
    {
        return !(e == d);
    }

    public static bool operator ==(Euro e, Peso p)
    {
        return e == (Euro)p;
    }

    public static bool operator !=(Euro e, Peso p)
    {
        return !(e == p);
    }

    public static Euro operator +(Euro e, Dolar d)
    {
        return new Euro(e.getCantidad() + ((Euro)d).getCantidad());
    }

    public static Euro operator +(Euro e, Peso p)
    {
        return new Euro(e.getCantidad() + ((Euro)p).getCantidad());
    }

    public static Euro operator -(Euro e, Dolar d)
    {
        return new Euro(d.getCantidad() - ((Euro)d).getCantidad());
    }

    public static Euro operator -(Euro e, Peso p)
    {
        return new Euro(e.getCantidad() - ((Euro)p).getCantidad());
    }
}