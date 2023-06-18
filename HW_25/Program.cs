// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FindNumberPow(int i, int j)
{
    double x = Math.Pow(i, j);
    Console.WriteLine($"Число А возведенное в степень В равно: {x}");
}

int num1 = Prompt("Введите число А: ");
int num2 = Prompt("Введите число В: ");
FindNumberPow (num1,num2);


