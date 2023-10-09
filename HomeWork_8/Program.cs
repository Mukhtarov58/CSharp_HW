//*********************************************************************************************************
// Напишите программу для работы с матрицей целых чисел.
// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. 
// Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.
// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так,
//  чтобы элементы в каждой строке шли по убыванию.
//*********************************************************************************************************

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}


void SortRowsDescending(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        // Используем сортировку вставками для текущей строки
        for (int j = 1; j < numColumns; j++)
        {
            int currentElement = matrix[i, j];
            int k = j - 1;

            while (k >= 0 && matrix[i, k] < currentElement)
            {
                matrix[i, k + 1] = matrix[i, k];
                k--;
            }

            matrix[i, k + 1] = currentElement;
        }
    }

}


int[,] matrix;
if (args.Length == 0)
{
    // Если аргументы не переданы, используем матрицу по умолчанию
    matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
}
else
{
    // Иначе, парсим аргументы в двумерный массив
    string[] rows = args[0].Split(';');
    matrix = new int[rows.Length, rows[0].Split(',').Length];
    for (int i = 0; i < rows.Length; i++)
    {
        string[] elements = rows[i].Split(',');
        if (elements.Length != matrix.GetLength(1))
        {
            Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
            return;
        }
        for (int j = 0; j < elements.Length; j++)
        {
            if (int.TryParse(elements[j], out int number))
            {
                matrix[i, j] = number;
            }
            else
            {
                Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                return;
            }
        }
    }
}

Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

SortRowsDescending(matrix);

Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
PrintMatrix(matrix);


//*********************************************************************************************************
// Определение строки с наименьшей суммой элементов
// Инструкция по использованию платформы
// Напишите программу для работы с матрицей целых чисел.
// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в
// заданной строке row матрицы matrix. Метод принимает двумерный массив целых 
// чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов.
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов:
// номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.
//*********************************************************************************************************

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    int numColumns = matrix.GetLength(1);

    // Проверяем, что номер строки находится в допустимом диапазоне
    if (row >= 0 && row < matrix.GetLength(0))
    {
        for (int j = 0; j < numColumns; j++)
        {
            sum += matrix[row, j];
        }
    }
    else
    {
        // Если номер строки недопустим, можно вернуть, например, -1 или бросить исключение
        // в зависимости от вашего требования.
        // В данном примере вернем -1, чтобы показать, что номер строки недопустим.
        sum = -1;
    }

    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);
    if (numRows == 0 || numColumns == 0)
    {
        // Матрица пуста, возвращаем информацию об ошибке (например, [-1, -1]).
        return new int[] { -1, -1 };
    }

    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;

        for (int j = 0; j < numColumns; j++)
        {
            rowSum += matrix[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }
    return new int[] { minSumRowIndex, minSum };
}

int[,] matrixNew;
if (args.Length == 0)
{
    // Если аргументы не переданы, используем матрицу по умолчанию
    matrixNew = new int[,]
    {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
    };
}
else
{
    // Иначе, парсим аргументы в двумерный массив
    string[] rows = args[0].Split(';');
    matrixNew = new int[rows.Length, rows[0].Split(',').Length];
    for (int i = 0; i < rows.Length; i++)
    {
        string[] elements = rows[i].Split(',');
        for (int j = 0; j < elements.Length; j++)
        {
            if (int.TryParse(elements[j], out int number))
            {
                matrixNew[i, j] = number;
            }
            else
            {
                Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                return;
            }
        }
    }
}

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < matrixNew.GetLength(0); i++)
{
    for (int j = 0; j < matrixNew.GetLength(1); j++)
    {
        Console.Write($"{matrixNew[i, j]}\t");
    }
    Console.WriteLine();
}

int[] minSumRow = MinimumSumRow(matrixNew);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");


//*********************************************************************************************************
// Умножения двух матриц

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки,
// возможно ли умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA
// не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply."
// В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится
// с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB):
// Метод для умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу,
// которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы по умолчанию. 
// Если аргументы переданы, программа парсит их в двумерные массивы целых
// чисел и выполняет умножение матриц.
//*********************************************************************************************************

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    int numColsA = matrixA.GetLength(1);
    int numRowsB = matrixB.GetLength(0);
    // Проверяем, что умножение возможно
    if (numColsA != numRowsB)
    {
        Console.WriteLine("It is impossible to multiply.");
        return;
    }
    // Выполняем умножение матриц и выводим результат
    int[,] result = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix(result);
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int numRowsA = matrixA.GetLength(0);
    int numColsA = matrixA.GetLength(1);
    int numColsB = matrixB.GetLength(1);

    int[,] result = new int[numRowsA, numColsB];

    // Выполняем умножение матриц
    for (int i = 0; i < numRowsA; i++)
    {
        for (int j = 0; j < numColsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < numColsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

public static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

int[,] matrix;

if (args.Length == 0)
{
    // Если аргументы не переданы, используем матрицу по умолчанию
    matrix = new int[,]
    {
                {5, 2},
                {8, 1}
    };
}
else
{
    // Иначе, парсим аргументы в двумерный массив
    string[] rows = args[0].Split(';');
    matrix = new int[rows.Length, rows[0].Split(',').Length];
    for (int i = 0; i < rows.Length; i++)
    {
        string[] elements = rows[i].Split(',');
        for (int j = 0; j < elements.Length; j++)
        {
            if (int.TryParse(elements[j], out int number))
            {
                matrix[i, j] = number;
            }
            else
            {
                Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                return;
            }
        }
    }
}

Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

Console.WriteLine("\nMatrix B:");
PrintMatrix(matrixB);

Console.WriteLine("\nMultiplication result:");

MultiplyIfPossible(matrix, matrixB);
    