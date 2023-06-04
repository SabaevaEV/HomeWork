// Задача 10 Напишите программу, которая принимает на вход трехзначное число и на выходе
//показывает вторую цифру этого числа

int SecondDigit(int num)
{
  int secondNumber = num / 10 % 10; //определение второго числа
  return secondNumber;
}

void EnterSecondDigit (int num)
{
 if (num < 100 || num > 1000)
{
  Console.WriteLine ("Введено не трехзначное число");
}
else
{
  int result =  SecondDigit(num);
  Console.WriteLine ("Вторая цифра введенного числа: " + result); 
}
}

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
EnterSecondDigit (number);