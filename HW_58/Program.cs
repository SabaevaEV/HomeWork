// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] MultiplicationMatrix (int [,] arr1, int [,] arr2)
{
    int [,] result = new int [arr1.GetLength(0),arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result [i,j] += arr1[i,k]*arr2[k,j]; //A00*C00 + B01*C01
                                                      // = arr1[00]*arr2[00] + arr1[01]*arr2[10]
            }
        }
    }
    return result;
}

int[,] array1 = GetArray(2, 2, 0, 10);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(2, 2, 0, 10);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Результат перемножения матриц: ");
int [,] result = MultiplicationMatrix (array1, array2);
PrintArray(result);