using System;

namespace Homework
{
    // 1. Напишите простой калькулятор с помощью if_else.

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    System.Console.WriteLine("Введите число 1");
                    firstValue = double.Parse(System.Console.ReadLine()!);

                    System.Console.WriteLine("Введите число 2");
                    secondValue = double.Parse(System.Console.ReadLine()!);
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Ошибка ввода числа!");
                    System.Console.ReadLine();
                    continue;
                }

                System.Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = System.Console.ReadLine();

                if (action == "+")
                {
                    System.Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "-")
                {
                    System.Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "*")
                {
                    System.Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                    {
                        System.Console.WriteLine(0); // если одна строка кода то можно фигурные скобки {} убрать.
                    }
                    else
                    {
                        System.Console.WriteLine(firstValue / secondValue);
                    }
                }
                else
                {
                    System.Console.WriteLine("Ошибка! Неизвестное действие!");
                }

                System.Console.ReadLine();

            }

        }
    }
}
// как выйти из программы?
