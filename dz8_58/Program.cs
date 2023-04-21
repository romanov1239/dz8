﻿// Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
using System;
using static System.Console;

Clear();

Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(ReadLine());
Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(ReadLine());
Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(ReadLine());
Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(ReadLine());
if (columnsA != rowsB)
{
    WriteLine("Такие матирицы умножать нельзя!");
    return;
}

int[,] matrA = GetArray(rowsA, columnsA, 0, 10);
int[,] matrB = GetArray(rowsB, columnsB, 0, 10);
PrintArray(matrA);
WriteLine();
PrintArray(matrB);
WriteLine();
WriteLine("Произведение двух матриц: ");
PrintArray(GetMatrixAB(matrA,matrB));



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] GetMatrixAB(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayAB = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayAB[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayAB;
}