namespace Blood_Alcohol_Calculator
{
    internal class Program
    {
        const double menAlcoholRatio = 0.73,
                     womenAlcoholRatio = 0.66;
        static void Main(string[] args)
        {
            do
            {
                string gender = ConvertInputToString("Press 'F' for female or 'M' for male: ");
                if (string.Equals(gender, "F", StringComparison.OrdinalIgnoreCase))
                {
                    CalculateFemaleBAC();
                    break;
                }
                else if (string.Equals(gender, "M", StringComparison.OrdinalIgnoreCase))
                {
                    CalculateMaleBAC();
                    break;
                }
                else
                {
                    Console.WriteLine("Please input your gender.");
                    continue;
                }
            }
            while (true);
        }



        public static void CalculateMaleBAC()
        {
            double weight = ConvertInputToDouble("What is your weight? ");
            double alcoholVolume = ConvertInputToDouble("What volume of alcohol did you take? ");
            int hours = ConvertInputToNumber("How many hours since the last drink? ");
            int numberOfDrinks = ConvertInputToNumber("How many drinks did you take? ");
            var BAC = (alcoholVolume * 5.14 / weight * menAlcoholRatio) - 0.15 * hours;
            Console.WriteLine(BAC >= 0.88 ? $"Your BAC is {Math.Round(BAC, 2)}. It is illegal to drive." : $"Your BAC is {Math.Round(BAC, 2)}. You can drive.");
        }

        public static void CalculateFemaleBAC()
        {
            double weight = ConvertInputToDouble("What is your weight? ");
            double alcoholVolume = ConvertInputToDouble("What volume of alcohol did you take? ");
            int hours = ConvertInputToNumber("How many hours since the last drink? ");
            int numberOfDrinks = ConvertInputToNumber("How many drinks did you take? ");
            var BAC = (alcoholVolume * 5.14 / weight * womenAlcoholRatio) - 0.15 * hours;
            Console.WriteLine(BAC >= 0.88 ? $"Your BAC is {Math.Round(BAC, 2)}. It is illegal to drive." : $"Your BAC is {Math.Round(BAC, 2)}. You can drive.");
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

        public static string ConvertInputToString(string input)
        {
            string prompt;
            do
            {
                Console.Write(input);
                prompt = Console.ReadLine()?.Trim() ?? "";
                if (!string.IsNullOrWhiteSpace(prompt) && prompt.All(char.IsLetter))
                {
                    return prompt;
                }
                Console.WriteLine("Your input is supposed to be a word with letters only.");
            }
            while (true);
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