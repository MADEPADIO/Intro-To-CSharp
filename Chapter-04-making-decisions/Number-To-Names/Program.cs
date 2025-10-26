namespace Number_To_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonth = ConvertInputToNumber("Please enter a number of the month you want displayed: ");
            switch (numberOfMonth)
            {
                case 1:
                    Console.WriteLine("The month is January");
                    break;
                case 2:
                    Console.WriteLine("The month is February");
                    break;
                case 3:
                    Console.WriteLine("The month is March");
                    break;
                case 4:
                    Console.WriteLine("The month is April");
                    break;
                case 5:
                    Console.WriteLine("The month is May");
                    break;
                case 6:
                    Console.WriteLine("The month is June");
                    break;
                case 7:
                    Console.WriteLine("The month is July");
                    break;
                case 8:
                    Console.WriteLine("The month is August");
                    break;
                case 9:
                    Console.WriteLine("The month is September");
                    break;
                case 10:
                    Console.WriteLine("The month is October");
                    break;
                case 11:
                    Console.WriteLine("The month is November");
                    break;
                case 12:
                    Console.WriteLine("The month is December");
                    break;
                default:
                    Console.WriteLine("This month does not exist");
                    break;
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
