namespace Entidades.Exeptions;

public class MiExcepcion : Exception
{
    public MiExcepcion() : base("Ha ocurrido UnaExcepcion.")
    {
    }
    public MiExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
    {
    }
}