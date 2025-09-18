namespace Paint_Calculator_v2
{
    internal class Program
    {
        const int squaredFeet = 350;
        const int gallonOfPaint = 1;
        const double pi = 3.142;
        static void Main(string[] args)
        {
            double radius = 0, area = AreaOfACircle(radius), gallons = area / squaredFeet;

            if ((area > squaredFeet) || ((int)gallons < gallons))
            {
                int gallonsOfPaint = (int)gallons++;
                if (gallons % (int)gallons != 0)
                    Console.WriteLine($"You will need to purchase {(int)gallons} gallons of paint to cover {area} squared feet.");
                else
                    Console.WriteLine($"You will need to purchase {gallonsOfPaint} gallon(s) of paint to cover {area} squared feet.");

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


        public static double AreaOfACircle(double radius)
        {
            radius = ConvertInputToNumber("What is the radius? ");
            Console.WriteLine("You inputted the radius of {0} ft", radius);
            return pi * (radius * radius);
        }

    }
}
