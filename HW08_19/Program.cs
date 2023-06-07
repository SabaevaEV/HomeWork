// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt (string message) // метод ввода данных - 1!
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!); // конвертируем данные (для целочисленных данных)
    return num;
}

void FindPolindrom (int num)
{
    int x = num ;
    int rev = 0;
    while (x < )
    { int r = x % 10;
      rev = rev*10 + r;
      x = x / 10;
      return (rev = num);
    }
    if (num = rev)
    {
        Console.WriteLine ("Число является полиндромом");
    }
    else 
    {
       Console.WriteLine ("Число не является полиндромом"); 
    }
}

int number = Prompt ("Введите пятизначное число: ");// СМ.выше 1!
FindPolindrom (number);
