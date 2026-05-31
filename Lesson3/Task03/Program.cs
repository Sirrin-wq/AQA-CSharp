using System.Text;

namespace Task03;

/*
Задание 3
Напишите программу русско-английский переводчик.
Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему
перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести
сообщение, что такого слова нет.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        Dictionary<string, string> weatherWords = new Dictionary<string, string>
        {
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "солнце", "sun" },
            { "облако", "cloud" },
            { "туман", "fog" },
            { "гроза", "thunderstorm" },
            { "молния", "lightning" },
            { "град", "hail" },
            { "жара", "heat" }
        };
        
        Console.WriteLine("Enter a russian word about weather to get an english translation from dictionary:");
        string inputWord = Console.ReadLine();

        if (weatherWords.TryGetValue(inputWord.Trim().ToLower(), out string translation))
        {
            Console.WriteLine(translation);
        }
        else
        {
            Console.WriteLine("Sorry, dictionary doesn't have translation for this word");
        }
    }
}