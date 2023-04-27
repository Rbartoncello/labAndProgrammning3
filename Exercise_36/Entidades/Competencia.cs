namespace Entidades;

public class Competencia
{
    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<VehiculoDeCarrera> competidores;
    private ETipoCompetencia tipoCompetencia;

    public enum ETipoCompetencia {F1, MotoCross}

    private Competencia()
    {
        this.Competidores = new List<VehiculoDeCarrera>();
    }


    public Competencia(short cantidadCompetidores, short cantidadVueltas, ETipoCompetencia tipo) : this()
    {
        this.CantidadCompetidores = cantidadCompetidores;
        this.CantidadVueltas = cantidadVueltas;
        this.Tipo = tipo;
    }

    public short CantidadCompetidores
    {
        get => cantidadCompetidores;
        set => cantidadCompetidores = value;
    }

    public short CantidadVueltas
    {
        get => cantidadVueltas;
        set => cantidadVueltas = value;
    }

    public List<VehiculoDeCarrera> Competidores
    {
        get => competidores;
        set => competidores = value;
    }

    public ETipoCompetencia TipoCompetencia
    {
        get => tipoCompetencia;
        set => tipoCompetencia = value;
    }

    public VehiculoDeCarrera this[int index]
    {
        get => competidores[index];
        set => competidores[index] = value;
    }

    public string MostrarDatos()
    {
        string datos = $"La competencia tiene {this.CantidadCompetidores} competidores\n" +
                       $"Tiene {this.CantidadVueltas} vueltas\n" +
                       $"Los competidores son:\n";
        foreach (VehiculoDeCarrera competidor in this.Competidores)
            datos += competidor.MostrarDatos();
        
        return datos;
    }

    private void agregarCompetidor(VehiculoDeCarrera a)
    {
        a.montarEnPista(this.CantidadVueltas);
        this.Competidores.Add(a);
    }

    public static bool operator -(Competencia c, VehiculoDeCarrera a)
    {
        bool result = false;

        if (c == a)
        {
            c.Competidores.Remove(a);
            result = true;
        }

        return result;
    }

    public static bool operator +(Competencia c, VehiculoDeCarrera a)
    {
        bool result = false;

        if (c != a && c.Competidores.Count < c.CantidadCompetidores)
        {
            result = true;
            c.agregarCompetidor(a);
        }

        return result;
    }

    public static bool operator ==(Competencia c, VehiculoDeCarrera a)
    {
        bool estaAutoCompetencia = false;

        foreach (VehiculoDeCarrera cometidor in c.Competidores)
        {
            if (cometidor == a)
            {
                estaAutoCompetencia = true;
                break;
            }
        }

        return estaAutoCompetencia;
    }

    public static bool operator !=(Competencia c, VehiculoDeCarrera a)
    {
        return !(c == a);
    }
}