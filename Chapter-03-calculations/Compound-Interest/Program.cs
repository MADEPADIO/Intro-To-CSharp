namespace Compound_Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateCompoundInterest();
        }

        public static decimal ConvertInputToDecimal(string input)
        {

            bool isInputNumber = false;
            string prompt;
            decimal output;
            do
            {
                Console.Write(input);
                prompt = Console.ReadLine();
                if (decimal.TryParse(prompt, out output) && output >= 0)
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

        public static double ConvertInputToDouble(string input)
        {
            bool isInputNumber = false;
            string prompt;
            double output;
            do
            {
                Console.Write(input);
                prompt = Console.ReadLine();
                if (double.TryParse(prompt, out output) && (double)output >= 0)
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

        public static int ConvertInputToInteger(string input)
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

        public static void CalculateCompoundInterest()
        {
            decimal principalAmount = ConvertInputToDecimal("How much are you investing? "),
                    Amount;
            double percent = ConvertInputToDouble("How many percent? "), 
                   rate = percent / 100;
            int time = ConvertInputToInteger("How many years are you investing? "),
                frequency = ConvertInputToInteger("How many times interest is applied per year? ");


            Amount = principalAmount * (decimal)Math.Pow((1 + (rate / frequency)), (frequency * time));


            Console.WriteLine($"After {time} years at {rate:P}, the investment will be worth {Math.Round(Amount, 2, MidpointRounding.AwayFromZero):C}\n");


            for (int year = 1; year <= time; year++)
            {
                Amount = principalAmount * (decimal)Math.Pow((1 + (rate / frequency)), (frequency * year));
                if (year == 1)
                {
                    Console.WriteLine($"After {year} year at {rate:P}, the investment will be worth {Math.Round(Amount, 2, MidpointRounding.AwayFromZero):C}");
                    continue;
                }

                Console.WriteLine($"After {year} years at {rate:P}, the investment will be worth {Math.Round(Amount, 2, MidpointRounding.AwayFromZero):C}");
            }
        }
    }
}
