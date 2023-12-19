//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

using System;

public class dz3{
    public static void Main(string[] args) {
        int size = 10;
        int[] array = new int[size];

        Random rand = new Random();
        for(int i = 0; i < size; i++) {
            array[i] = rand.Next(1, 101);
        }

        foreach(int item in array) {
            Console.Write($"{item} ");
        }
        
        Console.WriteLine();
        PrintArray(array, size-1);
        Console.WriteLine();
    }
    
    public static void PrintArray(int[] arr, int i) {
        Console.Write($"{arr[i]} ");
        i--;
        if (i >= 0) PrintArray(arr, i);
    }
}
