using System.Text;
using Microsoft.VisualBasic;

namespace Entidades;

public class Curso
{
    private List<Persona> alumnos;
    private EMateria materia;
    private Persona _profesor;

    public Curso(Profesor profesor)
    {
        Profesor = profesor;
        materia = profesor.Materia;
        alumnos = new List<Persona>();
    }

    public List<Persona> Alumnos => alumnos;

    public Profesor Profesor
    {
        get => (Profesor)_profesor;
        set => _profesor = value;
    }

    public static bool operator ==(Curso curso, Alumno alumno)
    {
        return curso.Alumnos.Any(persona => persona == alumno);
    }

    public static bool operator !=(Curso curso, Alumno alumno)
    {
        return !(curso == alumno);
    }

    public string InscribirAlumno(Alumno alumno)
    {
        if(this == alumno)
            return $"Ya inscripto o no se pudo inscribir el alumno a la materia {materia}";

        alumnos.Add(alumno);

        return $"Se inscribío al alumno a la materia {materia}\n {alumno.Informacion}";
    }

    public static void EvaluarAlumnos(Curso curso)
    {
        foreach (Persona persona in curso.alumnos)
        {
            ((Alumno)persona).RendirExamen(curso.materia);
        }
    }

    public static string MostrarInformacionDelCurso(Curso curso)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Materia: {curso.materia}");
        sb.AppendLine($"Profesor: {curso.Profesor.Nombre}\n");
        if (curso.Alumnos is null) 
            return sb.ToString();
        
        foreach (Persona persona in curso.Alumnos)
        {
            sb.AppendLine(persona.Informacion);
        }

        return sb.ToString();
    }
}