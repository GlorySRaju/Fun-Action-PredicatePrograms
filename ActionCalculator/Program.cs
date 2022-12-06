using System;

namespace ActionCalculator
{
    class Program
    {
        
            static void Calculator(Action<int, int> cal)
            {
             cal(10, 2);
            }

            static void Main(string[] args)
            {
                Action<int, int> callAdd = new Action<int, int>(Add);

                Action<int, int> callSubtract = new Action<int, int>(Subtract);

                Action<int, int> callProduct = new Action<int, int>(Product);

                Action<int, int> callDivide = new Action<int, int>(Divide);

                Calculator(callAdd+=callSubtract+=callProduct+=callDivide);


        }

            static void Add(int firstNumber, int secondNumber)
            {
                Console.WriteLine($"Sum is { firstNumber + secondNumber}");
            }

            static void Subtract(int firstNumber, int secondNumber)
            {
            Console.WriteLine($"Difference is { firstNumber - secondNumber}");
            }

            static void Product(int firstNumber, int secondNumber)
            {
            Console.WriteLine($"Product is { firstNumber * secondNumber}");
            }

             static void Divide(int firstNumber, int secondNumber)
            {
            Console.WriteLine($"Divide is { firstNumber / secondNumber}");
            }
    }
}
