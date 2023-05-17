using System.Text;

namespace Entidades
{
    public class Conversor
    {
        public static string ConvertirANumeroRomano(int numero)
        {
            return Conversor.ConvertirUnidades(numero);
        }

        private static string ConvertirUnidades(int numero)
        {
            StringBuilder sb = new StringBuilder();
            switch (numero)
                {
                    case > 0 and <= 3:
                        sb.Append('I', numero);
                        return sb.ToString();
                    case 4:
                        return "IV";
                    case > 4 and < 9:
                        sb.Append('V');
                        sb.Append('I', numero);
                        return sb.ToString();
                    case 9:
                        return "IX";
                }

            throw new Exception("Error");
        }
    }
}