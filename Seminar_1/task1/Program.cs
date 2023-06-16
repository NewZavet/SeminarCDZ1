// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

using System;
Console.WriteLine("Введите первое число");
string? number_string_one = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? number_string_two = Console.ReadLine();

int number_int_one = Convert.ToInt32(number_string_one);
int number_int_two = Convert.ToInt32(number_string_two);

if (number_int_two * number_int_two == number_int_one)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
