namespace Password_Validation_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = ListOfUsernamesAndPasswords();
            string username;
            do
            {
                username = ConvertInputToString("Enter Username: ");
                Console.Write("What is the password? ");
                string password = ReadPassword();
                if (!(users.ContainsKey(username) && users[username] == password))
                {
                    Console.WriteLine("Wrong Username or Password!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Welcome Master!");
                    break;
                }

            }
            while (true);

        }

        public static string ConvertInputToString(string input)
        {
            bool isInputString = false;
            string prompt;
            string output = string.Empty;
            do
            {
                Console.Write(input);
                prompt = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(prompt))
                {
                    isInputString = true;
                    output = prompt;
                    break;
                }


            }
            while (isInputString == false);
            return output;
        }

        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(intercept: true);
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    password += key.KeyChar;
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return password;


        }

        private static IDictionary<string, string> ListOfUsernamesAndPasswords()
        {
            return new Dictionary<string, string>
            {
                {"Padio", "1234" },
                {"Vantyse", "5678" },

            };
        }

    }
}
