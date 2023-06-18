// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear ();

int Prompt (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

double [] RandomMassive (int number)
{
double [] array = new double [number];
for (int i = 0; i < array.Length; i++)
{
array [i] = new Random ().Next ( 0, 10000)/100.00; // new Random ().NextDouble ()*100
Console.Write (array [i] + " ");
}
return array;
}

void FindDiff (double [] arr)
{
int i = 0;
double maxNumber = arr [i];
double minNumber = arr [i];

while ( i < arr.Length)
{
    if ( arr [i] > maxNumber)
    {
        maxNumber = arr [i];
    }
    if ( arr [i] < minNumber)
    {
        minNumber = arr [i];
    }
    i++;
}
double diff = maxNumber - minNumber;
Console.WriteLine ($"Разница между максимальным и минимальным элементом массива равна: {diff}");
}


int num = Prompt ("Введите размер массива");
double [] array = RandomMassive (num);
Console.WriteLine ();
FindDiff (array);