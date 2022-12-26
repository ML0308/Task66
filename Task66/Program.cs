using System;

namespace Task66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumFromMToN = 0;
            for (; m <= n; m++)
            {
                sumFromMToN += m;
            }
            Console.WriteLine(sumFromMToN);
            Console.Read();
        }
    }
}
