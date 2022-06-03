// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.WriteLine("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int DigitSum(int number)
{
    if (number == 0) return 0;
    return number % 10 + DigitSum(number/10);
    
}
Console.WriteLine(DigitSum(n));
