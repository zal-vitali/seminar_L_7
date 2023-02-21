/* ### Задача 50: Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание,что такого элемента нет.

Например, задан массив:
* 1 4 7 2
* 5 9 2 3
* 8 4 2 4

17 -> такого числа в массиве нет */

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

void GetReport(int[,] inArray, int row, int col)
{
    string result;

    if (row - 1 < 0
    || col - 1 < 0
    || row > inArray.GetLength(0)
    || col > inArray.GetLength(1))
        result = ($"Значение с координатами ({row}x{col}) отсутствует");
    else
        result = ($"Значение с координатами ({row}x{col}): {inArray[row - 1, col - 1]}");

    Console.WriteLine(result);
}

Console.Clear();
int[,] array = GetArray(4, 4, -10, 10);
PrintArray(array);
Console.WriteLine("Введите позицию искомого значения: Номер строки (начиная с единицы)");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Номер колонки (начиная с единицы)");
int col = int.Parse(Console.ReadLine()!);
GetReport(array, row, col);
