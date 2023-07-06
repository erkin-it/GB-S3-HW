// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Функция нахождения квадрата разницы точек координат (X2-X1)^2.
double Fun1 (int a, int b)
{
    return Math.Pow(b-a, 2);
}

//--------------------------------------------------------------------------------
double Result=0;

//Ввод координат точеки 1
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine());

//Ввод координат точеки 1
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine());


//Вывод расстояние между точками в 3D пространстве.

Result=Math.Sqrt(Fun1(x1,x2)+Fun1(y1,y2)+Fun1(z1,z2));

Console.WriteLine($"расстояние между ними в 3D пространстве: {Result}");
