namespace Temperature;

public class Celsius
{
    private double temperature;


    public Celsius(double temperature)
    {
        this.temperature = temperature;
    }



    public double getTemperature()
    {
        return this.temperature;
    }



    public static implicit operator Celsius(double t)
    {
        return new Celsius(t);
    }

    public static explicit operator Fahrenheit(Celsius c)
    {
        return new Fahrenheit( c.toFahrenhait());
    }

    private double toFahrenhait()
    {
        return this.temperature * 9/5 + 32;
    }

    public static explicit operator Kelvin(Celsius c)
    {
        return (Kelvin)((Fahrenheit)c);
    }

  
    public static bool operator ==(Celsius c1, Celsius c2)
    {
        return c1.temperature == c2.temperature;
    }

    public static bool operator !=(Celsius e1, Celsius e2)
    {
        return !(e1 == e2);
    }

    public static bool operator ==(Celsius c, Fahrenheit f)
    {
        return f == (Fahrenheit)c;
    }

    public static bool operator !=(Celsius c, Fahrenheit f)
    {
        return !(c == f);
    }

    public static bool operator ==(Celsius c, Kelvin k)
    {
        return c == (Celsius)k;
    }

    public static bool operator !=(Celsius c, Kelvin k)
    {
        return !(c == k);
    }

    public static Celsius operator +(Celsius c, Fahrenheit f)
    {
        return new Celsius(c.getTemperature() + ((Celsius)f).getTemperature());
    }

    public static Celsius operator +(Celsius c, Kelvin k)
    {
        return new Celsius(c.getTemperature() + ((Celsius)k).getTemperature());
    }

    public static Celsius operator -(Celsius c, Fahrenheit f)
    {
        return new Celsius(c.getTemperature() - ((Celsius)f).getTemperature());
    }

    public static Celsius operator -(Celsius c, Kelvin k)
    {
        return new Celsius(c.getTemperature() - ((Celsius)k).getTemperature());
    }
}