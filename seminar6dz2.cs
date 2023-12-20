//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

public class dz2{
    public static void Main(string[] args) {
        string word = "HumptyDumpty";
        Console.WriteLine(UpperToLower(word));
    }

    static string UpperToLower(string word){
        string result = string.Empty;
        
        foreach(char ch in word) {
                result += char.ToLower(ch);
        }
        return result;
    }
}
