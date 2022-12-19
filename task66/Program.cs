//Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите числа M и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(M,N));
int Sum(int m, int n)
{
    if(m==n)
    {
        return m;
    }
    m++;   
    return m+Sum(m,n);
}

