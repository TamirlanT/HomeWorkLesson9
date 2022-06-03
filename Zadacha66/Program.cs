// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int fromNum, int toNum)
{
    if (fromNum == toNum)
        return fromNum;
    else
        return fromNum + Sum(fromNum + 1, toNum);
}
int sum = Sum(m,n);
Console.WriteLine(sum);
