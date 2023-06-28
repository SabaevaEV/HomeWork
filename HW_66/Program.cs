// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SummDigit (int number1, int number2)
{
    if (number1 == number2)
    {
        return number2;
    }
    return number1 + SummDigit (number1+1, number2);
}

int num1 = Prompt ("Введите 1 число ");
int num2 = Prompt ("Введите 2 число ");

Console.WriteLine (SummDigit(num1,num2));