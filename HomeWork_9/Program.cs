//*********************************************************************************************************
// Задача 64:
// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
//*********************************************************************************************************


void ShowAllNumbers(int n)
{
    Console.Write($"{n} ");

    if (n > 1)
        ShowAllNumbers(n - 1);
}

Console.WriteLine("Enter N number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowAllNumbers(n);


//*********************************************************************************************************
// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
//*********************************************************************************************************


int ShowSumNumbers(int n, int m)
{
    if (n > m)
    {
        return ShowSumNumbers(n, m + 1) + m;
    }
    return n;
}

System.Console.WriteLine("Enter N number");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter M number");
int m = Convert.ToInt32(Console.ReadLine());
int sum = ShowSumNumbers(Math.Max(n, m), Math.Min(n, m));
Console.WriteLine(sum);