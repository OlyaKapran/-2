using System;

namespace задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine("max = "+num1);
            }
            else if (num2>num3)
            {
                Console.WriteLine("max = "+num2);
            }
            else
            {
                Console.WriteLine("max = "+num3);
            }
        }
    }
}
