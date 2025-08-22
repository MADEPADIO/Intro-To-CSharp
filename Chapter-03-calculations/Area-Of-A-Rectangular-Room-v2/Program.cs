namespace Area_Of_A_Rectangular_Room_v2
{
    internal class Program
    {
        const double feet_Meter_Conversion_Constant = 0.09290304;
        static void Main(string[] args)
        {
            Measurement();
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

       
        public static void Feet()
        {
            double length = 0, width = 0;
            double area = Area(length, width);
            Console.WriteLine("The area is: \n {0} square feet \n {1} square metres", area, area * feet_Meter_Conversion_Constant);
        }

        
        public static void Metre()
        {
            double length = 0, width = 0;
            double area = Area(length, width);
            Console.WriteLine("The area is: \n {0} square metres \n {1} square feet", area, area / feet_Meter_Conversion_Constant);
        }

        public static void Measurement()
        {
            string measurement;
            do
            {
                Console.WriteLine("Type your measurement in Foot, 'ft', or Metre, 'm'");
                measurement = Console.ReadLine();
                if (measurement == "ft") Feet();
                else if (measurement == "m") Metre();
                else Console.WriteLine("Please select either foot or metre");
            } while (measurement != "ft" && measurement != "m");

        }
    }
}
