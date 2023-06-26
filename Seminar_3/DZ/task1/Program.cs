// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10000 || N > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else if (N >= 10000 && N <= 99999)
{
    int number1 = (N / 10000) % 10;
    Console.Write("Первая цифра ");
    Console.WriteLine(number1);
    
    int number5 = (N / 1) % 10;
    Console.Write("Пятая цифра ");
    Console.WriteLine(number5);
    
    int number2 = (N / 1000) % 10;
    Console.Write("Вторая цифра ");
    Console.WriteLine(number2);
    
    int number4 = (N / 10) % 10;
    Console.Write("Четвертая цифра ");
    Console.WriteLine(number4);
    
    if (number1 == number5 && number2 == number4)
    {
        Console.Write("Это число палиндром");
    }
    else
        Console.Write("Это число не палиндром");
}
