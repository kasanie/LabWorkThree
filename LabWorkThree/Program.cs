using System;

namespace LabWorkThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInput, secondInput;
            Console.WriteLine("Введите первое дробное число:");
            for (;;)
            {
                if (double.TryParse(Console.ReadLine(), out firstInput))
                {
                    Console.WriteLine("Введите второе дробное число:");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите первое дробное число:");
                    continue;
                }            
            }
            for (;;)
            {
                if (double.TryParse(Console.ReadLine(), out secondInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите второе дробное число:");
                    continue;
                }
            }
            Console.WriteLine("Первое число это " + firstInput + "\r\nВторое число это " + secondInput);
            Console.WriteLine("Вы хотите поменять значения чисел местами? (y - Да / n - Нет, выход из программы)");
            for (; ; )
            {
                if (Console.ReadLine() == "y")
                {
                    SwapNumbers(ref firstInput,ref secondInput);
                    Console.WriteLine("Первое число это " + firstInput + "\r\nВторое число это " + secondInput);
                    Console.WriteLine("Вы хотите поменять значения чисел местами?  (y - Да, n - Нет, выход из программы)");
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        static void SwapNumbers(ref double firstInput,ref double secondInput)
        {
                    var tempVariable = firstInput;
                    firstInput = secondInput;
                    secondInput = tempVariable;
        }
    }
}
