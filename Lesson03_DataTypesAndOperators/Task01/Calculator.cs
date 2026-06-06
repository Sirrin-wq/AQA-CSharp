namespace Task01;

/*
Задание 1
Напишите программу - консольный калькулятор.
Создайте две переменные с именами operand1 и operand2.
Задайте переменным некоторые произвольные значения.
Предложите пользователю ввести знак арифметической операции.
Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
Для организации выбора алгоритма вычислительного процесса, используйте
переключатель switch.
Выведите на экран результат выполнения арифметической операции.
В случае использования операции деления, организуйте проверку попытки деления на
ноль.
И если таковая имеется, то отмените выполнение арифметической операции и
уведомите об ошибке пользователя.
 */
class Calculator
{
    static void Main(string[] args)
    {
        double operand1 = 0;
        double operand2 = 0;
        double res = 0;
        string sign = string.Empty;
        bool operationSuccessful;

        while (true)
        {
            operationSuccessful = true;
            Console.WriteLine("Please type the sign of operation you want to do (+, -, *, /): ");
            sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("Enter first number");
                    operand1 = ReadDouble();
                    Console.WriteLine("Enter second number");
                    operand2 = ReadDouble();
                    res = operand1 + operand2;
                    break;
                case "-":
                    Console.WriteLine("Enter first number");
                    operand1 = ReadDouble();
                    Console.WriteLine("Enter second number");
                    operand2 = ReadDouble();
                    res = operand1 - operand2;
                    break;
                case "*":
                    Console.WriteLine("Enter first number");
                    operand1 = ReadDouble();
                    Console.WriteLine("Enter second number");
                    operand2 = ReadDouble();
                    res = operand1 * operand2;
                    break;
                case "/":
                    Console.WriteLine("Enter first number");
                    operand1 = ReadDouble();
                    Console.WriteLine("Enter second number");
                    operand2 = ReadDouble();

                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: division by zero");
                        operationSuccessful = false;
                    }
                    else
                    {
                        res = operand1 / operand2;
                    }

                    break;
                default:
                    Console.WriteLine("This operation doesn't exist, try again");
                    break;
            }

            if (operationSuccessful)
            {
                Console.WriteLine($"{operand1} {sign} {operand2} = {res:F2}");
            }

            Console.WriteLine("1. continue \n2. exit");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                break;
            }
        }
    }

    private static double ReadDouble()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                return number;
            }

            Console.WriteLine("Invalid number. Try again:");
        }
    }
}