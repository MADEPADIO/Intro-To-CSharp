namespace Self_Checkout_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = ConvertInputToNumber("How many items did you purchase: "), item = 1, quantity;
            decimal pricesOfItems, subtotal = 0, total, tax;


            while (numberOfItems > 0)
            {
                pricesOfItems = ConvertInputToNumber($"What is the price of item {item}: ");
                quantity = ConvertInputToNumber("Quantity: ");

                subtotal += (quantity * pricesOfItems);
                item++;
                numberOfItems--;
            }
            tax = (5.5m / 100) * subtotal;
            total = tax + subtotal;

            Console.WriteLine($"Subtotal: {subtotal} \n Tax: {tax} \n Total: {total}");

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
