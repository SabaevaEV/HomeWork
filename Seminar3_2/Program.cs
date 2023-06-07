// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (х и y)

int Prompt (string message) // метод ввода данных - 1!
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!); // конвертируем данные
    return num;
}
void FindCoordinatePart (int num)
{
    if ( num ==1)
    {
        Console.WriteLine ("Диапазон первой четверти x > 0, y > 0");
    }
    if ( num ==2)
    {
     Console.WriteLine ("Диапазон первой четверти x < 0, y > 0");   
    }
    if ( num ==3)
    {
     Console.WriteLine ("Диапазон первой четверти x < 0, y < 0");   
    }
    if ( num ==4)
    {
     Console.WriteLine ("Диапазон первой четверти x > 0, y < 0");   
    }
    if ( num < 1 || num > 4)
    {
     Console.WriteLine ("Задано неверное значение");   
    }
}

int num = Prompt ("Введите номер четверти: ");
FindCoordinatePart (num);
