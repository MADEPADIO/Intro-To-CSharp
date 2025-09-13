namespace Pizza_Party_v3
{
    internal class Program
    {
        #region Constants for pizza sizes
        const int smallSizePizza = 6;
        const int mediumSizePizza = 8;
        const int largeSizePizza = 10;
        const int extraLargeSizePizza = 12;
        #endregion
        static void Main(string[] args)
        {
            string pizzaType;
            int people = ConvertInputToNumber("How many people? ");
            int pizza = ConvertInputToNumber("How many pizza(s) do you have? ");
            do
            {
                Console.Write("What size of pizza do you want: (please input the size of your choice by typing the associated letter in the bracket) \n 1. Small(s) \n 2. Medium(m) \n 3. Large(l) \n 4. Extra Large(xl) \n");
                pizzaType = Console.ReadLine();
                int slicesPerPerson;
                int leftoverSlices;
                int totalSlices;
                switch (pizzaType)
                {
                    case "s":
                        totalSlices = pizza * smallSizePizza;
                        slicesPerPerson = totalSlices / people;
                        leftoverSlices = totalSlices % people;
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
                        break;
                    case "m":
                        totalSlices = pizza * mediumSizePizza;
                        slicesPerPerson = totalSlices / people;
                        leftoverSlices = totalSlices % people;
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
                        break;
                    case "l":
                        totalSlices = pizza * largeSizePizza;
                        slicesPerPerson = totalSlices / people;
                        leftoverSlices = totalSlices % people;
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
                        break;
                    case "xl":
                        totalSlices = pizza * extraLargeSizePizza;
                        slicesPerPerson = totalSlices / people;
                        leftoverSlices = totalSlices % people;
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
                        break;
                    default:
                        Console.WriteLine("you inputted something else");
                        break;
                }
               
            }
            while (pizzaType != "s" && pizzaType != "m" && pizzaType != "l" && pizzaType != "xl");

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
