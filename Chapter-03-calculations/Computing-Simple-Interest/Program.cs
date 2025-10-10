namespace Computing_Simple_Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal principalAmount = ConvertInputToDecimal("How much are you investing? "),
                    percent = ConvertInputToDecimal("How many percent? "),
                    rate = percent / 100,
                    Amount;
            int time = ConvertInputToInteger("How many years are you investing? ");

            Amount = principalAmount * (1 + (rate * time));
            Console.WriteLine($"After {time} years at {percent}%, the investment will be worth ${Math.Round(Amount, 2, MidpointRounding.AwayFromZero)}");
                    
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
    }
}
