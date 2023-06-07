// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt (string message) // метод ввода данных - 1!
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!); // конвертируем данные (для целочисленных данных)
    return num;
}

void PrintDegreTable (int num_n)
{int i = 1;
while (i <= num_n)
{
   Console.Write (Math.Pow (i,3) + " "); // возводит в куб
   i++;
}
}

//  void PrintDegreTable (int number)
//  {
//     for (int i = 1; i <= number; i++)    // возведение в куб, другой метод!
//     {
//         Console.Write (Math.Pow (i,3)+ " ");
//     }
//  }

int num = Prompt ("Введите число N: ");// СМ.выше 1!

// Определение числа по модулю !!!
int number = Math.Abs(num);

PrintDegreTable (number);
