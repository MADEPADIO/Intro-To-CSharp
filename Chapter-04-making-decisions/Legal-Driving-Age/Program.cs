namespace Legal_Driving_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = ConvertInputToNumber("How old are you? ");
            Console.WriteLine(age >= 16 ? "You have reached the legal age to drive." : "You are not yet legally allowed to drive.");
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
