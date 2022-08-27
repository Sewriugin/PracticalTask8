// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//     Урок 8. Как не нужно писать код. Часть 2
//----------------------------------------------------
// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумертного массива.

Console.WriteLine("Задача 54");
int[,] createArray(int n, int m)
{
    return new int[n, m];
}

void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void printArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m,n] + " ");
        }
        Console.WriteLine();
    }
}

void sortingRow(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j > i; j--)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x + 1])
                {
                    temp = array[i, x];
                    array[i, x] = array[i, x + 1];
                    array[i, x + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}

int[,] arr54 = createArray(3,4);// вызов метода createArray
fillArray(arr54);// вызов метода fillArray
printArray(arr54);// вызов метода printArray
sortingRow(arr54);// вызов метода сортировки двумерного массив по убыванию элементы каждой строки
printArray(arr54);// вызов метода printArray
Console.WriteLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задача 56");

int[,] createArray56(int n, int m)
{
    return new int[n, m];
}

void fillArray56(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
}

void printArray56(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m,n] + " ");
        }
        Console.WriteLine();
    }
}

void minRowSum56(int[,] array)
{
    
    int count = 0;
    int minSum = int.MaxValue;
    for (int n = 0; n < array.GetLength(0); n++)
    {
        int sum = 0;
        for (int m = 0; m < array.GetLength(1); m++)
        {
           sum = sum + array[n,m];
        }
        Console.WriteLine("sum row " + n + " = " + sum);
        if (sum < minSum)
        {
            minSum = sum;
            count = n; 
        }
    }
    Console.WriteLine("Cтрока " + count + " с наименьшей суммой элементо: " + minSum);
    Console.WriteLine();
}

int[,] arr56 = createArray56(3,4);// вызов метода createArray
fillArray56(arr56);// вызов метода fillArray
printArray56(arr56);// вызов метода printArray
minRowSum56(arr56);// вызов метода minRowSum (наименьшей суммой элементов)
Console.WriteLine();

// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

Console.WriteLine("Задача 58");

int[,] createArray58(int n, int m)
{
    return new int[n, m];
}

void fillArray58(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
}

void printArray58(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m,n] + " ");
        }
        Console.WriteLine();
    }
}

void matrixMultiply(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int x = 0; x < array2.GetLength(1); x++)
            {
                array3[i, j] += array1[i,x] * array2[x,j];
            }
            Console.Write(array3[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] arr58matrix1 = createArray58(3,3);// вызов метода createArray
int[,] arr58matrix2 = createArray58(3,3);
int[,] arr58matrix3 = createArray58(3,3);
fillArray58(arr58matrix1);// вызов метода fillArray
fillArray58(arr58matrix2);
printArray58(arr58matrix1);// вызов метода printArray
Console.WriteLine();
printArray58(arr58matrix2);
Console.WriteLine();
matrixMultiply(arr58matrix1, arr58matrix2, arr58matrix3);// умножение двух матриц и получение результата в 3 матрице
Console.WriteLine();

