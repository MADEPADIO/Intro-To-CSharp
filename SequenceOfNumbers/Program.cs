namespace SequenceOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 2;
            for (int i = 1; i < 100; i++)
            {
                if (firstNumber % 2 == 0)
                {
                    Console.WriteLine(firstNumber);
                } else if (firstNumber % 2 != 0)
                {
                    Console.WriteLine(0 - firstNumber);
                }

                firstNumber ++;
            }
        }
    }
}
