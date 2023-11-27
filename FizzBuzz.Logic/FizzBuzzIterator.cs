namespace FizzBuzz.Logic
{
    public static class FizzBuzzIterator
    {
        public static void DoFizzBuzzRange(int start, int end, IFizzBuzzOutput output)
        {
            if (end > start)
            {
                for (int i = start; i <= end; i++)
                {
                    output.OutputFizzBuzzResult(i);
                }
            }
        }
    }
}
