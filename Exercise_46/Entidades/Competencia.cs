using Entidades.Exeptions;

namespace Entidades;

public class Competencia<T> where T: VehiculoDeCarrera
{
    private short _cantidadCompetidores;
    private short _cantidadVueltas;
    private List<T> _competidores;
    private ETipoCompetencia _tipoCompetencia;

    public enum ETipoCompetencia {F1, MotoCross}

    private Competencia()
    {
        this.Competidores = new List<T>();
    }


    public Competencia(short cantidadCompetidores, short cantidadVueltas, ETipoCompetencia tipo) : this()
    {
        this.CantidadCompetidores = cantidadCompetidores;
        this.CantidadVueltas = cantidadVueltas;
        this._tipoCompetencia = tipo;
    }

    public short CantidadCompetidores
    {
        get => _cantidadCompetidores;
        set => _cantidadCompetidores = value;
    }

    public short CantidadVueltas
    {
        get => _cantidadVueltas;
        set => _cantidadVueltas = value;
    }

    public List<T> Competidores
    {
        get => _competidores;
        set => _competidores = value;
    }

    public ETipoCompetencia TipoCompetencia
    {
        get => _tipoCompetencia;
        set => _tipoCompetencia = value;
    }

    public T this[int index]
    {
        get => _competidores[index];
        set => _competidores[index] = value;
    }

    public string MostrarDatos()
    {
        string datos = $"La competencia tiene {this.CantidadCompetidores} competidores\n" +
                       $"Tiene {this.CantidadVueltas} vueltas\n" +
                       $"Los competidores son:\n";
        foreach (var competidor in this.Competidores)
            datos += competidor.MostrarDatos();
        
        return datos;
    }

    private void AgregarCompetidor(T a)
    {
        a.montarEnPista(this.CantidadVueltas);
        this.Competidores.Add(a);
    }

    public static bool operator -(Competencia<T> c, T a)
    {
        if (c != a) 
            return false;

        c.Competidores.Remove(a);

        return true;
    }

    public static bool operator +(Competencia<T> c, T a)
    {
        try
        {
            if (c != a && c.Competidores.Count < c.CantidadCompetidores)
            {
                c.AgregarCompetidor(a);
                return true;
            }
        }
        catch (Exception e)
        {
            throw new CompetenciaNoDisponibleException("Competencia incorrecta", nameof(Competencia<T>), "+", e);
        }
        return false;
    }

    public static bool operator ==(Competencia<T> c, T a)
    {
        return c.Competidores.Any(cometidor => (cometidor == a));
    }

    public static bool operator !=(Competencia<T> c, T a)
    {
        return !(c == a);
    }
}