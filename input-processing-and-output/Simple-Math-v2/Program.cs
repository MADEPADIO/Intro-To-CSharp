namespace Simple_Math_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum, secondNum;
            int firstNumber, secondNumber;
            bool isInputNumber = false;
            do
            {
                Console.Write("What is the first number? ");
                firstNum = Console.ReadLine();
                if (int.TryParse(firstNum, out firstNumber))
                    isInputNumber = true;
                else
                {
                    Console.WriteLine("Your input is supposed to be a number");
                    isInputNumber = false;
                }
                    

            }
            while (isInputNumber == false);



            do
            {
                Console.Write("What is the second number? ");
                secondNum = Console.ReadLine();
                if (int.TryParse(secondNum, out secondNumber))
                    isInputNumber = true;
                else
                {
                    Console.WriteLine("Your input is supposed to be a number");
                    isInputNumber = false;
                }


            }
            while (isInputNumber == false);


            

            int add = firstNumber + secondNumber;
            int subtract = firstNumber - secondNumber;
            int multiply = firstNumber * secondNumber;
            int divide = firstNumber / secondNumber;


            Console.WriteLine($"{firstNum} + {secondNum} = {add} \n {firstNum} - {secondNum} = {subtract} \n {firstNum} * {secondNum} = {multiply} \n {firstNum} / {secondNum} = {divide}");
        }
    }
}
