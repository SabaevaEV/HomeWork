// : Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear ();
string mess = "Введите число: ";
int num = Prompt (mess);
int multi = Multipli (num);
Console.WriteLine ();
Console.WriteLine ($"Произведение всех чисел равн = {multi}" );

int Prompt (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

int Multipli (int number)
{
int mult = 1;
for (int i = 1; i <= number; i++)
{
    mult = mult * i; 
    Console.Write (mult + " " );
}
return mult;
}