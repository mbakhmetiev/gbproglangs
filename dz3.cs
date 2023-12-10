using System;

public class dz2 {
    public static void Main(string[] args){
        int size = 10;
        double min = 1;
        double max = 100;
        double range = max - min;
        double [] array = new double[size];

        Random rand = new Random();

        for(int i = 0; i < size; i++) {
            double sample = rand.NextDouble();
            double scaled = (sample * range) + min;
            array[i] = Math.Round((float)scaled, 2);
        }

        Console.WriteLine("Исходный массив:");
        Console.Write("[");
        foreach(float item in array) {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("]");
        Console.WriteLine("Разница max - min в массиве => {0}", DiffMaxMinInArr(array));
    }

    public static double DiffMaxMinInArr(double [] array)  {
        double max = array[0];
        double min = array[0];
        foreach(double item in array) {
            max = item > max ? item : max;
            min = item < min ? item : min;
        }
        return max - min;
    }
}
