//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

using System;

public class dz2 {
    public static void Main(string[] args) {
        int sizei = 4;
        int sizej = 10;

        int[,] arr  = new int[sizei,sizej];
        int[,] sumarr = new int[sizei, 1];
        int[,] minsumrow = new int[1, sizej];
        int[,] minsumvalue = new int[1,1];

        int minsum;
        int minindex = 0;

        Random rand = new Random();
        
        for(int i = 0; i < sizei; i ++) {
            for(int j = 0; j < sizej; j++) {
                arr[i,j] = rand.Next(1, 100);
                sumarr[i, 0] += arr[i,j];
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(arr, sumarr);

        minsum = sumarr[0,0];

        for(int i = 0; i < sumarr.GetLength(0); i++) {
            if(sumarr[i,0] < minsum) {
                minsum = sumarr[i,0];
                minindex = i;
            }
        }

        for(int j = 0; j < arr.GetLength(1); j++) {
            minsumrow[0,j] = arr[minindex,j];
        }

        minsumvalue[0,0] = minsum; 

        Console.WriteLine("Строка с наименьшей суммой:");
        PrintArray(minsumrow, minsumvalue);
    }

    static void PrintArray(int[,] arr, int[,] sum) {
        for(int i = 0; i < arr.GetLength(0); i++) {
            for(int j = 0; j < arr.GetLength(1); j++) {
                Console.Write($"{arr[i,j], 2} ");
            }
            Console.WriteLine($"Сумма элементов: {sum[i,0]}");
        }
    }
}
