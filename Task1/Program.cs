// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
int ReadInt(string message)
{
    System.Console.Write(message);  
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
void PrintEvens(int m, int n)
{
    if (m > n)
    return;
    if (m % 2 == 0)
    {
    Console.Write($"{m} ");
    }
    PrintEvens(m+1,n);
}
PrintEvens(m,n);
System.Console.WriteLine();
