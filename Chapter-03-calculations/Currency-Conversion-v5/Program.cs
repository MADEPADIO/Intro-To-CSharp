using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Currency_Conversion_v5
{
    // Model for API response
    public class ExchangeRateApiResponse
    {
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Fetch live exchange rates from the API
            var exchangeRate = FetchRatesFromApiAsync().GetAwaiter().GetResult();
            string fromCurrency, toCurrency;
            decimal amountToConvert, convertedAmount;

            do
            {
                fromCurrency = ConvertInputToString("Enter the currency code you are converting from (e.g., USD): ").ToUpper();
                if (!exchangeRate.ContainsKey(fromCurrency))
                {
                    Console.WriteLine("Sorry, we don't have data for that currency. Please try again.");
                    continue;
                }

                toCurrency = ConvertInputToString("Enter the currency code you are converting to (e.g., EUR): ").ToUpper();
                if (!exchangeRate.ContainsKey(toCurrency))
                {
                    Console.WriteLine("Sorry, we don't have data for that currency. Please try again.");
                    continue;
                }

                if (fromCurrency == toCurrency)
                {
                    Console.WriteLine("You cannot convert a currency to itself. Please choose different currencies.");
                    continue;
                }

                decimal fromRate = exchangeRate[fromCurrency].rate;
                decimal toRate = exchangeRate[toCurrency].rate;

                amountToConvert = ConvertInputToNumber($"How many {fromCurrency} are you exchanging? ");

                // Convert from source to USD, then from USD to target
                convertedAmount = (amountToConvert / fromRate) * toRate;
                Console.WriteLine($"{amountToConvert} {fromCurrency} is {Math.Round(convertedAmount, 2, MidpointRounding.AwayFromZero)} {toCurrency}.");

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

        // Fetches live rates from the API and returns a dictionary of (ticker, rate)
        private static async Task<IDictionary<string, (string ticker, decimal rate)>> FetchRatesFromApiAsync()
        {
            using HttpClient client = new HttpClient();
            string apiUrl = "https://api.exchangerate-api.com/v4/latest/USD";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var ratesData = JsonSerializer.Deserialize<ExchangeRateApiResponse>(responseBody);
            var ratesDict = new Dictionary<string, (string ticker, decimal rate)>();
            if (ratesData != null && ratesData.Rates != null)
            {
                foreach (var rate in ratesData.Rates)
                {
                    ratesDict[rate.Key.ToUpper()] = (rate.Key.ToUpper(), rate.Value);
                }
            }
            return ratesDict;
        }
    }
}
