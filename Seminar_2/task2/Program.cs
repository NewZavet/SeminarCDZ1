// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int input = new Random().Next(100, 1000);
    int index = 2;

    int m = 1;
    while (index > 1) {
        m *= 10;
        index--;
    }
    int result = (input % m) + (input / (m * 10)) * m;

    Console.WriteLine("input "+input+" result:" + result);
    

