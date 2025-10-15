namespace Password_Validation_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string storedPassword = "!1234a.";
            do
            {
                Console.Write("What is the password? ");
                string passWord = ReadPassword();
                if (passWord != storedPassword)
                {
                    Console.WriteLine("Wrong Password!");
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
            
            return password;

        
        }
    }
}
