//*********************************************************************************************************
// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//*********************************************************************************************************

double NumbInPower(int a, int b){
    double res = a;
    for(int i = 1; i < b; i++){
        res *= a;
    }
    return res;
}
Console.WriteLine("Enter the number A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B: ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} in power {pow} equales {NumbInPower(num, pow)}");
//*********************************************************************************************************
// Задача 27:
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
//*********************************************************************************************************

void SumNumb(int num)
{
    if (num <= 10)
    {
        Console.WriteLine($"Sum of numb {num}");
    }
    else
    {
        int res = 0;
        while (num != 0)
        {
            res += num % 10;
            num /= 10;
        }
        Console.WriteLine($"Sum of numb equales {res}");
    }
}

Console.WriteLine("Please enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num *= (-1);
}
SumNumb(num);


//*********************************************************************************************************
// Задача 29:
// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
//*********************************************************************************************************

int[] CreateRandomeArray(){
    int size = new Random().Next(1,11);
    int[] array = new int[size];
    for(int i = 0; i<size; i++){
        array[i]= new Random().Next(0,101);
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[");
    for(int i = 0; i<array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

ShowArray(CreateRandomeArray());
