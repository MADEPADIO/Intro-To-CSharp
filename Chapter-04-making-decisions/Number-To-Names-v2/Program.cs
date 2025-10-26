namespace Number_To_Names_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = CheckNumberOfMonths();
            int numberOfMonth;
            do
            {
                numberOfMonth = ConvertInputToNumber("Please enter a number of the month you want displayed: ");
                if (months.ContainsKey(numberOfMonth))
                {
                    Console.WriteLine($"The month is {months[numberOfMonth]}");
                    break;
                }
                else
                {
                    Console.WriteLine("This month does not exist");
                    continue;
                }
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

        public static IDictionary<int, string> CheckNumberOfMonths()
        {
            var months = new Dictionary<int, string>
            {
                {1, "January" },
                {2, "February" },
                {3, "March" },
                {4, "April" },
                {5, "May" },
                {6, "June" },
                {7, "July" },
                {8, "August" },
                {9, "September" },
                {10, "October" },
                {11, "November" },
                {12, "December" }
            };
            return months;
        }

    }
}
