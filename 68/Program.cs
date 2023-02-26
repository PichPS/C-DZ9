// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Akerman(int n, int m)
{
    if (n > 0 && m == 0) return Akerman(n - 1, 1);
        if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
        return m + 1;
}

int n = Prompt("введи n: ");
int m = Prompt("введи m: ");
System.Console.WriteLine(Akerman(n, m));
