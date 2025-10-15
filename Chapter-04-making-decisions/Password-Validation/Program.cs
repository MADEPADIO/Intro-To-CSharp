namespace Password_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "!1234a.";
            do
            {
                string passWord = ConvertInputToString("What is the password? ");
                if (passWord != password)
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
    }
}
