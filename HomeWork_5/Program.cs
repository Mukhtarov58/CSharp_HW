int[] CreateRandomeArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//*********************************************************************************************************
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//*********************************************************************************************************

void CalcEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Number of even numbers {count}");

}

int[] newArray = CreateRandomeArray(100, 999, 5);
ShowArray(newArray);
CalcEvenNum(newArray);


//*********************************************************************************************************
// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//*********************************************************************************************************

void CalcSumNumOddPos(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumOdd += array[i];
        }
    }
    Console.WriteLine($"Sum of elements standing in odd positions {sumOdd}");

}

int[] newArray2 = CreateRandomeArray(-10, 100, 5);
ShowArray(newArray2);
CalcSumNumOddPos(newArray2);


//*********************************************************************************************************
// Задача 38:
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
//*********************************************************************************************************

double [] BubbleSort(double [] array)
{
    double  temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void DifferenceElem(double[] array){
    double difference = array[array.Length - 1] - array[0];
    Console.WriteLine($"Difference between the maximum and minimum elements {difference}");
}

double[] array3 = {2.5, 1.0, 4.8, 7.2, 3.6, 6.9, 0.3};
double[] newArray3 = BubbleSort(array3);
ShowDoubleArray(newArray3);
DifferenceElem(newArray3);