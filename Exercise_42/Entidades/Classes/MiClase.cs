using Entidades.Exeptions;

namespace Entidades.Classes;

public class MiClase
{
    public MiClase()
    {
        try
        {
            MetodoEstatico();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public MiClase(int id)
    {
        try
        {
            new MiClase();
        }
        catch (Exception ex)
        {
            throw new UnaExcepcion("Este es el constructor con paramatros", ex);
        }
    }
    public static void MetodoEstatico()
    {
        throw new DivideByZeroException("Este es el metodo estatico de mi clase DIV");
    }
}