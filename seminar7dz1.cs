// Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. Использовать рекурсию, 
//не использовать циклы.

using System;

public class dz1{
    public static void Main(string[] args) {
        int m, n;

        m = Convert.ToInt32(args[0]);
        n = Convert.ToInt32(args[1]);
        Console.Write($"M = {m}, ");
        Console.WriteLine($"N = {n}");
        Console.Write($"Числа в промежутке от {m} до {n}: "); 
        GetNumbers(m,n);
        Console.WriteLine();
    }

    public static void GetNumbers(int m, int n) {
       Console.Write($"{m} ");
       m++;
       if (m <= n) GetNumbers(m, n);
    }
}
