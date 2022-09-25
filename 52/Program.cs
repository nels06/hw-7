// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
bool isNumberRows = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool isNumberColumns = int.TryParse(Console.ReadLine(), out int columns);

if(!isNumberRows || !isNumberColumns || rows < 1 || columns < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[,] array2D = CreateRandomArray(rows, columns);
Print2DArray(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(FindArithmeticAverage(array2D));



int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 101);      //случайное целое число от -100 до 100
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}     ");
        }
        Console.WriteLine();
    }
}


double[] FindArithmeticAverage(int[,] array)
{
    double[] arrayAA = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arrayAA[j] = Convert.ToDouble(sum) / array.GetLength(0);
    }
    return arrayAA;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]};  ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}