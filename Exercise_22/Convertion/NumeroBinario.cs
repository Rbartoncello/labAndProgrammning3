namespace Conversion;

public class NumeroBinario
{
    private string numero;

    private NumeroBinario(string numero)
    {
        this.numero = numero;
    }

    public string getNumero()
    {
        return this.numero;
    }

    public static implicit operator NumeroBinario(string numero)
    {
        return new NumeroBinario(numero);
    }

    public static string operator +(NumeroBinario b, NumeroDecimal d)
    {
        return Conversion.DecimalBinario((int)(d.getNumero() + Conversion.BinarioDecimal(b.getNumero())));
    }
    public static string operator -(NumeroBinario b, NumeroDecimal d)
    {
        return Conversion.DecimalBinario((int)(d.getNumero() - Conversion.BinarioDecimal(b.getNumero())));
    }

    public static bool operator ==(NumeroBinario b, NumeroDecimal d)
    {
        return b.getNumero() == Conversion.DecimalBinario((int)d.getNumero());
    }

    public static bool operator !=(NumeroBinario b, NumeroDecimal d)
    {
        return !(b == d);
    }
}