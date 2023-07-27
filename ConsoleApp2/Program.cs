using System;

namespace ConsoleApp2
{
    class Program
    {        
        static void Main(string[] args)
        {
            int plus = 4 + 6;
            int minus = 4 - 1;
            int multiply = 3 * 7;
            int divide = 13 / 3;
            int division = 17 % 8;

            Console.WriteLine("4 плюс 6 = " + plus);
            Console.WriteLine("4 уменшенное на 1 = " + minus);
            Console.WriteLine("3 умножить на 7 = " + multiply);
            Console.WriteLine("16 разделить на 8 = " + divide);
            Console.WriteLine("11 разделить на 5 = " + divide);
            Console.WriteLine("Целая часть от деления 13 на 3 = " + division);
            Console.WriteLine("Остаток от деления 17 на 8 = " + division);
        }
    }
}
