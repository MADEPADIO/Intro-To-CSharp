namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            var age = Convert.ToInt32(ageInput) + 10;
            Console.WriteLine("Your age after 10 years is {0}", age);
        }
    }
}
