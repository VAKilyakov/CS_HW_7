/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/* Решение 1
double InputDoubleNum(string message) //ввод вещественных чисел
{    
    Console.Write(message + " ");
    return Convert.ToDouble(Console.ReadLine());
}

int InputInteNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray2D (int Length, int Height) //ввод двумерного массива
{
    double[,] Array2D = new double[Height,Length];
    for (int i=0; i < Height; i++)
    {
        for (int j=0; j<Length; j++)
        {
            Array2D[i,j] = InputDoubleNum("Введите значение массива с индексом [" + i + "," + j + "]");
        }
    }
    return Array2D;
}

void PrintArray2D(double[,] Array2D, int Length, int Height)
{
    Console.Write("Ваш массив:" + Environment.NewLine);

    for(int i=0;i<Height;i++)
    {
        Console.Write("[" + i + "] - ");
        for(int j=0;j<Length;j++)
        {
            Console.Write(Array2D[i,j] + " ");
        }
        Console.Write(Environment.NewLine);
    }
}

int Height = InputInteNum("Введите количество строк в массиве");
int Length = InputInteNum("Введите количество столбцов в массиве");
double[,] Array2D = CreateArray2D(Length,Height);
PrintArray2D(Array2D,Length,Height);
*/

/* Тест 1
PS D:\Home_Works\CS_HW_7> dotnet run
Введите количество строк в массиве 3
Введите количество столбцов в массиве 4
Введите значение массива с индексом [0,0] 0,5
Введите значение массива с индексом [0,1] 7
Введите значение массива с индексом [0,2] -2
Введите значение массива с индексом [0,3] -0,2
Введите значение массива с индексом [1,0] 1
Введите значение массива с индексом [1,1] -3,3
Введите значение массива с индексом [1,2] 8
Введите значение массива с индексом [1,3] -9,9
Введите значение массива с индексом [2,0] 8
Введите значение массива с индексом [2,1] 7,8
Введите значение массива с индексом [2,2] -7,1
Введите значение массива с индексом [2,3] 9
Ваш массив:
[0] - 0,5 7 -2 -0,2
[1] - 1 -3,3 8 -9,9
[2] - 8 7,8 -7,1 9 
*/

/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

/* Решение 2
int InputInteNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D () //генерация двумерного массива
{
    int[,] Array2D = new int[3,4];
    Array2D[0,0] = 1;
    Array2D[0,1] = 4;
    Array2D[0,2] = 7;
    Array2D[0,3] = 2;

    Array2D[1,0] = 5;
    Array2D[1,1] = 9;
    Array2D[1,2] = 2;
    Array2D[1,3] = 3;

    Array2D[2,0] = 8;
    Array2D[2,1] = 4;
    Array2D[2,2] = 2;
    Array2D[2,3] = 4;

    return Array2D;
}

void PrintNumArray2D(int[,] Array2D, int Length, int Height)
{
    if ((Height > 3) || (Length > 4) || (Length<1) || (Height<1))
    {
        Console.Write("Числа с такими индексами в массиве нет");
    }
    else
    {
        Console.Write("Значение ячейки [" + Height + "," + Length + "] равно " + Array2D[Height-1,Length-1]);
    }
}

int Height = InputInteNum("Введите номер строки в массиве");
int Length = InputInteNum("Введите номер столбца в массиве");
int[,] Array2D = GenerateArray2D();
PrintNumArray2D(Array2D,Length,Height);
*/

/*Тест 2
PS D:\Home_Works\CS_HW_7> dotnet run
Введите номер строки в массиве 0
Введите номер столбца в массиве 1
Числа с такими индексами в массиве нет
PS D:\Home_Works\CS_HW_7> dotnet run
Введите номер строки в массиве 1
Введите номер столбца в массиве 7
Числа с такими индексами в массиве нет
PS D:\Home_Works\CS_HW_7> dotnet run
Введите номер строки в массиве 2
Введите номер столбца в массиве 2
Значение ячейки [2,2] равно 9
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/