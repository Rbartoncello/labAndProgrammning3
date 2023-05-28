namespace Entidades;

public class MotoCross: VehiculoDeCarrera
{
    private short cilindradas;

    public MotoCross(string escuderia, short numero) : base(escuderia, numero, Competencia.ETipoCompetencia.F1) { }

    public MotoCross(string escuderia, short numero, short cilindradas) : this(escuderia, numero)
    {
        this.cilindradas = cilindradas;
    }

    public static bool operator ==(MotoCross a1, MotoCross a2)
    {
        return ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.Cilindradas == a2.Cilindradas);
    }

    public static bool operator !=(MotoCross a1, MotoCross a2)
    {
        return !(a1 == a2);
    }

    public short Cilindradas
    {
        get => cilindradas;
        set => cilindradas = value;
    }
}