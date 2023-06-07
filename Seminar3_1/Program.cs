// напишите программу, которая на вход принимает координаты точки (Х и Y), причем Х не равен 0
// и Y не равен 0 и выдает номер четверти плоскости, в которой находится эта точка

int Prompt (string message) // метод ввода данных - 1!
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!); // конвертируем данные
    return num;
}

void FindCoordinate (int x, int y)
{
    if (x > 0  && y > 0)
    {
        Console.WriteLine ("Заданная точка расположена в 1 четверти");
    }
    if (x < 0 && y > 0)
    {
     Console.WriteLine ("Заданная точка расположена в 2 четверти");   
    }
    if (x < 0 && y < 0)
    {
     Console.WriteLine ("Заданная точка расположена в 3 четверти");   
    }
    if (x > 0 && y < 0)
    {
     Console.WriteLine ("Заданная точка расположена в 4 четверти");   
    }
}


int x1 = Prompt ("Введите координату Х: ");// СМ.выше 1!
int y1 = Prompt ("Введите координату Y: ");
FindCoordinate (x1,y1);