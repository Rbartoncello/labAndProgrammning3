namespace Temperature;

public class Kelvin
{
    private double temperature;

    public Kelvin(double temperature)
    {
        this.temperature = temperature;
    }


    public double getTemperature()
    {
        return this.temperature;
    }

    public static implicit operator Kelvin(double cantidad)
    {
        return new Kelvin(cantidad);
    }

    public static explicit operator Fahrenheit(Kelvin k)
    {
        return new Fahrenheit(k.toFahrenhait());
    }

    private double toFahrenhait()
    {
        return this.temperature * 9 / 5 - 459.67;
    }

    public static explicit operator Celsius(Kelvin k)
    {
        return (Celsius)((Fahrenheit)k);
    }

    public static bool operator ==(Kelvin k1, Kelvin k2)
    {
        return k1.temperature == k2.temperature;
    }

    public static bool operator !=(Kelvin k1, Kelvin k2)
    {
        return !(k1 == k2);
    }

    public static bool operator ==(Kelvin k, Fahrenheit f)
    {
        return f == (Fahrenheit)k;
    }

    public static bool operator !=(Kelvin k, Fahrenheit f)
    {
        return !(k == f);
    }

    public static bool operator ==(Kelvin k, Celsius c)
    {
        return k == (Kelvin)c;
    }

    public static bool operator !=(Kelvin k, Celsius c)
    {
        return !(k == c);
    }

    public static Kelvin operator +(Kelvin k, Fahrenheit f)
    {
        return new Kelvin(k.getTemperature() + ((Kelvin)f).getTemperature());
    }

    public static Kelvin operator +(Kelvin k, Celsius c)
    {
        return new Kelvin(k.getTemperature() + ((Kelvin)c).getTemperature());
    }

    public static Kelvin operator -(Kelvin k, Fahrenheit f)
    {
        return new Kelvin(k.getTemperature() - ((Kelvin)f).getTemperature());
    }

    public static Kelvin operator -(Kelvin k, Celsius c)
    {
        return new Kelvin(k.getTemperature() - ((Kelvin)c).getTemperature());
    }
}