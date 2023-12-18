//Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

using System;

public class dz2{
    public static void Main(string[] args) {
        Console.WriteLine($"Полученное слово является палиндромом: {IsPalindrom(args[0])}");
    }

    static bool IsPalindrom(string word){
        string result = string.Empty;
        char[] chresult = new char[word.Length];
        int i = word.Length - 1;

        foreach(char ch in word) {
                chresult[i] = ch;
                i--;
        }

        foreach(char ch in chresult){
            result += ch;
        }
        return result == word;
    }
}
