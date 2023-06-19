// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Promt(string message)
{
    System.Console.WriteLine(message);
    string num = System.Console.ReadLine()!;
    if ((int.TryParse(num, out int num_n)) == false)
    {
        Console.WriteLine("Это не число!");
    }

    return num_n;
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
int digit1 = Promt("введите 1-е число: ");
int digit2 = Promt("введите 2-е число: ");
int result = Ackermann(digit1, digit2);
Console.WriteLine($"Результат функции Аккермана для чисел {digit1} и {digit2} равен: {result}");
