//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29



int ReadInt (string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Function (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n > 0) return Function (m - 1, (Function(m, n - 1)));
    else if (m > 0 && n == 0) return Function(m - 1, n = 1);
    return Function(m,n);
}

bool Check(int m, int n)
{
    if(m < 0 || n < 0)
    {
        System.Console.WriteLine("Введите числа больше или равные нулю");
        return false;
    }
    return true;
}

//----------------------------------------------------------------------------

int m = ReadInt("Введите первое число:");
int n = ReadInt("Введите второе число:");

if(Check(m,n))
{
    int k = Function (m,n);
    System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {k}");
}













































