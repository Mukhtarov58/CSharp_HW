// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
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