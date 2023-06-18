// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear ();

int Prompt (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}
//int random = new Random ().Next (0, 2); // генератор рандомных чисел

void RandomMassive (int number, int minValue, int maxValue)
{
int [] array = new int [number];
for (int i = 0; i < array.Length; i++)
{
array [i] = new Random ().Next (minValue, maxValue);
Console.Write (array [i] + " ");
}
}

int num = Prompt ("Введите размер массива");
int min = Prompt ("Введите начальное значение массива");
int max = Prompt ("Введите конечное значение массива");
RandomMassive (num, min, max);