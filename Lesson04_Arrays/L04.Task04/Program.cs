namespace L04.Task04;

/*
Создайте двумерный массив целых чисел. Выведите на консоль сумму всех
элементов массива.
 */
class Program
{
    static void Main(string[] args)
    {
        int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.Write("2d array: ");
        
        int sum = 0;
        foreach (int num in twoDArray)
        {
            Console.Write(num + " ");
            sum += num;
        }
        
        Console.WriteLine("\nsum of elements: " + sum);
    }
}