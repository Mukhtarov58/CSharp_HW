// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Написать программу для проверки любых чисел
//*********************************************************************************************************
bool CheckPalindrome(int number)
{
    int reversed = 0;
    int temp = number;
    while (reversed < number)
    {
        reversed = reversed * 10 + temp % 10;
        temp /= 10;
    }
    if (reversed == number) return true;
    else return false;
}

Console.Write("Enter a natural number: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());
bool result = CheckPalindrome(naturalNumber);
Console.WriteLine($"Is number {naturalNumber} a palindrome? -> {result}");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве
//*********************************************************************************************************
double GetDistance(
    double x1, double y1, double z1,
    double x2, double y2, double z2
)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;

    double result = Math.Round(Math.Pow(dx * dx + dy * dy + dz * dz, 0.5), 2);

    return result;
}

Console.Write("Enter 1st point x coordinate: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter 1st point y coordinate: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter 1st point z coordinate: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter 2nd point x coordinate: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter 2nd point y coordinate: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter 2nd point z coordinate: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance between points with coordinates ({x1}; {y1}; {z1}) and ({x2}; {y2}; {z2}) is {distance}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
//*********************************************************************************************************
void WriteCubes(int limit)
{
    int counter = 1;
    while (counter <= limit)
    {
        Console.Write($"{Convert.ToInt32(Math.Pow(counter, 3))} ");
        counter++;
    }
}

Console.Write("Enter a natural number: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());
WriteCubes(naturalNumber);
