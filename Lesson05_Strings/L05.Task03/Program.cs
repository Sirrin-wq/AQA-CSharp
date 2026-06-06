namespace L05.Task03;

/*
Дана строка: Плохой день.
Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо
используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
Заменить последний "!" на "?"
 */
class Program
{
    static void Main(string[] args)
    {
        string badDay = "Плохой день";
        
        string day = badDay.Substring(6);
        
        string goodDay = day.Insert(0, "Хороший");
        
        goodDay = goodDay.Insert(goodDay.Length, "!!!!!!!!!");

        int index = goodDay.LastIndexOf("!");

        goodDay = goodDay.Remove(index, 1);
        
        string questionableDay = goodDay.Insert(index, "?");
        
        Console.WriteLine(questionableDay);
    }
}