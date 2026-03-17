namespace Anagram_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter two words and I will tell you if they are anagrams:");
            string firstWord = ConvertInputToString("Enter the first word: ");
            string secondWord = ConvertInputToString("Enter the second word: ");
            Console.WriteLine(firstWord.Length == secondWord.Length);
            char[] firstWordArray = firstWord.ToCharArray();
            char[] secondWordArray = secondWord.ToCharArray();


        }

        public static string ConvertInputToString(string input)
        {
            string prompt;
            do
            {
                Console.Write(input);
                prompt = Console.ReadLine()?.Trim() ?? "";
                if (!string.IsNullOrWhiteSpace(prompt) && prompt.All(char.IsLetter))
                {
                    return prompt;
                }
                Console.WriteLine("Your input is supposed to be a word with letters only.");
            }
            while (true);
        }

        //public static bool IsAnagram(string input)
        //{

        //}
    }
}
