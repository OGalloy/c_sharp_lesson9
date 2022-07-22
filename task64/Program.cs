/*Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/
//
string PrintNumbers(int m, int n)
{   
    if (m <= 0 || n <=0)
    {
       return "Один или более аргументов не являются натуральными числами"; 
    }
    else
    {
        if (m == n) return n.ToString();
        return m.ToString() + PrintNumbers(m+1, n);
    }
}

Console.WriteLine(PrintNumbers(5, 15));