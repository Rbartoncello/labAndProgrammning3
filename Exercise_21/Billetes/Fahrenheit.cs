namespace Temperature
{
    public class Fahrenheit
    {
        private double temperature;

        public Fahrenheit(double temperature)
        {
            this.temperature = temperature;
        }


        public double getTemperature()
        {
            return this.temperature;
        }


        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius(f.toCelsius());
        }

        private double toCelsius()
        {
            return (this.temperature - 32) * 5/9;
        }

        private double toKelvin()
        {
            return (this.temperature + 459.67) * 5/9;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin(f.toKelvin());
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.temperature == f2.temperature;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f == (Fahrenheit)c;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f == (Fahrenheit)k;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.getTemperature() + ((Fahrenheit)c).getTemperature());
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.getTemperature() + ((Fahrenheit)k).getTemperature());
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.getTemperature() - ((Fahrenheit)c).getTemperature());
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.getTemperature() - ((Fahrenheit)k).getTemperature());
        }
    }
}