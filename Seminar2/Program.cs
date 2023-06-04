// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

// ех, 78 -> 8,  12 -> 2 и т.п.



// int FindFirstDigit (int num)
// {
//     int firstNumber = num / 10; // деление нацело, 78=7, определение первого числа
//     return firstNumber;
// }

// int FindSecondDigit (int num)
//  {
//     int secondNumber = num % 10; // деление на остаток,78=8, определяет второе число
//     return secondNumber;
//  }


// void FindLargestDigit(int num, int firstNumber, int secondNumber)
// {
//     Console.WriteLine("Рандомное число: " + num);
//     Console.WriteLine(firstNumber);
//     Console.WriteLine(secondNumber);

//     if (firstNumber > secondNumber)
//     {
//         Console.WriteLine("Первая цифра больше второй");
//     }
//     else if (secondNumber > firstNumber)
//     {
//         Console.WriteLine("Вторая цифра больше первой");
//     }
//     else
//     {
//         Console.WriteLine("Цифры равны");
//     }
// }

// int number = new Random().Next(10, 100);
// int firstDigit = FindFirstDigit(number);
// int secondDigit = FindSecondDigit(number);
// FindLargestDigit (number, firstDigit, secondDigit);

// int number1 = new Random().Next(100);

// FindLargestDigit (number1, FindFirstDigit(number1), FindSecondDigit(number1));

// int number2 = new Random().Next(-80, 10);


// FindLargestDigit(number);
// FindLargestDigit(number1);
// FindLargestDigit(number2);


//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру
//этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

// int FindFirstDigit ( int num)
// {
//   int firstNumber = num / 100; //определение первого числа  
//   return  firstNumber;
// }
// int FindThirdDigit ( int num)
// {
//   int thirdNumber = num % 10; //определение  числа 
//   return  thirdNumber; 
// }

// int number = new Random().Next(100,1000);
// Console.WriteLine("Рандомное трехзначное число: " + number);
// Console.WriteLine("Полученное число без второй цифры: "+ FindFirstDigit (number) + FindThirdDigit (number));




//Напишите программу, которая будет принимать на вход два числа и выводить, является ли
//второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток
//от деления.

//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

// using System;

// class Program
// {
//     static void Main ()
//     {
//         Console.Write ("Введите первое число: ");
//         int number1 = int.Parse (Console.ReadLine()!);
//         Console.Write ("Введите второе число: ");
//         int number2 = int.Parse (Console.ReadLine()!);

//         if (number2 % number1 == 0)
//         {
//             Console.WriteLine ("Второе число является кратным первому");
//         }
//         else 
//         {
//             int remainder = number2 % number1;
//             Console.WriteLine ("Второе число не кратно первому, остаток деления: " + remainder);
//         }
//     }
// }


void FindDigit (int num1, int num2)
{
// Console.Write ("Введите первое число: ");
// int number1 = int.Parse (Console.ReadLine()!);
// Console.Write ("Введите второе число: ");
// int number2 = int.Parse (Console.ReadLine()!);

if (num2 % num1 == 0)
 {
     Console.WriteLine ("Второе число является кратным первому");
 }
 else 
 {
    int remainder = num2 % num1;
    Console.WriteLine ("Второе число не кратно первому, остаток деления: " + remainder);
}}
Console.Write ("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine()!);
Console.Write ("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine()!);

FindDigit (number1,number2);