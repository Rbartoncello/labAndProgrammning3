namespace AtencionAlCliente;

public class PuestoAtencion
{
    private static int _numeroActual;
    private EPuesto _puesto;

    public enum EPuesto
    {
        Caja1,
        Caja2,
    }

    public static int NumeroActual
    {
        get
        {
            _numeroActual += 1;
            return _numeroActual;
        }
    }

    private PuestoAtencion()
    {
        PuestoAtencion._numeroActual = 0;
    }

    public PuestoAtencion(EPuesto puesto): this()
    {
        this._puesto = puesto;
    }

    public bool Atender(Cliente cli)
    {
        Thread.Sleep(5000);
        return true;
    }

}