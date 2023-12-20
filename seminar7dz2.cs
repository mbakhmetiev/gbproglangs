//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

using System;

public class dz2{
    public static void Main(string[] args) {
        int m, n;

        m = Convert.ToInt32(args[0]);
        n = Convert.ToInt32(args[1]);

        Console.Write($"M = {m}, ");
        Console.WriteLine($"N = {n}");

        Console.WriteLine(Akkerman(m, n));
    }

    static int Akkerman(int m, int n) {
        if(m == 0) {
            return n + 1;
        }
        else {
            if(n == 0) {
                return Akkerman(m - 1, 1);
            } else {
                return Akkerman(m - 1, Akkerman(m, n - 1));   
            }
        }
    }
}
