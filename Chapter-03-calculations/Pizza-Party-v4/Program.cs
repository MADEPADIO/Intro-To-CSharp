namespace Pizza_Party_v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = ConvertInputToNumber("How many people? ");
            int pizza = ConvertInputToNumber("How many pizza(s) do you have? ");
            int slicesPerPizza;
            do
            {
                slicesPerPizza = ConvertInputToNumber("How many slices per pizza? ");
                if (slicesPerPizza % 2 != 0)
                {
                    Console.WriteLine("Please enter an even number");
                }
            }
            while (slicesPerPizza % 2 != 0);
            int totalSlices = slicesPerPizza * pizza;
            int slicesPerPerson = totalSlices / people;
            int leftoverSlices = totalSlices % people;
            if (totalSlices < people)
            {
                Console.WriteLine("You don't have enough pizza.");
                return;
            }
            if (slicesPerPerson < 2)
            {
                Console.WriteLine($"You have {people} people with {pizza} pizza, and each person can have {slicesPerPerson} slice of pizza.");
            }
            else
            {
                Console.WriteLine($"You have {people} people with {pizza} pizza, and each person can have {slicesPerPerson} slices of pizza.");
            }
            if (leftoverSlices < 2)
            {
                Console.WriteLine($"There is {leftoverSlices} leftover slice.");
            }
            else
            {
                Console.WriteLine($"There are {leftoverSlices} leftover slices.");
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
                    //break;

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
