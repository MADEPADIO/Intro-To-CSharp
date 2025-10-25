namespace Temperature_Converter_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string temperature = ConvertInputToString("Press C to convert from Fahrenheit to Celsius or press F to convert from Celsius to Fahrenheit: ");
                if (string.Equals(temperature, "C", StringComparison.OrdinalIgnoreCase))
                {
                    FahrenheitToCelsius();
                    break;
                }
                else if (string.Equals(temperature, "F", StringComparison.OrdinalIgnoreCase))
                {
                    CelsiusToFahrenheit();
                    break;
                }
                else
                {
                    Console.WriteLine("Please input the right temperature.");
                    continue;
                }
            }
            while (true);
        }

        public static void FahrenheitToCelsius()
        {
            var fahrenheit = ConvertInputToDouble("Enter the temperature in Fahrenheit: ");
            var celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"The temperature in celsius is {celsius}");
        }

        public static void CelsiusToFahrenheit()
        {
            var celsius = ConvertInputToDouble("Enter the temperature in Celsius: ");
            var fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"The temperature in fahrenheit is {fahrenheit}");
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
    }
}
