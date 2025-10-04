namespace Currency_Conversion_v3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fromCurrency, toCurrency;
			do
			{
				fromCurrency = ConvertInputToString("What currency are you converting from? (e.g., USD): ").ToUpper();
				toCurrency = ConvertInputToString("What currency are you converting to? (e.g., EUR): ").ToUpper();
				if (fromCurrency == toCurrency)
				{
					Console.WriteLine("You cannot convert a currency to itself.");
				}
			}
			while (fromCurrency == toCurrency);
			
			if (fromCurrency == "USD" || toCurrency == "USD")
			{
				DirectExchange(fromCurrency, toCurrency);
			}
			else
			{
				CrossExchange(fromCurrency, toCurrency);
			}

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

		public static string ConvertInputToString(string input)
		{
			string prompt;
			do
			{
				Console.Write(input);
				prompt = Console.ReadLine()?.Trim() ?? "";
				if (!string.IsNullOrWhiteSpace(prompt) && prompt.All(char.IsLetter) && CheckCurrencyTicker(prompt.ToUpper()))
				{
					return prompt;
				}
				Console.WriteLine("Your input is supposed to be a 3-letter currency code (e.g., USD, EUR).");
			}
			while (true);
		}

		public static bool CheckCurrencyTicker(string currencyTicker)
		{
			// Check for null, length, and that all characters are letters
			return !string.IsNullOrWhiteSpace(currencyTicker)
				&& currencyTicker.Length == 3
				&& currencyTicker.All(char.IsLetter);
		}

		public static void DirectExchange(string fromCurrency, string toCurrency)
		{
			decimal amountToConvert = ConvertInputToNumber($"How many {fromCurrency} are you exchanging? "),
					conversionRate = ConvertInputToNumber($"How many {toCurrency} is 1 {fromCurrency}? "),
					convertedAmount;
			convertedAmount = amountToConvert * conversionRate;
			Console.WriteLine($"{amountToConvert} {fromCurrency} at a conversion rate of {conversionRate} is {Math.Round(convertedAmount, 2, MidpointRounding.AwayFromZero)} {toCurrency}.");
		}

		public static void CrossExchange(string fromCurrency, string toCurrency)
		{
			string baseCurrency = "USD";
			decimal amountToConvert = ConvertInputToNumber($"How many {fromCurrency} are you exchanging? "),
					conversionRate = ConvertInputToNumber($"How many {baseCurrency} is 1 {fromCurrency}? "),
					secondConversionRate = ConvertInputToNumber($"How many {baseCurrency} is 1 {toCurrency}? "),
					convertedAmount;
			convertedAmount = (amountToConvert * conversionRate) / secondConversionRate;
			Console.WriteLine($"{amountToConvert} {fromCurrency} at a conversion rate of {conversionRate}{baseCurrency} is {Math.Round(convertedAmount, 2, MidpointRounding.AwayFromZero)} {toCurrency}.");
		}
	}
}
