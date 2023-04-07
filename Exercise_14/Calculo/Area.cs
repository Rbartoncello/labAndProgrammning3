namespace Calculo
{
    public class Area
    {
        public static double CalcularCuadrado(double side)
        {
            return side * side;
        }

        public static double CalcularTriangulo(double foot, double height)
        {
            return foot * height;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }
}