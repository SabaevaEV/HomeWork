// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Prompt (string message) // метод ввода данных - 1!
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!); // конвертируем данные (для целочисленных данных)
    return num;
}

void FindDistance (int x1, int y1, int x2, int y2)
{
double d = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
Console.WriteLine ("Расстояние между точками: "+ d);
}

int x1 = Prompt ("Введите координату Х точки А: ");// СМ.выше 1!
int y1 = Prompt ("Введите координату Y точки А: ");

int x2 = Prompt ("Введите координату Х точки В: ");// СМ.выше 1!
int y2 = Prompt ("Введите координату Y точки В: ");

FindDistance (x1,y1,x2,y2);