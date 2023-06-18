// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


double b1 = Prompt("Введите значение b1 для прямой заданной уравнением y = k1 * x + b1");
double k1 = Prompt("Введите значение k1 для прямой заданной уравнением y = k1 * x + b1");
double b2 = Prompt("Введите значение b2 для прямой заданной уравнением y = k2 * x + b2");
double k2 = Prompt("Введите значение k2 для прямой заданной уравнением y = k2 * x + b2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine();
Console.WriteLine($"Точка пересечения заданных прямых имеет координаты {x};{y}");