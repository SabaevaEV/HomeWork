// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

// ех, 78 -> 8,  12 -> 2 и т.п.



int FindFirstDigit (int num)
{
    int firstNumber = num / 10; // деление нацело, 78=7, определение первого числа
    return firstNumber;
}

int FindSecondDigit (int num)
 {
    int secondNumber = num % 10; // деление на остаток,78=8, определяет второе число
    return secondNumber;
 }


void FindLargestDigit(int num, int firstNumber, int secondNumber)
{
    Console.WriteLine("Рандомное число: " + num);
    Console.WriteLine(firstNumber);
    Console.WriteLine(secondNumber);

    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первая цифра больше второй");
    }
    else if (secondNumber > firstNumber)
    {
        Console.WriteLine("Вторая цифра больше первой");
    }
    else
    {
        Console.WriteLine("Цифры равны");
    }
}

int number = new Random().Next(10, 100);
int firstDigit = FindFirstDigit(number);
int secondDigit = FindSecondDigit(number);
FindLargestDigit (number, firstDigit, secondDigit);

int number1 = new Random().Next(100);

FindLargestDigit (number1, FindFirstDigit(number1), FindSecondDigit(number1));

int number2 = new Random().Next(-80, 10);


// FindLargestDigit(number);
// FindLargestDigit(number1);
// FindLargestDigit(number2);