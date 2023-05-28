namespace Entidades;

public abstract class Equipo
{
    private string _nombre;
    private DateTime _fechaCreacion;

    protected Equipo(string nombre, DateTime fechaCreacion)
    {
        _nombre = nombre;
        _fechaCreacion = fechaCreacion;
    }

    public string Nombre => _nombre;

    public DateTime FechaCreacion => _fechaCreacion;

    public static bool operator ==(Equipo e1, Equipo e2)
    {
        return ((e1.Nombre == e2.Nombre) && (e1.FechaCreacion == e2.FechaCreacion));
    }

    public static bool operator !=(Equipo e1, Equipo e2)
    {
        return !(e1 == e2);
    }

    public string Ficha()
    {
        return $"{Nombre} fundado {FechaCreacion}";
    }

}