namespace L04.Task02;

/*
Создайте массив целых чисел. Удалите все вхождения заданного числа из
массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об
этом.
В результате должен быть новый массив без указанного числа.
 */
class Program
{
    static void Main(string[] args)
    {
        int[] integers = { 28, 3, 15, 12, 7, 88, 21, 0, 3, 3, 7, 22, 12, 3, 3, 9 };
        Console.WriteLine("Enter a number to delete from this array:");
        Console.WriteLine(string.Join(", ", integers));

        int numberToDelete = int.Parse(Console.ReadLine());
        

        if (integers.Contains(numberToDelete))
        {
            int matchCount = 0;

            foreach (int number in integers)
            {
                if (number == numberToDelete)
                {
                    matchCount++;
                }
            }

            int[] newArr = new int[integers.Length - matchCount];

            for (int i = 0, k = 0; i < integers.Length; i++, k++)
            {
                if (integers[i] != numberToDelete)
                {
                    newArr[k] = integers[i];
                }
                else
                {
                    k--;
                }
            }

            Console.WriteLine($"{numberToDelete} has been successfully deleted");
            Console.WriteLine("before: " + string.Join(", ", integers));
            Console.WriteLine("after:  " + string.Join(", ", newArr));
        }
        else
        {
            Console.WriteLine("Array doesn't have this number");
        }
    }
}