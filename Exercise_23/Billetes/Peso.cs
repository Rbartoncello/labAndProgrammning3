namespace Billetes;

public class Peso
{
    private double cantidad;
    private static double cotizRespectoDolar;

    static Peso()
    {
        Peso.cotizRespectoDolar = 400;
    }
    public Peso(double cantidad)
    {
        this.cantidad = cantidad;
    }

    public static void SetCotizacion(double cotizacion)
    {
        Peso.cotizRespectoDolar = cotizacion;
    }

    public Peso(double cantidad, double cotizRespectoDolar) : this(cantidad)
    {
        Peso.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double getCantidad()
    {
        return this.cantidad;
    }

    public static double getCotizacion()
    {
        return Peso.cotizRespectoDolar;
    }

    public static implicit operator Peso(double cantidad)
    {
        return new Peso(cantidad);
    }

    public static explicit operator Dolar(Peso p)
    {
        return new Dolar(p.cantidad / Peso.getCotizacion());
    }

    public static explicit operator Euro(Peso p)
    {
        return (Euro)((Dolar)p);
    }

    public static bool operator ==(Peso p1, Peso p2)
    {
        return p1.cantidad == p2.cantidad;
    }

    public static bool operator !=(Peso p1, Peso p2)
    {
        return !(p1 == p2);
    }

    public static bool operator ==(Peso p, Dolar d)
    {
        return d == (Dolar)p;
    }

    public static bool operator !=(Peso p, Dolar d)
    {
        return !(p == d);
    }

    public static bool operator ==(Peso p, Euro e)
    {
        return p == (Peso)e;
    }

    public static bool operator !=(Peso p, Euro e)
    {
        return !(p == e);
    }

    public static Peso operator +(Peso p, Dolar d)
    {
        return new Peso(p.getCantidad() + ((Peso)d).getCantidad());
    }

    public static Peso operator +(Peso p, Euro e)
    {
        return new Peso(p.getCantidad() + ((Peso)e).getCantidad());
    }

    public static Peso operator -(Peso p, Dolar d)
    {
        return new Peso(p.getCantidad() - ((Peso)d).getCantidad());
    }

    public static Peso operator -(Peso p, Euro e)
    {
        return new Peso(p.getCantidad() - ((Peso)e).getCantidad());
    }
}