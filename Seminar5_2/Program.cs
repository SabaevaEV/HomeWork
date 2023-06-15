// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] Massiv (int size, int minValue, int maxValue) // метод генерации массива
{
    int [] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);  // [a,b)
        Console.Write ($" {res [i]} ");
    }
    return res;
}

// void ChangeNum (int [] arr)
// {
//     foreach (int el in arr) // пока el будет в массиве array будет выполняться действие 
//    {
//     Console.Write ($" {el*(-1)} ");
//    }
   
// }
void ChangeNum (int [] arr)
{
    int i = 0;
    foreach (int el in arr) 
   {
    arr [i] = el*(-1);
    Console.Write ($" {arr [i]} ");
    i++;
    
   }
   
}

int[] array = Massiv (8, -4, 4);
Console.WriteLine ();
ChangeNum (array);


