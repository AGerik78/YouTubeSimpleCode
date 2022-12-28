using System;

namespace Homework
{
    // 1. Напишите простой калькулятор с помощью switch.

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.Clear();
                double firstValue, secondValue;
                string action;

                System.Console.WriteLine("Введите число 1");
                firstValue = double.Parse(System.Console.ReadLine()!);

                System.Console.WriteLine("Введите число 2");
                secondValue = double.Parse(System.Console.ReadLine()!);

                System.Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = System.Console.ReadLine();

                switch (action)
                {
                    case "+":
                        System.Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        System.Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        System.Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            System.Console.WriteLine(0); // если одна строка кода то можно фигурные скобки {} убрать.
                        }
                        else
                        {
                            System.Console.WriteLine(firstValue / secondValue);
                        }
                        break;
                    default:
                        System.Console.WriteLine("Ошибка! Неизвестное действие!");
                        break;
                }
                System.Console.ReadLine();
            }
        }
    }
}