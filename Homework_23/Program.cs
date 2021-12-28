using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework_23
{
    class Program
    {
        static void Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Факториал {n} равен {factorial}");
        }
        static void FactorialX (int n)
        {
            int factorialx = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialx *= i;
                Console.Write(factorialx + " ");
            }
        }
        static async Task FactorialAsync (int n)
        {
            Console.WriteLine("Считаю факториал");
            await Task.Run(() => Factorial(n));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, факториал которого хотите посчитать");
            int x = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(x);
            FactorialX(x);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
