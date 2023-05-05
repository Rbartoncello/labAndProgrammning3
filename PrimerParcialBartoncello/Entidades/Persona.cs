using System.Text;

namespace Entidades;

public abstract class Persona
{
    private string _apellido;
    protected int dni;
    private string _nombre;


    protected Persona(int dni)
    {
        this.dni = dni;
    }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public string Apellido
    {
        get => _apellido;
        set => _apellido = value;
    }

    public abstract string Informacion { get; }

    public static bool operator ==(Persona a, Persona b)
    {
        if(a is null || b is null)
            return false;
        return a.dni == b.dni;
    }

    public static bool operator !=(Persona a, Persona b)
    {
        return !(a== b);
    }

    public override bool Equals(object? obj)
    {
        Persona that = obj as Persona;
        return that == this;
    }

    public override int GetHashCode()
    {
        return dni.GetHashCode();
    }

    protected string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Dni: {dni}");
        sb.AppendLine($"Nombre: {Nombre}");
        sb.AppendLine($"Apellido: {Apellido}");

        return sb.ToString();
    }
}