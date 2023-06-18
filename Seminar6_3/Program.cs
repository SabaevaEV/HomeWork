// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Prompt(string msg) // ввод данных
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine()!); // return Convert.ToInt32 (Console.ReadLine());
    return number;
}

int BinaryCod(int number)
{
    int res = 0;
    string showres = string.Empty;
    while (number > 0)
    {
        res = number % 2;
        number = number / 2;
        showres = res + showres;
    }
    Console.Write($"{showres}");
    return number;
}

void Convert10To2 (int number)
{
  int res = 0;
    string showres = string.Empty;
    while (number > 0)
    {
        res = number % 2;
        number = number / 2;
        showres = res + showres; // строковая переменная собирает значения / сначала РЕС потом ШОУРЕС
    } 
    //Console.Write($"{showres}");
}

void Convert10To2(int num) // второй вариант, как сделать в одну строку
{
string res1 =Convert.ToString(num,2);
Console.WriteLine(res1);
}


int num = Prompt("Введите число: ");
BinaryCod(num);
Console.WriteLine();
Convert10To2(num);

////////////////////////////////////////////////////////////
int InPutNum(string message) // ввод данных
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

void Convert10To2(int num)
{

string res1 =Convert.ToString(num,2);
Console.WriteLine(res1);

}

int a = InPutNum("Введите число");
Convert10To2 (a);
//////////////////////////////////////////////////////////////////////////////////


// int ReversBinaryCod(int number)
// {
//     int rev = 0;
//     while (number >= 0)
//     {
//         rev = rev * 10 + number % 10; //разворот числа
//         number = number / 10;
//     }
//     return rev;
//     Console.WriteLine($"Введенное в двоичной системе исчисления: {rev}");
// }

// while (num >= 1)
// {
//     if (num % 2 == 0)
//     {
//         Console.Write($"{0}");
//     }
//     else Console.Write($"{1}");
//     num = num / 2;
// }

// int rev = 0;
// while (num > 0)
// {
//     rev = rev * 10 + num % 10;
//     num = num / 10;
// }
