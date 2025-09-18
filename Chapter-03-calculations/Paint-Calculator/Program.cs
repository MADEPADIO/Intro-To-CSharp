namespace Paint_Calculator
{
    internal class Program
    {
        const int squaredFeet = 350;
        const int gallonOfPaint = 1;
        static void Main(string[] args)
        {
            double length = 0, width = 0, area = Area(length, width), gallons = area / squaredFeet;

            if ((area > squaredFeet) || ((int)gallons < gallons))
            {
                int gallonsOfPaint = (int)gallons++;
                if (gallons % (int)gallons != 0)
                    Console.WriteLine($"You will need to purchase {(int)gallons} gallons of paint to cover {area} squared feet.");
                else
                    Console.WriteLine($"You will need to purchase {gallonsOfPaint} gallons of paint to cover {area} squared feet.");

            }
            else 
                Console.WriteLine($"You will need to purchase {gallonOfPaint} gallon of paint to cover {area} squared feet.");

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


        public static double Area(double length, double width)
        {
            length = ConvertInputToNumber("Input a length: ");
            width = ConvertInputToNumber("Input a width: ");
            Console.WriteLine("You inputted the dimensions of {0} length and {1} width", length, width);
            return length * width;
        }

    }
}
