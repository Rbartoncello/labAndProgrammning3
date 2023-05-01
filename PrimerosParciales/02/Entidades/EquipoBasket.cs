namespace Entidades;

public class EquipoBasket: Equipo
{
    private ELiga _liga;

    public enum ELiga
    {
        NBA,
        Euroleague,
        ACB
    }

    public EquipoBasket(string nombre) : base(nombre)
    {
        _liga = ELiga.NBA;
    }
    public EquipoBasket(string nombre, ELiga liga) : base(nombre)
    {
        _liga = liga;
    }

    public override int GetDificultad()
    {
        Random rnd = new Random();

        switch (_liga)
        {
            case ELiga.NBA:
                return rnd.Next(8, 10);
            case ELiga.Euroleague: 
                return rnd.Next(5, 10);
            default: 
                return rnd.Next(1, 7);
        }
    }

    protected string MostrarDatos()
    {
        return "Basquet-" + base.MostrarDatos();
    }

    public override string ToString()
    {
        return MostrarDatos();
    }
}