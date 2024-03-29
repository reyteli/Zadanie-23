﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsync(n);
            Console.ReadKey();
        }

        static void Sum(int n)
        {
            int s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }

        static async void SumAsync(int n)
        {
            await Task.Run(() => Sum(n));
        }
    
    }  
}
