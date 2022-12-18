/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* int Numbers_opposite (int N)
{
    Console.Write($"{N}, ");

    if (N < 2)
    {
        return 1;
    }
    else  return Numbers_opposite(N-1);
}

Console.WriteLine("ВВедите число N:");
int N = Convert.ToInt32(Console.ReadLine());

Numbers_opposite(N); */

//конец задачи
/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
/* 
Console.WriteLine("ВВедите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = M; i <=  N; i++)
{
    result += i;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {result}"); */
//конец задачи

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("ВВедите число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int A(int n, int m)
{
    if (n == 0)  return m+1;
    else
    {
        if ((n != 0) && (m ==0) ) return A(n-1,1);
        else return A(n-1, A(n,m-1));
    }

}
Console.WriteLine($"результат вычисления функции Аккермана для числе n и m: {A(n,m)}");
