// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


using System;
Console.WriteLine("Введите первое число");
string? number_string_one = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? number_string_two = Console.ReadLine();

int number_int_one = Convert.ToInt32(number_string_one);
int number_int_two = Convert.ToInt32(number_string_two);

if (number_int_two * number_int_two == number_int_one || number_int_one * number_int_one == number_int_two)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
