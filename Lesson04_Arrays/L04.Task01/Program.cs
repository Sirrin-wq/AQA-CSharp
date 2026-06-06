namespace L04.Task01;

/*
Создайте массив целых чисел. Напишете программу, которая выводит сообщение
о том, входит ли заданное число в массив или нет. Пусть число для поиска
задается с консоли.
 */
class Program
{
    static void Main(string[] args)
    {
        int[] integers = { 28, 3, 15, 12, 7, 88, 21, 0 };

        Console.WriteLine("Guess a number from array of integers");
        int guess = int.Parse(Console.ReadLine());
        
        Console.WriteLine(integers.Contains(guess) ? "Your guess is correct" : "You guessed wrong this time");
    }
}