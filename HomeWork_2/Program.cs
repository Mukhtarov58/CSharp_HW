//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
//************************************************************************

void ExtractSecondDigit(int num = 0){
    if(num <100 ||  num > 999){
        Console.WriteLine("Is not three digit number");
    }
    else{
        int seconDigit = (num / 10) % 10;
        Console.WriteLine($"Second digit of {num} is {seconDigit}");
    }
}

Console.WriteLine("Enter three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
ExtractSecondDigit(num);


// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//************************************************************************

int FindThirdDigit(int num){
    if (num >999)
    {
        int thirdDigit = (num / 100) % 10;
        return thirdDigit;
    }
    else if(num > 99 && num < 1000)
    {
        int digit1 = num / 100;
        int digit2 = (num / 10) % 10;
        int newNum =(digit1*100) + (digit2*10);
        int thirdDigit = num - newNum;
        return thirdDigit;
    }
    else
    {
        return -1;
    }
}

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = FindThirdDigit(num);

if (res != -1)
{
    Console.WriteLine($"The third digit of the number: {res}");
}
else
{
    Console.WriteLine("The number doesn't have a third digit!!!");
}


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//************************************************************************

bool IsWeekend(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Enter a day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber >=1 && dayNumber <= 7)
{
    bool isWeekendDay = IsWeekend(dayNumber);
    if(isWeekendDay)
    {
        Console.WriteLine($"{dayNumber} - is weekend day");
    }
    else
    {
        Console.WriteLine($"{dayNumber} - is not weekend day");
    }
}
else
{
    Console.WriteLine($"{dayNumber} - does not indicate the day of the week!!! ");
}