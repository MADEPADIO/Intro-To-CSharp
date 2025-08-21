namespace Counting_The_Number_Of_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the input string? ");
            string input = Console.ReadLine();
            int inputLength = input.Length;
            Console.WriteLine($"{input} has {inputLength} characters.");
        }
    }
}
