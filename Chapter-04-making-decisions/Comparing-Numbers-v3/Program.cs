namespace Comparing_Numbers_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string input;
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter an number (or press Enter to finish): ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                    break;
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Number already exists. Try another one.");
                    if (numbers.Count != 0)
                    {
                        numbers.Add(number);

                    }
                    else
                    {
                        Console.WriteLine("No numbers were entered.");
                        return;
                    }

                }
                

                int largest = 0;
                foreach (var num in numbers)
                {
                    if (largest < num)
                    {
                        largest = num;
                    }
                }
                Console.WriteLine($"The largest number is {largest}");

            }
            

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
