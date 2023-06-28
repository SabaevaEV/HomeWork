// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int AkkermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n > 0 && m == 0)
    {
        return AkkermanFunction(n - 1, 1);
    }
    return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

int num1 = Prompt("Введите 1 число: ");
int num2 = Prompt("Введите 2 число: ");

if (num1 < 0 || num2 < 0) Console.WriteLine ("Введены отрицательные значения");
else Console.WriteLine (AkkermanFunction(num1, num2));