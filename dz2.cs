using System;

public class dz2 {
    public static void Main(string[] args){
        int size = 10;
        int [] array = new int[size];

        Random rand = new Random();

        for(int i = 0; i < size; i++) {
            array[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Исходный массив:");
        Console.Write("[");
        foreach(int item in array) {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("]");
        Console.WriteLine("Кол-во четных элементов в массиве => {0}", NumEvenInArr(array));
    }

    public static int NumEvenInArr(int [] array)  {
        int count = 0;
        foreach(int item in array) {
            if (item % 2 == 0) {
                count++;
            }
        }
        return count;
    }
}
