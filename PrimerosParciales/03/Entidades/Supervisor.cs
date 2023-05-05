namespace Entidades;

public class Supervisor: Empleado
{
    private static float valorHora;

    static Supervisor()
    {
        Supervisor.ValorHora = 1025.50F;
    }

    private Supervisor(string legajo) : base(legajo, "n/a", (new TimeSpan(09, 00, 00)))
    {
    }

    public Supervisor(string legajo, string nombre, TimeSpan horaIngreso) : base(legajo, nombre, horaIngreso)
    {
    }

    public static float ValorHora
    {
        get => valorHora;
        set
        {
            if (valorHora > 0)
                valorHora = value;
        }
    }

    public override string EmitirFactura()
    {
        return $"Factura de: {Nombre}\nImporte a facturar: {Facturar()}";
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} - {Legajo} - {Nombre}";
    }
    protected double Facturar()
    {
        return (base.Facturar() * ValorHora);
    }

    public static implicit operator Supervisor(string legajo)
    {
        return new Supervisor(legajo);
    }

}