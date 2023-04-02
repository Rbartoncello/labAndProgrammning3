namespace Conversion
{
    public class Conversion
    {
        public static string DecimalBinario(int number)
        {
            if (number == 1)
                return "1";
            else
                return DecimalBinario(number / 2) + (number % 2).ToString();
        }
        public static double BinarioDecimal(string binary)
        {
            int length = binary.Length;
            double number = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                length--;
                if (binary[i] == '1')
                    number += Math.Pow(2, length);
            }

            return number;
        }
    }
}