// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int digit1 = Promt("введите 1-е число: ");
int digit2 = Promt("введите 2-е число: ");
int result = SumElementMtoN(digit1, digit2);
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
int SumElementMtoN(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumElementMtoN(m + 1, n);
    }
    
}
System.Console.WriteLine($" суммма чисел от {digit1} до {digit2} равна: {result}");