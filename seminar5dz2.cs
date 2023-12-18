//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

using System;

public class dz2 {
    public static void Main(string[] args) {
        int sizei = 4;
        int sizej = 10;
        int[,] arr  = new int[sizei,sizej];
        int[,] arrInverted  = new int[sizei,sizej];

        Random rand = new Random();
        
        for(int i = 0; i < sizei; i ++) {
            for(int j = 0; j < sizej; j++) {
                arr[i,j] = rand.Next(1, 100);
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        for(int i = 0; i < arr.GetLength(0); i++) {
           for(int j = 0; j < arr.GetLength(1); j++) {
               if(i == 0) {
                   arrInverted[arr.GetLength(0) - 1, j] = arr [i, j]; 
                   continue;
               }
               if(i == arr.GetLength(0) - 1) {
                   arrInverted[0, j] = arr[i, j];
                   continue;
               }
               arrInverted[i, j] = arr[i, j];
           }
        }
        Console.WriteLine("Измененный массив:");
        PrintArray(arrInverted);
    }

    static void PrintArray(int [,] arr) {
        for(int i = 0; i < arr.GetLength(0); i++) {
            for(int j = 0; j < arr.GetLength(1); j++) {
                Console.Write($"{arr[i, j], 2} ");
            }
            Console.WriteLine();
        }
    }
}
