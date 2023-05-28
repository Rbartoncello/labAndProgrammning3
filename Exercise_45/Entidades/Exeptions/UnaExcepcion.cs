namespace Entidades.Exeptions;

public class UnaExcepcion : Exception
{
    public UnaExcepcion() : base("Ha ocurrido UnaExcepcion.")
    {
    }
    public UnaExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
    {
    }
}