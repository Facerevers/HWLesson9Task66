// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSum(int m, int n)
{
    if (n == m) return m;
    else return (m + FindSum(m+1, n));
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число M:");
int n = GetInput("Введите число N:");
int result = (FindSum(m, n));
Console.WriteLine($"{result}");