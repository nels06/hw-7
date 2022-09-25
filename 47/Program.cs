// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
bool isNumberRows = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool isNumberColumns = int.TryParse(Console.ReadLine(), out int columns);

if(!isNumberRows || !isNumberColumns || rows < 1 || columns < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

Print2DArray(CreateRandomArray(rows, columns));



double[,] CreateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble()*2-1;      //случайное вещественное число от -1 до 1
        }
    }
    return array;
}


void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}        ");
        }
        Console.WriteLine();
    }
}