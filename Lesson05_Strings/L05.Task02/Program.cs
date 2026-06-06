namespace L05.Task02;

/*
Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
Необходимо найти в данной строке "abc", записав всё что до этих символов в первую
переменную, а также всё, что после них во вторую.
Результат вывести в консоль.
 */
class Program
{
    static void Main(string[] args)
    {
        // #1
        Console.WriteLine("First method:");
        string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";
        int abcFirstIndex = str.IndexOf("abc");

        string beforeABC = str.Substring(0, abcFirstIndex);
        string afterABC = str.Substring(abcFirstIndex + 3);

        Console.WriteLine(beforeABC);
        Console.WriteLine(afterABC);

        // #2
        Console.WriteLine("\nSecond method:");
        string[] abcSplitter = str.Split("abc");
        string firstPart = abcSplitter[0];
        string secondPart = abcSplitter[1];

        Console.WriteLine(firstPart + " " + secondPart);
    }
}