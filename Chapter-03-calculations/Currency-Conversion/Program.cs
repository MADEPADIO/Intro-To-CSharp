namespace Currency_Conversion
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Console.Write("What currency are you converting from? (e.g., USD): ");
			string fromCurrency = Console.ReadLine().ToUpper();
			Console.Write("What currency are you converting to? (e.g., EUR): ");
			string toCurrency = Console.ReadLine().ToUpper();
			decimal amountToConvert = ConvertInputToNumber($"How many {fromCurrency} are you exchanging? "),
					conversionRate = ConvertInputToNumber($"What is the conversion rate from {fromCurrency} to {toCurrency}? "),
					convertedAmount;
			convertedAmount = amountToConvert * conversionRate;
			Console.WriteLine($"{amountToConvert} {fromCurrency} at a conversion rate of {conversionRate} is {convertedAmount} {toCurrency}.");



        }

		public static decimal ConvertInputToNumber(string input)
		{

			bool isInputNumber = false;
			string prompt;
			decimal output;
			do
			{
				Console.Write(input);
				prompt = Console.ReadLine();
				if (decimal.TryParse(prompt, out output) && output >= 0)
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
