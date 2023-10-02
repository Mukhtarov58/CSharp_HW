//*********************************************************************************************************
// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//*********************************************************************************************************


int GetNaturalNum()
{
    int naturals = 0, number;
    Console.Write("Enter the number: ");
    while (int.TryParse(Console.ReadLine(), out number))
    {
        if (number > 0) naturals++;
        Console.Write("Enter the number: ");
    }
    return naturals;
}

Console.WriteLine($"There's {GetNaturalNum()} natural numbers");


//*********************************************************************************************************
// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//*********************************************************************************************************


string Intersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            return "Are the same lines";
        return "Are the parallel lines";
    }
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return $"The intersection point of the lines:  ({x}, {y})";
}

Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Intersection(b1, k1, b2, k2));