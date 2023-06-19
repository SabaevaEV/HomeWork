// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
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
void FindPositionNum (int [,] arr, int row, int col)
{
    if (row < 0 || row > arr.GetLength(0) || col < 0 || col > arr.GetLength(1))
    {
        Console.WriteLine ($"Элемента заданной позиции в массиве нет");
    }
    else 
    {
        Console.WriteLine ($"Элемента заданной позиции в массиве равен {arr [row-1,col-1]}");
    }
}

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int minVal = Prompt("Введите начальное значение для диапазона чисел: ");
int maxVal = Prompt("Введите конечное значение для диапазона чисел: ");

int[,] array = GetArray(rows, columns, minVal, maxVal);
PrintArray(array);

int num1 = Prompt("Введите строку позиции элемента для проверки: ");
int num2 = Prompt("Введите столбец позиции элемента для проверки: ");

FindPositionNum (array, num1, num2);