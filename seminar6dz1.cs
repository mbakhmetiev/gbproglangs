//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.

using System;

public class dz1{
    public static void Main(string[] args) {
        char[,] chars = {{'a','b'},{'c','d'}};
        Console.WriteLine(CharToString(chars));
    }

    static string CharToString(char[,] chars){
        string result = string.Empty;
        
        for(int i = 0; i < chars.GetLength(0); i++) {
            for(int j = 0; j < chars.GetLength(1); j++) {
                result += chars[i,j];
            }
        }
        return result;
    }
}
    




