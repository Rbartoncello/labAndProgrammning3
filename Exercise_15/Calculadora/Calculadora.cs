namespace Calculadora
{
    public class Calculadora
    {
        public static double Calcular(double numberOne, double numberTwo, char operation)
        {
            double resultado = 0;

            switch (operation)
            {
                case '+':
                    resultado = numberOne + numberTwo;
                    break;
                case '-':
                    resultado = numberOne - numberTwo;
                    break;
                case '*':
                    resultado = numberOne * numberTwo;
                    break;
                case '/':
                    if(Validar(numberTwo))
                        resultado = numberOne / numberTwo;
                    break;
            }
            return resultado;
        }

        private static bool Validar(double number)
        {
            return number != 0;
        }
    }
}