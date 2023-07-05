// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool CheckPalindrom(int CheckNum)
{
    int a = CheckNum;
    int b = 0;
    int c = 0;
    do 
        {
            c=a%10;
            b=b*10+c;
            a=a/10;
        }
    while (a > 0);

    if (CheckNum == b)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

//------------------------------------------------------------------------

//Ввод числа
Console.Write("Введите пятизначное положительное число: ");
int NumToCheck = int.Parse(Console.ReadLine());

//проверка

if (NumToCheck > 9999 && NumToCheck < 100000)
{
    if (CheckPalindrom(NumToCheck))
    {
        Console.Write("Число является палиндромом");
    } 
    else
    {
        Console.Write("Число не является палиндромом");
    }
}
else 
{
    Console.Write("Число не соответствует условию");
}