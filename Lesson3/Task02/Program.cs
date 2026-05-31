namespace Task02;

/*
Задание 2
Напишите программу определения, попадает ли указанное пользователем число от 0 до
100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50] [51 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых
промежутков, то выводится соответствующее сообщение.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number from 0 to 100");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 14)
        {
            Console.WriteLine($"{number} belongs to [0 - 14] group");
        } 
        else if (number >= 15 && number <= 35)
        {
            Console.WriteLine($"{number} belongs to [15 - 35] group");
            
        }
        else if (number >= 36 && number <= 50)
        {
            Console.WriteLine($"{number} belongs to [36 - 50] group");
        }
        else if (number >= 51 && number <= 100)
        {
            Console.WriteLine($"{number} belongs to [51 - 100] group");
        }
        else
        {
            Console.WriteLine($"{number} doesn't belong to any group");
        }
    }
}