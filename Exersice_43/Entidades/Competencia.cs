using Entidades.Exeptions;

namespace Entidades;

public class Competencia
{
    private short _cantidadCompetidores;
    private short _cantidadVueltas;
    private List<VehiculoDeCarrera> _competidores;
    private ETipoCompetencia _tipoCompetencia;

    public enum ETipoCompetencia {F1, MotoCross}

    private Competencia()
    {
        this.Competidores = new List<VehiculoDeCarrera>();
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

    public List<VehiculoDeCarrera> Competidores
    {
        get => _competidores;
        set => _competidores = value;
    }

    public ETipoCompetencia TipoCompetencia
    {
        get => _tipoCompetencia;
        set => _tipoCompetencia = value;
    }

    public VehiculoDeCarrera this[int index]
    {
        get => _competidores[index];
        set => _competidores[index] = value;
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

    private void AgregarCompetidor(VehiculoDeCarrera a)
    {
        a.montarEnPista(this.CantidadVueltas);
        this.Competidores.Add(a);
    }

    public static bool operator -(Competencia c, VehiculoDeCarrera a)
    {
        if (c != a) 
            return false;

        c.Competidores.Remove(a);

        return true;
    }

    public static bool operator +(Competencia c, VehiculoDeCarrera a)
    {
        if (c == a || c.Competidores.Count >= c.CantidadCompetidores)
        {
            throw new CompetenciaNoDisponibleException("Competencia incorrecta", nameof(Competencia).ToString(), "+");
        }

        c.AgregarCompetidor(a);


        return true;
    }

    public static bool operator ==(Competencia c, VehiculoDeCarrera a)
    {
        bool estaAutoCompetencia = c.Competidores.Any(cometidor => !(cometidor != a));


        if (estaAutoCompetencia)
        {

            throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", nameof(Competencia).ToString(),"==");
        }

        return estaAutoCompetencia;
    }

    public static bool operator !=(Competencia c, VehiculoDeCarrera a)
    {
        return !(c == a);
    }
}