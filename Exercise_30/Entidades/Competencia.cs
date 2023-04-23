namespace Entidades;

public class Competencia
{
    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<AutoF1> competidores;

    private Competencia()
    {
        this.competidores = new List<AutoF1>();
    }


    public Competencia(short cantidadCompetidores, short cantidadVueltas): this()
    {
        this.cantidadCompetidores = cantidadCompetidores;
        this.cantidadVueltas = cantidadVueltas;
    }

    public string MostrarDatos()
    {
        string datos = $"La competencia tiene {this.cantidadCompetidores} competidores\n" +
                       $"Tiene {this.cantidadVueltas} vueltas\n" +
                       $"Los competidores son:\n";
        foreach (AutoF1 competidor in this.competidores)
            datos += competidor.MostrarDatos();
        
        return datos;
    }

    private void eliminarCompetidor(AutoF1 c)
    {
        foreach (AutoF1 cometidor in this.competidores)
        {
            if (cometidor == c)
            {
                this.competidores.Remove(cometidor);
                break;
            }
        }
    }

    private void agregarCompetidor(AutoF1 a)
    {
        a.montarEnPista(this.cantidadVueltas);
        this.competidores.Add(a);
    }

    public static bool operator -(Competencia c, AutoF1 a)
    {
        bool result = false;

        if (c == a)
        {
            c.eliminarCompetidor(a);
            result = true;
        }

        return result;
    }

    public static bool operator +(Competencia c, AutoF1 a)
    {
        bool result = false;

        if (c != a && c.competidores.Count < c.cantidadCompetidores)
        {
            result = true;
            c.agregarCompetidor(a);
        }

        return result;
    }

    public static bool operator ==(Competencia c, AutoF1 a)
    {
        bool estaAutoCompetencia = false;

        foreach (AutoF1 cometidor in c.competidores)
        {
            if (cometidor == a)
            {
                estaAutoCompetencia = true;
                break;
            }
        }

        return estaAutoCompetencia;
    }

    public static bool operator !=(Competencia c, AutoF1 a)
    {
        return !(c == a);
    }
}