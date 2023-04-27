namespace AtencionAlCliente;

public class Negocio
{
    private PuestoAtencion _caja;
    private Queue<Cliente> _clientes;
    private string _nombre;


    private Negocio()
    {
        _clientes = new Queue<Cliente>();
        _caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
    }
    public Negocio(string nombre): this()
    {
        this._nombre = nombre;
    }

    public Queue<Cliente> Clientes => _clientes;

    public Cliente Cliente
    {
        get => Clientes.Peek();
        set => AgregarCliente(value);
    }

    public PuestoAtencion Caja
    {
        get => _caja;
    }

    private void AgregarCliente(Cliente cliente)
    {
        if(!this.Clientes.Contains(cliente))
            this._clientes.Enqueue(cliente);
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
        return n.Clientes.Any(cliente => cliente == c);
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
        return !(n == c);
    }

    public static bool operator +(Negocio n, Cliente c)
    {
        if(n == c) 
            return false;
        
        n.Clientes.Enqueue(c);

        return true;
    }

    public static bool operator ~(Negocio n)
    {
        if (!n.Caja.Atender(n.Cliente)) 
            return false;

        n.Clientes.Dequeue();
        return true;
    }

    public int ClientesPendientes => Clientes.Count;
}