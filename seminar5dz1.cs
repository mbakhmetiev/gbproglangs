//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

public class dz1 {
    public static void Main(string[] args) {
        int sizei = 3;
        int sizej = 5;
        int[,] arr  = new int[sizei,sizej];

        Random rand = new Random();
        
        for(int i = 0; i < sizei; i ++) {
            for(int j = 0; j < sizej; j++) {
                arr[i,j] = rand.Next(1, 100);
            }
        }
        
        Console.WriteLine("Исходный массив:");

        for(int i = 0; i < arr.GetLength(0); i++) {
            for(int j = 0; j < arr.GetLength(1); j++) {
                Console.Write($"{arr[i, j], 2} ");
            }
            Console.WriteLine();
        }
        
        PrintPosition(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), arr);
    }

    static void PrintPosition(int i, int j, int[,] arr) {
        Console.WriteLine($"Полученная позиция элемента: [{i},{j}]");
        try {
            Console.Write("Значение элемента: ");
            Console.WriteLine(arr[i,j]);
        } catch (IndexOutOfRangeException e) {
            Console.WriteLine($"Ошибка-> {e.Message}");
        }
    }
}
