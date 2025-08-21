namespace Saying_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + ". How are you doing?");
        }
    }
}

