//*********************************************************************************************************
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n
//  (размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную
//   и максимальную границы случайных чисел.
// Также, задайте метод PrintArray, который выводил бы массив на экран.
// Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j]
//  с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы.
//  Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.
//*********************************************************************************************************


static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] randArr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randArr[i, j] = Math.Round((new Random().NextDouble()) * (maxLimitRandom + 0.001 - minLimitRandom) + minLimitRandom, 1);
        }
    }
    return randArr;
}

static void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;

      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }

//*********************************************************************************************************
// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray,
// FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает 
// на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенерированную матрицу
// и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition
// и числа x и y - позиции элемента в матрице. Метод должен проверить,
// был ли найден элемент в матрице по указанным координатам (x и y),
// используя результаты из метода FindNumberByPosition. Если такого элемента нет,
// вывести на экран "There is no such index". Если элемент есть,
// вывести на экран "The number in [{x}, {y}] is {значение}".
//*********************************************************************************************************

static void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

static int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int value = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = value;
            value += k;
        }
    }
    return matrix;
}

static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);

    if (rowPosition >= 1 && rowPosition <= numRows && columnPosition >= 1 && columnPosition <= numColumns)
    {
        int[] result = new int[2];
        result[0] = matrix[rowPosition - 1, columnPosition - 1]; // Вычитаем 1, так как координаты начинаются с 1
        result[1] = 0; // Операция успешно выполнена без ошибок
        return result;
    }
    else
    {
        int[] result = new int[1];
        result[0] = 0; // Возвращаем массив с нулевым значением, так как указанные координаты находятся за пределами границ матрицы
        return result;
    }
}

static void PrintCheckIfError(int[] results, int X, int Y)
{
    if (results.Length == 1 && results[0] == 0)
    {
        Console.WriteLine("There is no such index");
    }
    else if (results.Length == 2)
    {
        int value = results[0];
        Console.WriteLine($"The number in [{X}, {Y}] is {value}");
    }
}
int n, m, k, x, y;

if (args.Length >= 5)
{
    n = int.Parse(args[0]);
    m = int.Parse(args[1]);
    k = int.Parse(args[2]);
    x = int.Parse(args[3]);
    y = int.Parse(args[4]);
}
else
{
    // Здесь вы можете поменять значения для отправки кода на Выполнение
    n = 3;
    m = 4;
    k = 2;
    x = 2;
    y = 3;
}

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);


//*********************************************************************************************************
// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход
// три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое 
// увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает
// одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом
// столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns
// и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...",
// где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой
// (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), 
// разделенные знаком табуляции.
//*********************************************************************************************************

static void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

static int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int value = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = value;
            value += k;
        }
    }
    return matrix;
}

static void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        string formattedValue = list[i].ToString("F2"); // Округляем до двух знаков после запятой
        Console.Write(formattedValue);
        if (i < list.Length - 1)
        {
            Console.Write("\t");
        }
    }
    Console.WriteLine();
}

static double[] FindAverageInColumns(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);
    double[] averages = new double[numCols];
    for (int col = 0; col < numCols; col++)
    {
        int sum = 0;
        for (int row = 0; row < numRows; row++)
        {
            sum += matrix[row, col];
        }
        averages[col] = (double)sum / numRows;
    }
    return averages;
}

int n, m, k;

if (args.Length >= 3)
{
    n = int.Parse(args[0]);
    m = int.Parse(args[1]);
    k = int.Parse(args[2]);
}
else
{
    // Здесь вы можете поменять значения для отправки кода на Выполнение
    n = 3;
    m = 4;
    k = 2;
}

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
