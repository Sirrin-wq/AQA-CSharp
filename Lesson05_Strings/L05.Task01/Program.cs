using System.Text.RegularExpressions;

namespace L05.Task01;

/*
Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все
символы, являющиеся цифрами.
 */
class Program
{
    static void Main(string[] args)
    {
        string veryWiseSentence =
            "A wise person knows that every test is not just a test, but a test of whether the test was truly worth testing.";

        Console.WriteLine(Regex.Replace(veryWiseSentence, @"\btest\b", "testing"));
    }
}