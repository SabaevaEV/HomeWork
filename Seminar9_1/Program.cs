// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int Prompt(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }

// void NaturalNumber(int number, int count)
// {
//     if (count <= number)
//     {
//         Console.Write($"{count} ");
//         NaturalNumber(number,count+1);
//     }
// }

// int number = Prompt("ВВедите число: ");
// int i = 1;
// NaturalNumber(number,i);


Console.Clear();

int number = Prompt("Введите число: ");
Console.WriteLine(PrintNumber(number));

int Prompt(string message)
{
Console.Write(message);
int number = int.Parse(Console.ReadLine()!);
return number;
}

string PrintNumber(int number)
{
if (number == 1) return "1";

return $"{PrintNumber(number - 1)} {number}";// правильный порядок чисел сохраняется
}                                            // потому что PrintNumber(number - 1) стоит перед
                                             // {number} поэтому вычисляемое число
                                             // выходит перед введенным