namespace Mad_Lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter an adverb: ");
            string adverb = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjective = Console.ReadLine();
            Console.WriteLine($"I have tried to {verb} {noun} but I don't");
        }
    }
}
