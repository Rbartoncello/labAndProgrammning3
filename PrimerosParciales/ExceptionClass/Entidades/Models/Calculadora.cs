namespace Entidades.Models;

public class Calculadora
{
    private int _numeroA;
    private int _numeroB;
    public Calculadora(string numeroA, string numeroB)
    {
        ConvierteNumero(numeroA, out _numeroA);
        ConvierteNumero(numeroB, out _numeroB);
    }

    public double Sumar()
    {
        return _numeroA + _numeroB;
    }

    public double Restar()
    {
        return _numeroA - _numeroB;
    }

    public double Multiplicar()
    {
        return _numeroA * _numeroB;
    }

    public double Dividir()
    {
        return _numeroA / _numeroB;
    }

    private void ConvierteNumero(string numero, out int resultado)
    {
        resultado = int.Parse(numero);
    }
}