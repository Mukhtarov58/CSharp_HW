// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// *********************************************************************************
Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
Console.WriteLine($"Larger number: {a}");
Console.WriteLine($"Smaller numbers: {b}");
}
else if (b > a)
{
Console.WriteLine($"Larger number: {b}");
Console.WriteLine($"Smaller numbers: {a}");
}
else
{
    Console.WriteLine($"The numbers {a} and {b} are equal.");
}

// Задача 4:
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// *********************************************************************************
Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"Maximum number: {max}");


// Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// *********************************************************************************
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Number {num} is even");
}
else
{
    Console.WriteLine($"Number {num} is not even");
}


// Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// *********************************************************************************
Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i <= N; i+=2)
{
    Console.Write($"{i} " );
}