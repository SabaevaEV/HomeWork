// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt (string message) // метод ввода данных - 1!
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine()); // конвертируем данные (для целочисленных данных)
    CheckingValue (num);
    return num;
}

int FindPolindrom (int num)
{
    int n = num ;
    int rev = 0 ;
    do { int r = n % 10;
       rev = rev*10 + r;
       n = n / 10;}
    while (n > 0);
    return rev;
    }

void CheckingValue (int num)
{
    while (num < 10000 || num > 99999)
    {
    Console.WriteLine ("Введено НЕВЕРНОЕ значение");
    num = Prompt ("Повторите ввод пятизначного числа: ");
    }
}

int number = Prompt ("Введите пятизначное число: ");// СМ.выше 1!
CheckingValue (number);
if ( FindPolindrom (number) == number)
    {
        Console.WriteLine ("Число ЯВЛЯЕТСЯ полиндромом");
    }
else 
    {
       Console.WriteLine ("Число НЕ ЯВЛЯЕТСЯ полиндромом"); 
    }