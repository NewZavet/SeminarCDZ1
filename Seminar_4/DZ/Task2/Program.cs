// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt (string message)
{
    System.Console.Write(message); // выводим приглашение ко вводу
    string? readInput = System.Console.ReadLine(); // вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат 
}

int SumAllDigit (int number)
{
    int result = 0;
    while (number >0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Promt("Введите число: ");
System.Console.WriteLine($"Сумма всех числе в цифре {number} = {SumAllDigit (number)}");
