//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

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
        PrintArray(array);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(InverseArray(array, size));
    }

    static int[] InverseArray(int[] array, int size) {
        int[] inveredArray = new int[size];
        int j = 0;
        for(int i = size - 1; i >= 0; --i) {
            inveredArray[j] = array[i];
            j++;
        }
        return inveredArray;
    }

    static void PrintArray(int[] array) {
        Console.Write("[ ");
        foreach(int item in array) {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("]");
    }
}
