using System;

namespace the_task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstV, secV;
            Console.WriteLine("Введите первое число: ");
            firstV = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            secV = double.Parse(Console.ReadLine());

            double result = (firstV + secV) / 2;

            Console.WriteLine("Среднее арифметическое чисел = " + result);
        }
    }
}
