namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = ConvertInputToDouble("Enter you weight in kilograms: ");
            double height = ConvertInputToDouble("Enter your height in centimetres: ") / 100;
            var BMI = weight / (Math.Pow(height, 2));
            Console.WriteLine(BMI < 18.5 ? $"Your BMI is {BMI}. You are underweight and should see your doctor." : BMI >= 25 ? $"Your BMI is {BMI}. You are overweight and should see your doctor." : $"Your BMI is {BMI}. You are within the ideal weight range.");
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
