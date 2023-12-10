//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

public class dz2 {
    public static void Main(string[] args) {
        int size = 10;
        int [] array = new int[size];

        Random rand = new Random();

        for (int i = 0; i < size; i++) {
            array[i] = rand.Next(100, 1000);
        }

        Console.WriteLine("Исходный массив: ");
        Console.Write("[");
        foreach(int item in array) {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("]");

        Console.WriteLine($"Кол-во четных числе в массиве {EvenNums(array)}");
    }

    static int EvenNums(int[] array) {
        int sum =  0;
        foreach(int item in array) {
            if(item % 2 == 0) {
                sum++;
            }
        }
        return sum;
    }
}
