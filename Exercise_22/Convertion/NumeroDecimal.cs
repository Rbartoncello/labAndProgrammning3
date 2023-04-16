namespace Conversion;

public class NumeroDecimal
{
    private double numero;

    private NumeroDecimal(double numero)
    {
        this.numero = numero;
    }

    public static implicit operator NumeroDecimal(double numero)
    {
        return new NumeroDecimal(numero);
    }

    public double getNumero()
    {
        return this.numero;
    }

    public static implicit operator NumeroDecimal(int numero)
    {
        return new NumeroDecimal(numero);
    }

    public static double operator +(NumeroDecimal d, NumeroBinario b)
    {
        return Conversion.BinarioDecimal(b.getNumero()) + d.getNumero();
    }

    public static double operator -(NumeroDecimal d, NumeroBinario b)
    {
        return d.getNumero() - Conversion.BinarioDecimal(b.getNumero());
    }

    public static bool operator ==(NumeroDecimal d, NumeroBinario b)
    {
        return b.getNumero() == Conversion.DecimalBinario((int)d.getNumero());
    }

    public static bool operator !=(NumeroDecimal d, NumeroBinario b)
    {
        return !(b == d);
    }
}