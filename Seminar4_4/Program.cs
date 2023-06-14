// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear ();

int Prompt (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}
//int random = new Random ().Next (0, 2); // генератор рандомных чисел

void RandomMassive (int number)
{
int [] array = new int [number];
for (int i = 0; i < array.Length; i++)
{
array [i] = new Random ().Next (0, 2);
Console.Write (array [i] + " ");
}
}
int num = Prompt ("Введите размер массива");
RandomMassive (num);