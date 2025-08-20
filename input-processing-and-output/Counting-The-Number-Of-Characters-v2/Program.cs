namespace Counting_The_Number_Of_Characters_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is the input string? ");
            string input = Console.ReadLine();
            int inputLength = input.Length;
            if (inputLength == 0)
            
                Console.WriteLine("You have to input something.");
            
            else 
                Console.WriteLine($"{input} has {inputLength} characters.");
        }
    }
}
