namespace Entidades;

public class UnaExcepcion : Exception
{
    public UnaExcepcion() : base()
    {
    }
    public UnaExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
    {
    }
}
