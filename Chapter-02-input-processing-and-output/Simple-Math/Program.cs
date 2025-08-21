using System;

namespace Simple_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the first number? ");
            string firstNum = Console.ReadLine();
            Console.Write("What is the second number? ");
            string secondNum = Console.ReadLine();

            int firstNumber =  int.Parse(firstNum);
            int secondNumber = int.Parse(secondNum);

            int add = firstNumber + secondNumber;
            int subtract = firstNumber - secondNumber;
            int multiply = firstNumber * secondNumber;
            int divide = firstNumber / secondNumber;


            Console.WriteLine($"{firstNum} + {secondNum} = {add} \n {firstNum} - {secondNum} = {subtract} \n {firstNum} * {secondNum} = {multiply} \n {firstNum} / {secondNum} = {divide}");
        }
    }
}
