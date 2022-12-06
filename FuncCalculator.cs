using System;

namespace FuncCalculator
{
    class Program
    {

        static void  Calculator(Func<int,int,int> cal)
        {
            Console.WriteLine(cal(10, 2));
        }

        static void Main(string[] args)
        {
           Func<int,int,int> callAdd = new Func<int,int,int>(Add);

           Func<int, int, int> callSubtract= new Func<int, int, int>(Subtract);

           Func<int, int, int> callProduct = new Func<int, int, int>(Product);

           Func<int, int, int> callDivide = new Func<int, int, int>(Divide);

           Calculator(callAdd );

           Calculator(callSubtract);

           Calculator(callProduct);

           Calculator(callDivide);
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Subtract(int firstNumber, int secondNumber)
        {
           return firstNumber - secondNumber;
        }

        static int Product(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }


    }
}
