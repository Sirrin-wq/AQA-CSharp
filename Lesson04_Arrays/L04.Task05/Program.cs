namespace L04.Task05;

/*
Создайте двумерный массив.
Выведите на консоль диагонали массива.
 */
class Program
{
    static void Main(string[] args)
    {
        int[,] twoDArray =
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            {13, 14, 15, 16}
        };

        int size = twoDArray.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            Console.Write(twoDArray[i, i] + " ");
        }
        
        Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            Console.Write(twoDArray[i, size - 1 - i] + " ");
        }
    }
}