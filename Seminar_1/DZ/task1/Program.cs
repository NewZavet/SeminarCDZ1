
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int max = 0;
int min = 0;

Console.Write("Введите первое число ");
int first_number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int second_number = Convert.ToInt32(Console.ReadLine());

if(first_number > second_number)
{
    max = first_number;
    min = second_number;
}
else
{
    max = second_number;
    min = first_number;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
