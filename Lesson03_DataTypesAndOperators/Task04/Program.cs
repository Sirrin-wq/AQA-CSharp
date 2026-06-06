namespace Task04;

/*
Задание 4
Напишите программу, которая будет выполнять проверку чисел на четность.
Предложите два варианта решения поставленной задачи.
 */
class Program
{
    static void Main(string[] args)
    {
        int[] testNumbers = { -4, -3, 0, 1, 2, 7, 10, 15, 100 };

        foreach (int number in testNumbers)
        {
            bool result1 = IsEven1(number);
            bool result3 = IsEven3(number);

            Console.WriteLine($"{number}: IsEven1 = {result1}, IsEven3 = {result3}");

            if (result1 == result3)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            Console.WriteLine();
        }
    }

    private static bool IsEven1(int num)
    {
        return num % 2 == 0;
    }

    private static bool IsEven2(int num)
    {
        bool res = false;
        Console.WriteLine($"Is {num} even?");
        string input1 = Console.ReadLine();
        if (input1.Trim().ToLower() == "yes")
        {
            Console.WriteLine("Promise?");
            string input2 = Console.ReadLine();
            if (input2.Trim().ToLower() == "yes")
            {
                res = true;
            }
        }

        return res;
    }

    private static bool IsEven3(int num)
    {
        return (num & 1) == 0;
    }
}