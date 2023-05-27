namespace Entidades;

public class VehiculoDeCarrera
{
    private short cantidadCombutible;
    private bool enCompetencia;
    private string escuderia;
    private short numero;
    private short vueltasRestantes;

    public VehiculoDeCarrera(string escuderia, short numero)
    {
        this.Escuderia = escuderia;
        this.Numero = numero;
    }

    public short Numero
    {
        get => numero;
        set => numero = value;
    }

    public bool EnCompetencia
    {
        get => enCompetencia;
        set => enCompetencia = value;
    }

    public string Escuderia
    {
        get => escuderia;
        set => escuderia = value;
    }

    public short VueltasRestantes
    {
        get => vueltasRestantes;
        set => vueltasRestantes = value;
    }

    public short CantidadCombutible
    {
        get => cantidadCombutible;
        set => cantidadCombutible = value;
    }
    
    public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
    {
        return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia);
    }

    public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
    {
        return !(a1 == a2);
    }

    public void montarEnPista(short cantidadVueltas)
    {
        this.VueltasRestantes = cantidadVueltas;
        this.EnCompetencia = true;
        this.CantidadCombutible = (short)new Random().Next(15, 100);
    }

    public string MostrarDatos()
    {
        return $"Escuderia: {this.Escuderia} \n" +
               $"Numero: {this.Numero} \n" + $"Vueltas restantes: {this.VueltasRestantes} \n";
    }
}