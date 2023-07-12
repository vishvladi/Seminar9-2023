// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void PrintAkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
    System.Console.WriteLine();
}
int ReadInt(string message)
{
    System.Console.Write(message);  
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
PrintAkkermanFunction(m,n);