using System.Text;

namespace Entidades;

public class Moto: Vehiculo
{
    private ETipo _tipo;
    private static double _valorHora;

    public enum ETipo
    { 
        Cilomotor,
        Scooter,
        Sport
    }
    static Moto()
    {
        Moto.ValorHora = 100;
    }

    public Moto(string patente, DateTime horaIngreso, ETipo tipo) : base(horaIngreso, patente)
    {
        this._tipo = tipo;
    }

    public override string Desciption => _tipo.ToString();

    public override double CostoEstadia => CargoEstacionamiento();

    protected override double CargoEstacionamiento()
    {
        return base.CargoEstacionamiento() / 60 * Moto._valorHora;
    }

    protected override string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("****Moto*****");
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