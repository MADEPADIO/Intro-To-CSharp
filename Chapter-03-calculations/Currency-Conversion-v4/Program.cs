namespace Currency_Conversion_v4
{
	internal class Program
	{

        static void Main(string[] args)
		{
			var exchangeRate = GetRates();
            string fromCurrency, toCurrency, fromCountry, toCountry;
			decimal amountToConvert, convertedAmount;
            string FindCountryKey(string input) =>
				exchangeRate.Keys.FirstOrDefault(country => country.Equals(input, StringComparison.OrdinalIgnoreCase)) ?? "";
            do
            {
				fromCountry = ConvertInputToString("Enter the country you are converting from: ");
				fromCountry = FindCountryKey(fromCountry);
                if (!exchangeRate.ContainsKey(fromCountry))
				{
					Console.WriteLine("Sorry, we don't have data for that country. Please try again.");
					continue;
				}
				fromCurrency = exchangeRate[fromCountry].ticker;

				toCountry = ConvertInputToString("Enter the country you are converting to: ");
				toCountry = FindCountryKey(toCountry);
                if (!exchangeRate.ContainsKey(toCountry))
				{
					Console.WriteLine("Sorry, we don't have data for that country. Please try again.");
					continue;
				}
				toCurrency = exchangeRate[toCountry].ticker;
				if (fromCurrency == toCurrency)
				{
					Console.WriteLine("You cannot convert a currency to itself. Please choose different countries.");
					continue;
				}

				decimal fromRate = exchangeRate[fromCountry].rate;
				decimal toRate = exchangeRate[toCountry].rate;

				amountToConvert = ConvertInputToNumber($"How many {fromCurrency} are you exchanging? ");
				if (fromCurrency == "USD" || toCurrency == "USD")
				{
					decimal conversionRate = fromCurrency == "USD" ? toRate : 1 / fromRate;
					convertedAmount = amountToConvert * conversionRate;
					Console.WriteLine($"{amountToConvert} {fromCurrency} at a conversion rate of {conversionRate} is {Math.Round(convertedAmount, 2, MidpointRounding.AwayFromZero)} {toCurrency}.");
				}
				else
				{
					convertedAmount = (amountToConvert * fromRate) / toRate;
					Console.WriteLine($"{amountToConvert} {fromCurrency} at a conversion rate of {fromRate}/{toRate} is {Math.Round(convertedAmount, 2, MidpointRounding.AwayFromZero)} {toCurrency}.");
                }
                    break;
			}
			while (true);

			






			
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
				if (!string.IsNullOrWhiteSpace(prompt))
				{
					return prompt;
				}
				Console.WriteLine("Your input should contain no special character.");
			}
			while (true);
		}

		

        private static IDictionary<string, (string ticker, decimal rate)> GetRates()
        {
            return new Dictionary<string, (string ticker, decimal rate)>
            {
                { "United States", ("USD", 1.00m) },
                { "Eurozone", ("EUR", 0.85m) },
                { "United Kingdom", ("GBP", 0.75m) },
                { "Japan", ("JPY", 110.00m) },
                { "Canada", ("CAD", 1.25m) },
                { "Australia", ("AUD", 1.35m) },
                { "Switzerland", ("CHF", 0.92m) },
                { "China", ("CNY", 6.45m) },
                { "India", ("INR", 74.00m) },
                { "Mexico", ("MXN", 20.00m) },
                { "Brazil", ("BRL", 5.20m) },
                { "South Africa", ("ZAR", 14.50m) },
                { "Russia", ("RUB", 73.00m) },
                { "South Korea", ("KRW", 1150.00m) },
                { "Turkey", ("TRY", 8.50m) },
                { "New Zealand", ("NZD", 1.40m) },
                { "Singapore", ("SGD", 1.35m) },
                { "Hong Kong", ("HKD", 7.80m) },
                { "Saudi Arabia", ("SAR", 3.75m) },
                { "United Arab Emirates", ("AED", 3.67m) },
                { "Argentina", ("ARS", 98.00m) },
                { "Chile", ("CLP", 750.00m) },
                { "Colombia", ("COP", 3800.00m) },
                { "Peru", ("PEN", 4.00m) },
                { "Philippines", ("PHP", 50.00m) },
                { "Thailand", ("THB", 32.00m) },
                { "Vietnam", ("VND", 23000.00m) },
                { "Egypt", ("EGP", 15.70m) },
                { "Nigeria", ("NGN", 1500.00m) },
                { "Kenya", ("KES", 110.00m) },
                { "Ghana", ("GHS", 5.80m) },
                { "Morocco", ("MAD", 9.00m) },
                { "Indonesia", ("IDR", 14000.00m) },

            };
        }
    }
}
