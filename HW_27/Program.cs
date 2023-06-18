// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumAllDigit(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int num = Prompt("Введите число ");

// int sum = 0;
// while (num > 0)
// {
//     sum = sum + num % 10;
//     num = num / 10;
// }

int sum = SumAllDigit(num);
Console.WriteLine($"Сумма цифр в введенном числе {num} = {sum}");