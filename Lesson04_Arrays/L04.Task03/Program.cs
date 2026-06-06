namespace L04.Task03;

/*
Создайте и заполните массив случайным числами и выведете максимальное,
минимальное и среднее значение.
Пусть будет возможность создавать массив произвольного размера. Пусть размер массива
вводится с консоли.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Enter array size\n2. Make array of random size");
        int input = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int customArraySize = 0;
        int randomArraySize = 0;
        int[] randomArr = null;


        if (input == 1)
        {
            Console.WriteLine("Enter array size");
            customArraySize = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chosen size: {customArraySize}");
            randomArr = new int[customArraySize];
        }
        else if (input == 2)
        {
            randomArraySize = (int)rand.NextInt64(1, 20);
            Console.WriteLine($"Generated size: {randomArraySize}");
            randomArr = new int[randomArraySize];
        }
        else
        {
            Console.WriteLine("No such option");
            return;
        }

        for (int i = 0; i < randomArr.Length; i++)
        {
            randomArr[i] = (int)rand.NextInt64(-100, 100);
        }

        Console.WriteLine("Resulting array: " + string.Join(", ", randomArr));
        Console.WriteLine("Max value: " + randomArr.Max());
        Console.WriteLine("Min value: " + randomArr.Min());
        Console.WriteLine($"Average value: {randomArr.Average():F2}");
    }
}