/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, columns);
Console.WriteLine();
PrintArray(arr);
SortArray(arr);
Console.WriteLine();
PrintArray(SortArray(arr));


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 20);
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }return array;
}
 
 /*int[,] SortArray(int[,] array){
    int j = 0;
    int i = 0;

    while(i < array.GetLength(0)){
        for (int p = 0; p < array.GetLength(1);){
        if(array[i, j] < array[ i, j +1]){
            int k = array[i, j];
            array[i, j ] = array[i, j + 1];
            array[i, j+ 1]= k;
            
            }
        }i++;
    }return array;
}*/

     /*int[] row = new int[arr.GetLength(1)];
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         for (int j = 0; j < arr.GetLength(1); j++){
             row[j] = arr[i, j];}
        
         if(row[j] > row[j+1])
         int tmp = row[j];
         row[j] = row[j+1];
         row[j+1] = tmp;

         //BubbleSort(row);
         //Insert(true, i, row, arr);
     }*/
 


/*int[,] SortArray(int[,] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1) -1 ; j++){
            inArray[i, j] = inArray[i, j] + inArr44
*/
//решение преподователя
/*﻿// Написать программу, которая упорядочивает по убыванию 
//элементы каждой строки двумерного массива.
using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
WriteLine();
PrintArray(array);


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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}*/