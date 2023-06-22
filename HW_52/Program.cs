// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за столбцы
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverageDigit(double[,] arr)
{
    
    double average = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        average = Math.Round(sum / arr.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно: {average} ");
    }
}

double [,] ConvertMassive (int [,] arr) // перевод массива из int в double
{
    double[,] convertMassive = new double[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength (0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            convertMassive [i,j] = arr [i,j];
        }
    }
    return convertMassive;
}

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int minVal = Prompt("Введите начальное значение для диапазона чисел: ");
int maxVal = Prompt("Введите конечное значение для диапазона чисел: ");

int[,] array = GetArray(rows, columns, minVal, maxVal);
PrintArray(array);

double [,] arrayNew = ConvertMassive (array);
FindAverageDigit (arrayNew);