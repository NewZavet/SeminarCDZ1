// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите день недели от 1 до 7");
string? number_string = Console.ReadLine();
int number_int = Convert.ToInt32(number_string);

if (number_int == 1)
{
    Console.WriteLine("Понедельник");
}
if (number_int == 2)
{
    Console.WriteLine("Вторник");
}
if (number_int == 3)
{
    Console.WriteLine("Среда");
}
if (number_int == 4)
{
    Console.WriteLine("Четверг");
}
if (number_int == 5)
{
    Console.WriteLine("Пятница");
}
if (number_int == 6)
{
    Console.WriteLine("Суббота");
}
if (number_int == 7)
{
    Console.WriteLine("Воскресенье");
}
if (number_int > 8 || number_int < 1)
{
    Console.WriteLine("Нет такого дня недели!");
}