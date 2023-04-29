using System.Text;

namespace Entidades;

public class Estacionamiento
{
    private int _capacidadEstacionamiento;
    private static Estacionamiento _estacionamiento;
    private List<Vehiculo> _listadoVehiculos;
    private string _nombre;


    private Estacionamiento(int capacidad, string nombre)
    {
        this._capacidadEstacionamiento = capacidad;
        this._nombre = nombre;
        this._listadoVehiculos = new List<Vehiculo>();
    }

    public string Nombre => _nombre;

    public List<Vehiculo> ListadoVehiculos => _listadoVehiculos;

    private int CapacidadEstacionamiento => _capacidadEstacionamiento;

    public static Estacionamiento GetEstacionamiento(int capacidad, string nombre)
    {

        if (_estacionamiento is null)
        {
            _estacionamiento = new Estacionamiento(capacidad, nombre);
        }
        else
        {
            _estacionamiento._capacidadEstacionamiento = capacidad;
        }

        return _estacionamiento;
    }

    public string InformarSalida(Vehiculo vehiculo)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Nombre}");
        sb.AppendLine($"{vehiculo.ToString()}");
        sb.AppendLine($"{vehiculo.HoraEgreso}");
        sb.AppendLine($"{vehiculo.CostoEstadia}");

        return sb.ToString();
    }

    public static bool operator ==(Estacionamiento e, Vehiculo vehiculo)
    {
        return e.ListadoVehiculos.Contains(vehiculo);
    }

    public static bool operator !=(Estacionamiento e, Vehiculo vehiculo)
    {
        return !(e == vehiculo);
    }

    public static bool operator +(Estacionamiento e, Vehiculo vehiculo)
    {
        if (e == vehiculo || e.ListadoVehiculos.Count > e.CapacidadEstacionamiento) 
            return false;
        
        e.ListadoVehiculos.Add(vehiculo);
        return true;
    }

    public static bool operator -(Estacionamiento e, Vehiculo vehiculo)
    {
        if (e != vehiculo) 
            return false;
        
        e.ListadoVehiculos.Remove(vehiculo);
        vehiculo.HoraEgreso = DateTime.Now;
        return true;
    }
}