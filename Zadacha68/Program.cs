// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
int Akkerman (int m, int n)
{
    System.Console.WriteLine(m + " " + n);
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman (m - 1 , 1);
    else return Akkerman (m - 1, Akkerman (m, n - 1));
}
System.Console.WriteLine(Akkerman (2,2));