﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());
        PrintNaturalNumbers(M, N);
    }
    static void PrintNaturalNumbers(int M, int N)
    {
        if (M > N)
            return;

        Console.WriteLine(M);
        PrintNaturalNumbers(M + 1, N);
    }
}