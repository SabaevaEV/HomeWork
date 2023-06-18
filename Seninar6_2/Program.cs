// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void ChekTriangel(int x, int y, int z)
{
    if (x + y > z && x + z > y && y + z > x)
       { Console.WriteLine("Треугольник с такими сторонами может существовать");}
    else Console.WriteLine("Треугольник с такими сторонами НЕ существует");
}

int a = Prompt("Введите длину 1 стороны треугольника");
int b = Prompt("Введите длину 2 стороны треугольника");
int c = Prompt("Введите длину 3 стороны треугольника");
ChekTriangel(a, b, c);

// if (a + b > c && a + c > b && b + c > a)
// Console.WriteLine("Треугольник с такими сторонами может существовать");
// else Console.WriteLine("Треугольник с такими сторонами НЕ существует");
