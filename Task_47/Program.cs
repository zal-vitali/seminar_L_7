/* ### Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

* m = 3, n = 4.

* 0,5 7 -2 -0,2
* 1 -3,3 8 -9,9
* 8 7,8 -7,1 9 */

double [,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double randomValue = new Random().NextDouble();
            result[i, j] = Math.Round((maxValue - (maxValue - minValue) * randomValue),2);
        }
    }

    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }

}

Console.Clear();
Console.WriteLine("Задайте размерность массива. Количество строк:");
int countRows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество колонок:");
int countColumns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(countRows,countColumns,-10,10);
PrintArray(array);