using System;
using System.Text;

namespace Entidades.Exeptions;

public class CompetenciaNoDisponibleException: Exception
{
    private string nombreClase;
    private string nombreMetodo;

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo): base(mensaje)
    {
        this.nombreClase = clase;
        this.nombreMetodo = metodo;
    }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException): base(mensaje, innerException)
    {
        this.nombreClase = clase;
        this.nombreMetodo = metodo;
    }

    public string NombreClase => nombreClase;

    public string NombreMetodo => nombreMetodo;

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder($"Excepción en el método {this.NombreMetodo} de la clase {this.NombreClase}");
        if (InnerException != null)
        {
            sb.Append(InnerException.Message);
            Exception e = InnerException;
            while (e is not null)
            {
                e = e.InnerException;
                sb.Append(InnerException.Message);
            }
        }

        return sb.ToString();
    }
}