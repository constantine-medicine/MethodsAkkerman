using System;

namespace MethodsAkkerman
{
    internal class Program
    {
        private static void Main(string[] args)
        {
    
            int result = Akkerman(3, 5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод, вычисляющий функцию Аккермана. Принимает два целых числа в качестве параметра и
        /// возвращает результом работы функции целое число.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Akkerman(int m, int n)
        {
            int res = 0;

            if (m == 0)
            {
                return res = n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return res = Akkerman(m - 1, 1);
            }
            if (m > 0 && n > 0)
            {
                return res = Akkerman(m - 1, Akkerman(m, n - 1));
            }

            return res;
        }
    }
}