// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
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
}
}

int number = Prompt ("Введите число: ");
FindThirdDigit (number);