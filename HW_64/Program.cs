// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void NaturalNumber(int number, int count)
{
    if (count <= number)
    {
        Console.Write($"{number} ");
        NaturalNumber(number-1, count);
    }
}

int number = Prompt("ВВедите число: ");
int i = 1;
NaturalNumber(number, i);