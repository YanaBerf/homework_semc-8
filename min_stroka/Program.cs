/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] arr = GetArray(rows, columns, 0, 9);
PrintArray(arr);
int[] array = GetMeanColumns(arr);
Console.Write($"Сумма каждой строки = {String.Join("; ",array)}");
Console.WriteLine();
Console.WriteLine($"Строка c наименьшей суммой {FindMinRow(array)} является минимальной");

int[] GetMeanColumns(int [,] inArray)
{   
    int[] result = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j< inArray.GetLength(1); j++){
            sum += inArray[i,j];
        }   
            result[i] = sum;
    }return result;
}
int FindMinRow(int[] array){
    int minimum = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] < minimum) 
        minimum = array[i];
        
    } return minimum;
}
/*Console.Write($"Среднее арифметическое каждой строки = {String.Join("; ",array)}");

double[] GetMeanColumns(int [,] inArray)
{   
    double[] result = new double[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++){
        double sum = 0;
        for (int j = 0; j< inArray.GetLength(1); j++){
            sum += inArray[i,j];
        }   
            result[i]= Math.Round(sum/inArray.GetLength(1),2);
    }return result;
}*/

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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
