namespace Pizza_Party_v2
{
    internal class Program
    {
        const int smallSizePizza = 6;
        const int mediumSizePizza = 8;
        const int largeSizePizza = 10;
        const int extraLargeSizePizza = 12;
        static void Main(string[] args)
        {
            string pizzaType;
            int people = ConvertInputToNumber("How many people? ");
            int pizza = ConvertInputToNumber("How many pizza(s) do you have? ");
            int totalSlices = 0;
            int slicesPerPerson = totalSlices / people;
            do
            {
                Console.Write("What size of pizza do you want: (please input the size of your choice by typing the associated letter in the bracket) \n 1. Small(s) \n 2. Medium(m) \n 3. Large(l) \n 4. Extra Large(xl) \n");
                pizzaType = Console.ReadLine();
                switch (pizzaType)
                {
                    case "s":
                        totalSlices = pizza * smallSizePizza;
                        if (slicesPerPerson < people)
                        {
                            Console.WriteLine("You don't have enough pizza");
                        }
                        else
                        {
                            Console.WriteLine("You have enough pizza");
                        }
                        break;
                    case "m":
                        totalSlices = pizza * mediumSizePizza;
                        if (slicesPerPerson <= 2)
                        {
                            Console.WriteLine("You don't have enough pizza");
                        }
                        else
                        {
                            Console.WriteLine("You have enough pizza");
                        }
                        break;
                    case "l":
                        totalSlices = pizza * largeSizePizza;
                        if (slicesPerPerson <= 2)
                        {
                            Console.WriteLine("You don't have enough pizza");
                        }
                        else
                        {
                            Console.WriteLine("You have enough pizza");
                        }
                        break;
                    case "xl":
                        totalSlices = pizza * extraLargeSizePizza;
                        if (slicesPerPerson <= 2)
                        {
                            Console.WriteLine("You don't have enough pizzas");
                        }
                        else
                        {
                            Console.WriteLine("You have enough pizza");
                        }
                        break;
                    default:
                        Console.WriteLine("you inputted something else");
                        break;
                }
                /*if (pizzaType == "s" || pizzaType == "m" || pizzaType == "l" || pizzaType == "xl")
                {
                    Console.WriteLine(pizzaType);
                    //break;
                }
                else
                    Console.WriteLine("you inputted something else");*/
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



        public static void NotEnoughPizza()
        {

        }

    }
}
