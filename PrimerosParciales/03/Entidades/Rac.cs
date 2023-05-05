namespace Entidades;

public class Rac: Empleado
{
    private EGrupo _grupo = EGrupo.CALL_IN;
    private static double _valorHora;

    public enum EGrupo
    {
        CALL_IN,
        CALL_OUT,
        RRSS
    }

    static Rac()
    {
        Rac.ValorHora = 875.90F;
    }
    public Rac(string legajo, string nombre, TimeSpan horaIngreso) : base(legajo, nombre, horaIngreso)
    {
    }

    public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo grupo) : base(legajo, nombre, horaIngreso)
    {
        _grupo = grupo;
    }

    public EGrupo Grupo => _grupo;

    public static double ValorHora
    {
        get => _valorHora;
        set
        {
            if (value > 0)
                _valorHora = value;
        }
    }

    public override string EmitirFactura()
    {
        return $"Factura de: {Nombre}\nImporte a facturar: {Facturar()}";
    }

    private double CalcularBono()
    {
        double bono = 0;

        switch (Grupo)
        {
            case EGrupo.CALL_IN:
                bono = 0;
                break;
            case EGrupo.CALL_OUT:
                bono = 0.1;
                break;
            case EGrupo.RRSS:
                bono = 0.2;
                break;
        }

        return bono;
    }

    protected double Facturar()
    {
        return (base.Facturar() * ValorHora) * (1 + CalcularBono());
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} - {Grupo} - {Legajo} - {Nombre}";
    }
}