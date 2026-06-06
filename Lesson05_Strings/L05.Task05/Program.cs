using System.Text;
using System.Text.RegularExpressions;

namespace L05.Task05;

/*
Написать программу со следующим функционалом:
На вход передать строку (будем считать, что это номер документа).
Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,
а y — это буква.
Вывести на экран в одну строку два первых блока по 4 цифры.
Вывести на экран номер документа, но блоки из трех букв заменить
на *** (каждая буква заменятся на *).
Вывести на экран только одни буквы из номера документа в
формате yyy/yyy/y/y в нижнем регистре.
Вывести на экран буквы из номера документа в формате
"Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
класса StringBuilder).
Проверить содержит ли номер документа последовательность abc и
вывети сообщение содержит или нет(причем, abc и ABC считается
одинаковой последовательностью).
Проверить начинается ли номер документа с последовательности 555.
 */
class Program
{
    static void Main(string[] args)
    {
        string documentNum = "1234-abc-5678-def-9123-g4h5";

        // #1 print 2 first 4 digit blocks
        string[] arr = documentNum.Split("-");
        Console.WriteLine(arr[0] + " " + arr[2]);

        // #2 replace letter blocks with *
        Console.WriteLine(Regex.Replace(documentNum, "[A-Za-z]{3}", "***"));

        // #3 print only letters in format yyy/yyy/y/y
        MatchCollection matches = Regex.Matches(documentNum, @"[A-Za-z]+");

        Console.WriteLine($"{matches[0]}/{matches[1]}/{matches[2]}/{matches[3]}");

        // #4 print only letters in format yyy/yyy/y/y using StringBuilder
        StringBuilder result = new StringBuilder();

        result.Append("Letters:");
        result.Append(matches[0]);
        result.Append("/");
        result.Append(matches[1]);
        result.Append("/");
        result.Append(matches[2]);
        result.Append("/");
        result.Append(matches[3]);

        // #5 contains abc or not
        Console.WriteLine(documentNum.ToLower().Contains("abc"));
        
        // #6 start with 555 or not
        Console.WriteLine(documentNum.StartsWith("555"));
    }
}