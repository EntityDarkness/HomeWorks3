﻿namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье целое число:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int max = ((firstNumber > secondNumber) && (firstNumber > thirdNumber)) ? firstNumber : ((secondNumber > thirdNumber) ? secondNumber : thirdNumber);


            Console.WriteLine("Самое большое число: {0}", max);
            Console.ReadKey();
        }
    }
}
