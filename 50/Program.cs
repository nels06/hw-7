// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.

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

Console.Write("Введите искомое число от -100 до 100: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if(!isNumber)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[] result = FindIndexes(array2D, num);
if (result[0] == -1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Индексы: ({result[0]}, {result[1]})");
}




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


int[] FindIndexes(int[,] array, int number)
{
    int[] indexArray = new int[2];
    indexArray[0] = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                indexArray[0] = i;
                indexArray[1] = j;
                return indexArray;
            }
        }
    }
    return indexArray;
}