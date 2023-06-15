// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear ();

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
array [i] = new Random ().Next (0, 100);
Console.Write (array [i] + " ");
}
return array;
}

void PrintSum (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr [i];
        }
    }
    Console.WriteLine ($"Сумма элементов массива с НЕчетным индексом: {sum}");
}


int num = Prompt ("Введите размер массива");
int [] array = RandomMassive (num);
Console.WriteLine ();
PrintSum (array);