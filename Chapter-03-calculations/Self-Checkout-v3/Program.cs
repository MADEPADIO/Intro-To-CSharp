namespace Self_Checkout_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int item = 1, quantity;
            decimal pricesOfItems, subtotal = 0, total, tax;
            string continueInput;

            do
            {
                Console.Write($"What is the price of item {item} (or press Enter to finish): ");
                continueInput = Console.ReadLine();
                
                if (string.IsNullOrEmpty(continueInput))
                    break;

                if (decimal.TryParse(continueInput, out pricesOfItems) && pricesOfItems >= 0)
                {
                    quantity = ConvertInputToNumber("Quantity: ");
                    subtotal += (quantity * pricesOfItems);
                    item++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive price");
                }
            }
            while (true);

            tax = (5.5m / 100) * subtotal;
            total = tax + subtotal;

            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Tax: ${tax:F2}");
            Console.WriteLine($"Total: ${total:F2}");
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
