// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!); // метод ввода данных - 1
    return num;
}

void FindThirdDigit (int num)
{
if (num < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdDigit = num % 10;
    Console.WriteLine ("Третья цифра заданного числа " + thirdDigit);
    // Console.WriteLine ($"Третья цифра числа - > {thirdNumber}"); - вариант вывода результата
}
}

int number = Prompt ("Введите число: ");// СМ.выше 1
FindThirdDigit (number);