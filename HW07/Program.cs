// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void WeekendDay (int num)
{
 if (num > 0 & num < 6)
 {
    Console.WriteLine ("Это рабочий день недели");
 }
  else if ( num == 6 || num == 7)
  {
    Console.WriteLine ("Выходной!!!");
  }
 else
 {
    Console.WriteLine ("Вы ввели неверное значение, такого дня недели нет");
 }
}

Console.WriteLine ("Ведите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);
WeekendDay (number);
