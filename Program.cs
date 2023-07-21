//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = InputInt("Input a positive number: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Wrong number");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
    {
    return n;
    }
    else
    {    
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
        return m;
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
