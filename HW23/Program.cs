// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Ввод числа
Console.Write("Введите положительное число больше 1-го : ");
int n = int.Parse(Console.ReadLine());

if (n > 1)
{
    for (int i=1; i<=n;i++) 
    {
        Console.Write($"{Math.Pow(i,3)} ");
    }
} 
else
{
    Console.WriteLine("Вы ввели число меньшее или равно 1");
}