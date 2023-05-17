namespace Entidades.Exceptions;

public class ArgumentoInvalido: Exception
{
    public ArgumentoInvalido(string? message): base(message)
    {
    }

    public ArgumentoInvalido(string? message, Exception innerException) : base(message, innerException)
    {
    }
}