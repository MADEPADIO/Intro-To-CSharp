namespace Simple_Math_v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            firstNumber = ConvertInputToNumber("Input a first number: ");
            secondNumber = ConvertInputToNumber("Input a second number: ");

            Console.WriteLine($"{firstNumber} + {secondNumber} = " + Add(firstNumber, secondNumber) + $"\n {firstNumber} - {secondNumber} = " + Subtract(firstNumber, secondNumber) + $"\n {firstNumber} * {secondNumber} = " + Multiply(firstNumber, secondNumber) + $"\n {firstNumber} / {secondNumber} = " + Divide(firstNumber, secondNumber));
        }

        public static int ConvertInputToNumber (string input)
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
        public static int Add (int num1, int num2) { return num1 + num2; }
        public static int Subtract (int num1, int num2) { return num1 - num2; }
        public static int Multiply (int num1, int num2) {return num1 * num2; }
        public static int Divide (int num1, int num2) {return num1 / num2;}
    }
}
