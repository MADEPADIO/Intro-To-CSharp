namespace Comparing_Numbers_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, largest = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = ConvertInputToNumber("Enter a number: ");
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Number already exists.");
                    }
                }
                while (numbers.Contains(number));

                numbers.Add(number);

            }
            foreach (var num in numbers)
            {
                if (largest < num)
                {
                    largest = num;
                }
            }
            Console.WriteLine($"The largest number is {largest}");
        }

        public static int ConvertInputToNumber(string input)
        {

            bool isInputNumber = false;
            string prompt;
            int output;
            do
            {
                Console.Write(input);
                prompt = Console.ReadLine();
                if (int.TryParse(prompt, out output) && output >= 0)
                {
                    isInputNumber = true;
                    break;

                }

                else
                {
                    Console.WriteLine("Your input is supposed to be a positive number");
                    isInputNumber = false;
                }


            }
            while (isInputNumber == false);
            return output;
        }
    }
}
