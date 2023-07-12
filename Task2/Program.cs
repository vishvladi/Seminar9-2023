// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.WriteLine(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}
int ReadInt(string message)
{
    System.Console.Write(message);  
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
SumFromMToN(m, n);
