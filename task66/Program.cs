/* 
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbers(int m, int n)
{
    if(m <= 0 || n <= 0)
    {
        return -1;
    }
    else //error
    {
    if (m == n) return  n;
        return m + SumNumbers(m + 1, n);
    }
}

Console.WriteLine(SumNumbers(3, 6));
//output 18

