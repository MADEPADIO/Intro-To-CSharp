namespace Printing_Quotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the quote? ");
            string quote = Console.ReadLine();
            Console.Write("Who said it? ");
            string author = Console.ReadLine();
            Console.WriteLine($"{author} says, \"{quote}\"");
        }
    }
}
