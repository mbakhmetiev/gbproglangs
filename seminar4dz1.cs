// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

public class dz1 {
    public static void Main(string[] args) {
        String userInput;
        int num;

        while (true) {
            Console.WriteLine("Введите целое число, чтобы завершить, введите число с четной суммой цифр или символ 'q'");
            userInput = Console.ReadLine();

            if(String.Equals(userInput, "q")) {
                Console.WriteLine("Получен символ 'q', программа завершена");
                break;
            } else if(int.TryParse(userInput, out num)) {
                if(EvenCheck(num)) {
                    Console.WriteLine("Сумма чисел полученного числа - четная, программа зaвершена");
                    break;
                } else {
                    Console.WriteLine($"Получено число: {userInput}");
                }
            } else continue;
        }

    }
    
    static bool EvenCheck(int num) {
        int sum = 0;

        while(num != 0) {
            sum += num % 10;
            num = num / 10;
        }

        return (sum % 2 == 0);
    }

}
