// Задача 10 Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int EnterDigit()
{
Console.WriteLine("Введите трехзначное число ");
int x = int.Parse(Console.ReadLine()!);
return x;
}

int FirstDigit(int x)
{
    int num = x/10;
    return num;
}
 int MiddleDigit (int num)
 {
    int arg = num % 10;
    return arg;
 }

void FindMiddle (int arg)
{
  Console.WriteLine("Вторая цифра введенного Вами числа: " + arg);  
}
int x = EnterDigit();
int num = FirstDigit (x);
int arg = MiddleDigit (num);
FindMiddle(arg);
