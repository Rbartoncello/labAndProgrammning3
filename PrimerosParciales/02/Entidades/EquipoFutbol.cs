namespace Entidades;

public class EquipoFutbol: Equipo
{
    private bool _jugadoresEstrellas;

    public EquipoFutbol(string nombre) : base(nombre)
    {
        _jugadoresEstrellas = false;
    }
    public EquipoFutbol(string nombre, bool jugadoresEstrellas): base(nombre)
    {
        _jugadoresEstrellas = jugadoresEstrellas;
    }

    public override int GetDificultad()
    {
        int rnd = new Random().Next(7, 10);

        if (_jugadoresEstrellas)
            return rnd*2;
        return rnd;
    }

    protected string MostrarDatos()
    {
        return "Futbol-" + base.MostrarDatos();
    }

    public override string ToString()
    {
        return MostrarDatos();
    }
}