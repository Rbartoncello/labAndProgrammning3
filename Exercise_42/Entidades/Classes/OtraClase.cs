using Entidades.Exeptions;

namespace Entidades.Classes;

public class OtraClase
{
    public void MetodoInstancia()
        {
            try
            {
                new MiClase(200);
            }
            catch (Exception ex)
            {
                throw new MiExcepcion("Este es la excepcion desde otraClase", ex);
            }
        }
}