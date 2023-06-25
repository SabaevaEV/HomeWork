// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    if (inArray.GetLength(0)==inArray.GetLength(1))
    {
        Console.WriteLine("Матрица квадратна...");
    }
    else
    {
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за столбцы
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    }
}
int [] FindSumRows (int [,] inArray)
{
    int [] sum = new int [inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum [i] += inArray [i,j];
        }
    }
    return sum;
}
void MinSumValue (int [] arr)
{
    int minVal = arr [0];
    int numRow = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr [i] < minVal)
        {
            minVal = arr[i];
            numRow = i;
        }
    }
    Console.WriteLine ($"Строка с наименьшей суммой элементов: {numRow+1}");
}

int minVal = Prompt("Введите начальное значение для диапазона чисел: ");
int maxVal = Prompt("Введите конечное значение для диапазона чисел: ");
int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

int[,] array = GetArray(rows, columns, minVal, maxVal);
PrintArray(array);
Console.WriteLine();
int [] newArray = FindSumRows(array);
MinSumValue (newArray);