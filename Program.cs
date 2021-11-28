using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_23
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Факториал числа {n} = {FactorialAsync(n).Result}");
            Console.ReadKey();
        }
        static long Factorial(int n)
        {
            long res = 1;
            for (int i = n; i >0; i--)
            {
                res *= i;
            }
            return res;
        }
        static async Task<long> FactorialAsync(int n)
        {
            long result = await Task.Run(() => Factorial(n));
            return result;
        }
    }
}
