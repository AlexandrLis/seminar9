﻿//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Summa (int M, int N)
{   
    if (M > N) return 0;
    return M + Summa(M + 1, N);
}



//------------------------------------------------------

int M = ReadInt("Введите начальное число:");
int N = ReadInt("Введите конечное число:");


if (M < N)
{
    System.Console.WriteLine($"Сумма чисел от {M} до {N} -> {Summa(M, N)}");
}
else
{
    System.Console.WriteLine($"Сумма чисел от {N} до {M} -> {Summa(N, M)}");
}








