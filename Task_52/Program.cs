/* ### Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
* 1 4 7 2
* 5 9 2 3
* 8 4 2 4

Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] GetColumnAverage(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    double colSum;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        colSum = 0;

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            colSum += inArray[i, j];
        }
        result[j] = Math.Round(colSum / inArray.GetLength(0), 2);
    }

    return result;
}

Console.Clear();
Console.WriteLine("Задайте размерность массива. Количество строк:");
int countRows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество колонок:");
int countColumns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(countRows, countColumns, 0, 10);
PrintArray(array);
Console.WriteLine();

double[] ColumnAverage = GetColumnAverage(array);
Console.WriteLine(String.Join("|", ColumnAverage));