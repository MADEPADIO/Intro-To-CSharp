namespace Retirement_Calculator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentAge, retirementAge, retirementYearsLeft;

            currentAge = ConvertInputToNumber("What is your current age? ");
            retirementAge = ConvertInputToNumber("What age would you like to retire? ");
            retirementYearsLeft = retirementAge - currentAge;
            if (retirementAge <= currentAge)
                Console.WriteLine("You can retire already.");
            else
                Console.WriteLine($"The year is {DateTime.Now.Year}. You can retire in {DateTime.Now.Year + retirementYearsLeft}.");

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
