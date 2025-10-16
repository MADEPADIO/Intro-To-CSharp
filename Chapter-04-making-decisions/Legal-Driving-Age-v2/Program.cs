namespace Legal_Driving_Age_v2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var zone = GetLegalDrivingAgeByZone();
			int age = ConvertInputToNumber("How old are you? ");
			Console.WriteLine(zone.ContainsKey(age) ? $"You have reached the legal to drive in the {zone[age]} zone." : "You are not yet legally allowed to drive.");
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

		private static IDictionary<int, string> GetLegalDrivingAgeByZone()
		{
			var Zones = new Dictionary<int, string>()
			{
				{25, "Purple" },
				{18 , "Green" },
				{17 , "Pink" },
				{16 , "Light Green" },
				{15 , "Yellow" }

			};
			return Zones;
		}
	}
}
