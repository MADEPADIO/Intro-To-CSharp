namespace Simple_Math_v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            //int firstNumber, secondNumber;
            //ConvertInputToNumber(firstNum);
            //ConvertInputToNumber(secondNum);

            //
            //
            //bool isInputNumber = false;



            //do
            //{
            //    Console.Write("What is the first number? ");
            //    firstNum = Console.ReadLine();
            //    if (int.TryParse(firstNum, out firstNumber) && (firstNumber >= 0))
            //        isInputNumber = true;
            //    else
            //    {
            //        Console.WriteLine("Your input is supposed to be a positive number");
            //        isInputNumber = false;
            //    }


            //}
            //while (isInputNumber == false);



            //do
            //{
            //    Console.Write("What is the second number? ");
            //    secondNum = Console.ReadLine();
            //    if (int.TryParse(secondNum, out secondNumber) && (secondNumber >= 0))
            //        isInputNumber = true;
            //    else
            //    {
            //        Console.WriteLine("Your input is supposed to be a positive number");
            //        isInputNumber = false;
            //    }


            //}
            //while (isInputNumber == false);

            Add(ConvertInputToNumber(firstNum), ConvertInputToNumber(secondNum));
            Subtract (ConvertInputToNumber(firstNum), ConvertInputToNumber(secondNum));
            Multiply (ConvertInputToNumber(firstNum), ConvertInputToNumber(secondNum));
            Divide (ConvertInputToNumber(firstNum), ConvertInputToNumber(secondNum));


            Console.WriteLine($"{firstNum} + {secondNum} = {Add} \n {firstNum} - {secondNum} = {Subtract} \n {firstNum} * {secondNum} = {Multiply} \n {firstNum} / {secondNum} = {Divide}");
        }

        public static int ConvertInputToNumber (string input)
        {
            bool isInputNumber;
            int output;
            do
            {
                Console.Write("What is the number? ");
                input = Console.ReadLine();
                if (int.TryParse(input, out output) && output >=0)
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

        //public static int ConvertInputToNumber (int output)
        //{

        //    do
        //    {
        //        string input = AcceptInput(Console.ReadLine());

        //    }
        //    while (output < 0);
        //    return output;
        //}
        public static int Add (int num1 , int num2) 
        {
            return num1 + num2;
        }
        public static int Subtract (int num1, int num2) { return num1 - num2; }
        public static int Multiply (int num1, int num2) {return num1 * num2; }
        public static int Divide (int num1, int num2) {return num1 / num2;}
    }
}
