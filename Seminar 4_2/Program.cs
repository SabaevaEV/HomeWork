// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear ();

int Prompt (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

int CountDigit (int num)
{
  int count = 0;
  while (num != 0)
  {
    num = num / 10;
    count++;
    //Console.WriteLine (num + " ");
    //Console.WriteLine (count + " ");
  }
  return count;
}
int num = Prompt ("Введите число ");
int count = CountDigit (num);
// Console.WriteLine ($"Количество цифр в введенном числе: {CountDigit (num)} ");
Console.WriteLine ($"Колличество цифр в введенном числе: {count}");