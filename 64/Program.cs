// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void GetNum (int num)
{
    if (num  == 0) return;
    else if (num < 0) 
    {
        Console.Write($"{num} не натуральное число");
        return; 
    }
    Console.Write("{0,3}", num);
    GetNum (num - 1);
}

int n = Prompt("введи N: ");
GetNum(n);
