// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введите целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int proizv(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
int number = ReadInt();
int proizv1 = proizv(number);
Console.WriteLine($"произведение чисел от 1 до {number} получается {proizv1}");
