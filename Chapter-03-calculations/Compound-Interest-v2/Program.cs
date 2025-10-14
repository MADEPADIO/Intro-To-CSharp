namespace Compound_Interest_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatePrincipalAmount();
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

        public static void CalculatePrincipalAmount()
        {
            decimal Amount = ConvertInputToDecimal("How much interest do you want to recieve? "),
                    principalAmount;
            double percent = ConvertInputToDouble("How many percent? "),
                   rate = percent / 100;
            int time = ConvertInputToInteger("How many years are you investing? "),
                frequency = ConvertInputToInteger("How many times interest is applied per year? ");


            principalAmount = Amount / (decimal)Math.Pow((1 + (rate / frequency)), (frequency * time));


            Console.WriteLine($"For {time} years at {rate:P}, the principal to invest is {Math.Round(principalAmount, 2, MidpointRounding.AwayFromZero):C}\n");


            
        }
    }
}
