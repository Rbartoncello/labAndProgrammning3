using System.Text;

namespace Entidades;

public class Profesor: Persona
{
    private string _email;
    private EMateria _materiaAsignada;

    public Profesor(int dni) : base(dni)
    {
    }

    public Profesor(int dni, string email) : this(dni)
    {
        this._email = email;
    }
    public Profesor(int dni, string email, EMateria materiaAsignada) : this(dni, email)
    {
        this._materiaAsignada = materiaAsignada;
    }

    public EMateria Materia
    {
        get => _materiaAsignada;
        set => _materiaAsignada = value;
    }

    protected string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder(base.MostrarDatos());

        sb.AppendLine($"Email {_email}");
        sb.AppendLine($"Materia Asignada {_materiaAsignada}");

        return sb.ToString();
    }

    public override string Informacion => $"Profesor - {MostrarDatos()}";

    public override string ToString()
    {
        return $"Profesor - {_materiaAsignada}";
    }

    public bool Evaluar(Alumno alumno)
    {
        return alumno.RendirExamen(_materiaAsignada);
    }
}