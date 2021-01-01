using System;

namespace LabWorkThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstVariable, secondVariable, tempVariable;
            Console.WriteLine("Введите первое дробное число:");
            for (; ; )
            {
                if (double.TryParse(Console.ReadLine(), out firstVariable))
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
            for (; ; )
            {
                if (double.TryParse(Console.ReadLine(), out secondVariable))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите второе дробное число:");
                    continue;
                }
            }
            Console.WriteLine("Первое число это " + firstVariable + "\r\nВторое число это " + secondVariable);
            Console.WriteLine("Вы хотите поменять значения чисел местами? (y - Да / n - Нет, выход из программы)");
            for (; ; )
            {
                if (Console.ReadLine() == "y")
                {
                    tempVariable = firstVariable;
                    firstVariable = secondVariable;
                    secondVariable = tempVariable;
                    Console.WriteLine("Первое число это " + firstVariable + "\r\nВторое число это " + secondVariable);
                    Console.WriteLine("Вы хотите поменять значения чисел местами?  (y - Да, n - Нет, выход из программы)");
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
