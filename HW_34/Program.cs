// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

int [] RandomMassive (int number)
{
int [] array = new int [number];
for (int i = 0; i < array.Length; i++)
{
array [i] = new Random ().Next (100, 1000);
Console.Write (array [i] + " ");
}
return array;
}
// int [] GetArray (int size, int minValue, int maxValue) // метод генерации массива
// {
//     int [] res = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         res [i] = new Random().Next(minValue, maxValue + 1);  // [a,b)
//         Console.Write ($" {res [i]} ");
//     }
//     return res;
// }

void FindCount (int [] arr)
{
int count = 0;
foreach (int el in arr)
{
    if (el%2 ==0)
    {
        count +=1;
    }
}
Console.WriteLine ($"Количество четных чисел в массиве: {count}");
}

int num = Prompt ("Введите размер массива");
int [] array = RandomMassive (num);
Console.WriteLine ();
FindCount (array);