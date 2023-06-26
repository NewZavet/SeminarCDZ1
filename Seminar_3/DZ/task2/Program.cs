// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

// Math.Sqrt(x) корень
// Math.Pow (x, 2) квадрат

double skobX = Math.Pow(x2 - x1, 2);
double skobY = Math.Pow(y2 - y1, 2);
double skobz = Math.Pow(z2 - z1, 2);
double result = Math.Sqrt(skobX + skobY +skobz);

// Console.WriteLine(result);
Console.WriteLine($"{result:f2}"); // f2 - f-округление, 2-округлениедо скольки знаков
