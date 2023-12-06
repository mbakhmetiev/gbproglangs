using System;

public class dz1 {
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
        Console.WriteLine("Кол-во элементов в массиве в диапазоне [20,90] => {0}", NumsIn20n90(array));
    }

    public static int NumsIn20n90(int [] array)  {
        int count = 0;
        foreach(int item in array) {
            if (item >= 20 && item <= 90) {
                count++;
            }
        }
        return count;
    }
}
