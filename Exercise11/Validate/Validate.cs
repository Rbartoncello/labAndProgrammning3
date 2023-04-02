namespace Validate
{
    public static class Validate
    {
        public static bool ValidateRange(int value, int max, int min)
        {
            return (value > min && value < max);
        }
    }
}