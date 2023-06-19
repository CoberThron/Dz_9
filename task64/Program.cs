// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int digit1 = Promt("введите число: ");
int Promt(string message)
{
    System.Console.Write(message);
    string num = System.Console.ReadLine()!;
    if ((int.TryParse(num, out int num_n)) == false) 
    {
    Console.WriteLine("Это не число!");
    }

    return num_n;
}
void NumbersFromNto1(int n)
{
    if (n==1)
    {
        System.Console.WriteLine("1");
        
    }
    else
    {
        System.Console.WriteLine($"{n}");
        NumbersFromNto1(n-1);
    }
       
}
NumbersFromNto1(digit1);