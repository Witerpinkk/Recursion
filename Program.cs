
/*Задача 1: Задайте значения M и N. Напишите
программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не
использовать циклы. M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/

using System;

class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + ", ");
            PrintNumbers(m + 1, n);
        }
        else
        {
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int M = 1;
        int N = 5;
        PrintNumbers(M, N);

        M = 4;
        N = 8;
        PrintNumbers(M, N);
    }
}
//------------------------------------------------------------------------------------------------------------------------

/*Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29*/

/*using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main()
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}*/
//----------------------------------------------------------------------------------------------------------------------
/*Задача 3: Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1*/

/*using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        PrintArrayReverse(array, array.Length - 1);
    }
}*/



