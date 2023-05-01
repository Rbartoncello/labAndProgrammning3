using System.Text;

namespace Entidades;

public class Competencia
{
    private int _cantidadCompetidores;
    private List<Equipo> _equipos;
    private string _nombre;


    private Competencia(string nombre)
    {
        this.Nombre = nombre;
    }

    public Competencia(string nombre, int cantidadCompetidores): this(nombre)
    {
        _equipos = new List<Equipo>();
        CantidadCompetidores  = cantidadCompetidores;
    }

    public List<Equipo> Equipos => _equipos;

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public int CantidadCompetidores
    {
        get => _cantidadCompetidores;
        set => _cantidadCompetidores = value;
    }

    public static implicit operator Competencia(string nombre)
    {
        return new Competencia(nombre);
    }

    public static bool operator ==(Competencia torneo, Equipo equipo)
    {
        return torneo.Equipos.Any(e => e == equipo);
    }

    public static bool operator !=(Competencia torneo, Equipo equipo)
    {
        return !(torneo == equipo);
    }

    public static Competencia operator +(Competencia torneo, Equipo equipo)
    {
        if (torneo != equipo && torneo.Equipos.Count() <= torneo.CantidadCompetidores)
        {
            torneo.Equipos.Add(equipo);
        }
        return torneo;
    }

    public static string MostrarTorneo(Competencia competencia)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Competencia: {competencia.Nombre}");
        sb.AppendLine($"Cantidad de competidores: {competencia.CantidadCompetidores}");

        foreach (Equipo equipo in competencia.Equipos)
            sb.AppendLine($"{equipo.ToString()}");
        
        return sb.ToString();
    }
}