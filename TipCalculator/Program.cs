namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bill = 0;
            double tipPercentage = 0;

            // Prompt for bill amount
            while (true)
            {
                Console.Write("Enter bill amount (non-zero number): ");
                string billInput = Console.ReadLine();
                if (double.TryParse(billInput, out bill) && bill != 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a non-zero numeric value.");
            }

            // Prompt for tip percentage
            while (true)
            {
                Console.Write("Enter tip percentage (non-zero number): ");
                string tipInput = Console.ReadLine();
                if (double.TryParse(tipInput, out tipPercentage) && tipPercentage != 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a non-zero numeric value.");
            }

            var tip = bill * (tipPercentage / 100);
            var total = bill + tip;
            Console.WriteLine("Tip amount: {0}", tip);
            Console.WriteLine("Total amount: {0}", total);
        }
    }
}
