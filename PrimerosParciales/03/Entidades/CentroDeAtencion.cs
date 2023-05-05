using System.Text;

namespace Entidades;

public class CentroDeAtencion
{
    private int cantRacsPorSuper;
    private List<Empleado> empleados;
    private string nombre;


    public CentroDeAtencion(string nombre, int cantRacsPorSuper)
    {
        this.cantRacsPorSuper = cantRacsPorSuper;
        this.nombre = nombre;
        empleados = new List<Empleado>();
    }

    public List<Empleado> Empleados => empleados;

    public string Nombre => nombre;

    public static bool operator ==(CentroDeAtencion c, Empleado e)
    {
        return c.Empleados.Any(empleado => empleado == e);
    }

    public static bool operator !=(CentroDeAtencion c, Empleado e)
    {
        return !(c == e);
    }

    private bool ValidaCantidadDeRacs()
    {
        int cantRac = Empleados.Count(empleado => empleado.GetType().Name == "Rac");
        int cantSupervisor = Empleados.Count(
            empleado => 
                empleado.GetType().Name == "Supervisor"
            );

        return cantRacsPorSuper == cantRac/cantSupervisor;
    }
    public static bool operator +(CentroDeAtencion c, Empleado e)
    {
        if (c == e)
            return false;
        /*if(e.GetType().Name == "Supervisor" && !c.ValidaCantidadDeRacs())
            return false;*/

        c.Empleados.Add(e);
        return true;

    }

    public static string operator -(CentroDeAtencion c, Empleado e)
    {
        if (!c.Empleados.Contains(e))
            return "Empleado no encontrado";

        e.HoraEgreso = DateTime.Now.TimeOfDay;
        c.Empleados.Remove(e);
        return e.EmitirFactura();
    }

    public string ImprimirNomina()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var empleado in Empleados)
        {
            sb.AppendLine(empleado.ToString());
        }

        return sb.ToString();
    }
}