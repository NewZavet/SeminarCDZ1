// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// ввод числа с экрана
int Prompt (string message)
{
    System.Console.Write(message); // выводим приглашение ко вводу
    string? readInput = System.Console.ReadLine(); // вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат 
}
// метод для получения случайных значений массива
int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int [Length]; // обьявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++);
    {
        array[i] = random.Next(minValue, maxValue +1); // заполняем случайными цифрами из диапазона SatrArr до End Arr
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); // вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); // вывод значения массива
}

int length = Prompt ("Длинна массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt (" Конечное значение, для диапазона случайного числа:");
int [] array = GenerateArray( length, min, max); // заполнение массива случайными числами
PrintArray(array); // вывод массива