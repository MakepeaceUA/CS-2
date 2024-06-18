using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Console.Write("Введите сумму от 1 до 9999: ");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //if (amount < 5 && amount > 1)
            //{
            //    Console.Write($"{amount} доллара");
            //}
            //else if (amount % 10 == 1 && amount != 11)
            //{
            //    Console.Write($"{amount} доллар");
            //}
            //else
            //{
            //    Console.Write($"{amount} долларов");
            //}


            //Задание 2
            //Console.Write("Введите число: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool PrimeNum = true;
            //for (int i = 2; i < Math.Sqrt(num); i++)
            //{
            //    if (num % i == 0)
            //    {
            //        PrimeNum = false;
            //        break;
            //    }
            //}
            //if (!PrimeNum)
            //{
            //    Console.Write($"Число {num} не простое");
            //}
            //else
            //{
            //    Console.Write($"Число {num} простое");
            //}

            //Задание 3
            //Console.Write("Введите число: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    Console.Write(digit);
            //    num /= 10; 
            //}

            //Задание 4
            //Console.Write("Введите число: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int val = num;
            //int sum = 0;

            //int num_digits = num.ToString().Length;

            //for (int i = 0; i < num_digits; i++)
            //{
            //    int digit = val % 10;
            //    val /= 10;
            //    sum += (int)Math.Pow(digit, num_digits);
            //}
            //if (sum == num)
            //{
            //    Console.WriteLine($"{num} является числом Армстронга.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} не является числом Армстронга.");
            //}
        }
    }
}