using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ВВедите первое число");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ВВедите второе число");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        string operation = Console.ReadLine();

        switch(operation){
            case "1":
                Console.WriteLine($"Результат сложения: {number1 + number2}");
                break;
            case "2":
                Console.WriteLine($"Результат вычитания: {number1 - number2}");
                break;
            case "3":
                Console.WriteLine($"Результат умножения: {number1 * number2}");
                break;
            case "4":
                Console.WriteLine($"Результат деления: {number1 / number2}");
                break;
            default:
                Console.WriteLine("Не верный выбор операции.");
                break;
        }
    }
}