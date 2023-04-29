using System.Text;

namespace Entidades;

public class Automovil: Vehiculo
{
    private string _marca;
    private static double _valorHora;

    static Automovil()
    {
        Automovil.ValorHora = 120;
    }

    public Automovil(string patente, DateTime horaIngreso, string marca): base(horaIngreso, patente)
    {
        this._marca = marca;
    }

    public override string Desciption => _marca;

    public override double CostoEstadia => CargoEstacionamiento();

    protected override double CargoEstacionamiento()
    {
        return base.CargoEstacionamiento()/60 * Automovil._valorHora;
    }

    protected override string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("****AUTOMOVIL*****");
        sb.AppendLine($"{base.MostrarDatos()}");

        return sb.ToString();
    }

    public override string ToString()
    {
        return MostrarDatos();
    }

    public static double ValorHora
    {
        set
        {
            if (value > 0) 
                _valorHora = value;
        }
    }
}