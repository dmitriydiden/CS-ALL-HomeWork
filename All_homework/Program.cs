// Домашняя работа №1.

// Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number1 - ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Input number2 - ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Max number = ");
    Console.WriteLine(number1);

    Console.Write("Min number = ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Max number = ");
    Console.WriteLine(number2);

    Console.Write("Min number = ");
    Console.WriteLine(number1);
}

// Задача №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input number1 - ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Input number2 - ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Input number3 - ");
int number3 = int.Parse(Console.ReadLine());

int Max = number1;

if (number1 > Max) Max = number1;
if (number2 > Max) Max = number2;
if (number3 > Max) Max = number3;

Console.Write("Max number = ");
Console.WriteLine(Max);

// Задача №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number - ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"{number} - чётное число");
}
else
{
    Console.Write($"{number} - нечётное число");
}

// Задача №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number - ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Все чётные числа ряда от 1 до {number}:");
while (number>1)
{
    if (number%2==0)
    {
        Console.Write($"{number} ");
    }
    else
    {
        number = number -1;
        Console.Write($"{number} ");
    }
    number = number - 2;
}

// Домашняя работа №2.

// Задача №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int number = new Random().Next(100, 1000);
string numS = number.ToString();
int a1 = Convert.ToInt32(numS[1].ToString());
Console.WriteLine($"{number} -> {a1}");


// Задача № б/н Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.Clear();
int number = new Random().Next(100, 1000);
string numS = number.ToString();
int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[2].ToString());
Console.WriteLine($"{number} -> {a1}{a2}");

// Задача №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Вариант 1 С помощью массива
Console.Clear();
int number = new Random().Next(10, 1000);
if (number / 100 == 0)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    string numS = number.ToString();
    int a1 = Convert.ToInt32(numS[2].ToString());
    Console.WriteLine($"{number} -> {a1}");
}

//Вариант 2 Математический
Console.Clear();
int number = new Random().Next(10, 1000);

if (number / 100 == 0)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    int a1 = number % 10;
    Console.WriteLine($"{number} -> {a1}");
}

// Задача №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите пожалуйста порядковый номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());
while ((daynumber == 0) | (daynumber > 7))
{
    Console.WriteLine("Вы неправильно ввели номер дня недели");
    Console.Write("Введите пожалуйста порядковый номер дня недели: ");
    daynumber = int.Parse(Console.ReadLine());
}
if (daynumber == 1) Console.WriteLine($"{daynumber} -> Понедельник - будний день.");
if (daynumber == 2) Console.WriteLine($"{daynumber} -> Вторник - будний день.");
if (daynumber == 3) Console.WriteLine($"{daynumber} -> Среда - будний день.");
if (daynumber == 4) Console.WriteLine($"{daynumber} -> Четверг - будний день.");
if (daynumber == 5) Console.WriteLine($"{daynumber} -> Пятница - будний день.");
if (daynumber == 6) Console.WriteLine($"{daynumber} -> Суббота - Ура, выходний!");
if (daynumber == 7) Console.WriteLine($"{daynumber} -> Воскресенье - Ура, выходний!");


// Домашняя работа №3.

/* Задача №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();

int number = new Random().Next(10000, 100000);
string array = number.ToString();
int a1 = Convert.ToInt32(array[0].ToString());
int a2 = Convert.ToInt32(array[1].ToString());
int a4 = Convert.ToInt32(array[3].ToString());
int a5 = Convert.ToInt32(array[4].ToString());
if ((a1 == a5) && (a2 == a4)) 
{
Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine($"{number} -> Нет");
}

/* Задача №21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");


/* Задача №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();

Console.Write("Input number - ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
Console.Write($"{number} -> ");
for (int i=1; i<=number ; i++)
{
    int cubednumber = i*i*i;
    Console.Write($"{cubednumber} ");
}


// Домашняя работа №4.

/* Задача №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

using System;
Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int degree = 1;
for(int i=1; i<= B; i++)
{
    degree = degree * A;
}
Console.WriteLine($"{A}, {B} -> {degree}");


/* Задача №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
using System;
Console.Clear();
int[] array = new int[8];
for(int i=0; i<=7; i++)
{
    array[i]=new Random().Next(0, 100);
}
Console.Write(string.Join(", ", array));
Console.Write(" -> ");
Console.WriteLine("[{0}]", string.Join(", ", array));

//Вариант 2. С помощью метода.
using System;
Console.Clear();
int L = 8;
int[] array1 = array(L);
Console.Write(string.Join(", ", array1));
Console.Write(" -> ");
Console.WriteLine("[{0}]", string.Join(", ", array1));

int[] array(int Length)
{
    int[] arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
    
}

/* Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Вариант 1. С помощью метода.
using System;
Console.Clear();
Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {sum(number)}");
int sum(int num)
{
    string numm = number.ToString();
    int summa = 0;
    for(int i=0; i<numm.Length; i++)
    {
        summa = summa + Convert.ToInt32(numm[i].ToString());
    }
    return summa;
}

// Вариант 2. С помощью цикла.
using System;
Console.Clear();
Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
string array = number.ToString();

int Sum = 0;

for (int i = 0; i < array.Length; i++)
{
    Sum = Sum + Convert.ToInt32(array[i].ToString());
}
Console.WriteLine($"{number} -> {Sum}");


// Домашняя работа №5.

/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;
Console.Clear();
int length = 7;
int[] array =new int[length].Select(x=>x=new Random().Next(100, 1000)).ToArray();
int k=0;
for (int i = 0; i < length; i++)
{
    if (array[i]%2 == 0) k++;
}
Console.Write("[{0}]", string.Join(", ", array));
Console.Write($" -> {k}");

/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;
using System.Linq;
Console.Clear();

int length = 7;
int[] array = new int[length].Select(x=>x=new Random().Next(-100, 100)).ToArray();
Console.Write("[{0}]", string.Join(", ", array));
Console.WriteLine($" - > {sum(length)}");

int sum(int num)
{
    num=0;
    for (int i = 1; i < length; i=i+2)
    {
        num += array[i];
    }
    return num;
}

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76
*/

using System;
using System.Linq;
Console.Clear();

int length = 7;
double[] array = new double[length].Select(x => x = new Random().Next(0, 100)).ToArray();
Console.Write("[{0}]", string.Join(" ", array));
Console.WriteLine($" -> {diff(length)}");

double diff(double x)
{
    double max = 0;
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];                             
    }
    x= max-min;
    return x;
}

// Домашняя работа №6.

/* SЗадача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using System;
using System.Linq;
Console.Clear();

int length = 5;
int[] array = new int[length];
int count = 0;
for (int i = 0; i < length; i++)
{
    Console.Write($"Введите число А{i + 1} = ");
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0) count++;
}

Console.Write(string.Join(", ", array));
Console.WriteLine($" -> {count}");


/* Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.Write("Введите значение b1 - ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k1 - ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2 - ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2 - ");
double k2 = double.Parse(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ( {x}, {y} )");


// Домашняя работа №7.

/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;
Console.Clear();

double[,] NewArray = GetRandomArray(3,4, -10.0, 10.0);
PrintArray(NewArray);

double[,] GetRandomArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] =minValue+ new Random().NextDouble()*2*maxValue;
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4:F1} ", array[i,j]);
        }
        Console.WriteLine();
    }
}

/* Задача №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
 значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

using System;
Console.Clear();
Console.Write("Введите номер строки в которой находится искомый элемент N - ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца в котором находится искомый элемент M - ");
int M = int.Parse(Console.ReadLine());

int[,] NewArray = GetRandomArray(4, 4, 1, 10);
PrintArray(NewArray);
SearchElement(NewArray, N, M);


int[,] GetRandomArray(int rows, int columns, int minVolue, int maxVolue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minVolue, maxVolue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] array, int n, int m)
{
    if (n >= array.GetLength(0) || m >= array.GetLength(1))
    {
        Console.WriteLine($"{n}{m} -> такого элемента в массиве нет!");
    }
    else Console.WriteLine($"{array[n, m]}");
}

/* Задача №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;
Console.Clear();

int[,] NewArray = GetRandomArray(4, 4, 1, 10);
PrintArray(NewArray);
Console.Write("Среднее арифметическое каждого столбца:");
AverageColumns(NewArray);

int[,] GetRandomArray(int rows, int columns, int minVolue, int maxVolue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minVolue, maxVolue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double AverageColumns(int[,] array)
{
    double average = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        //average=Convert.ToDouble(sum/array.GetLength(0));
        average=array.GetLength(0) !=0 ? (double)sum/array.GetLength(0) : 0;
        Console.Write("{0,4:F1};", average);
    }
    return average;
}

// Домашняя работа №8.

/* Задача №54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

using System;
Console.Clear();
Console.Write("Введите количество строк в массиве n - ");
int n= int.Parse(Console.ReadLine());
Console.Write("Введите количество строк в массиве m - ");
int m= int.Parse(Console.ReadLine());
int[,] NewArray = GetArray(n, m, 0, 10);
PrintArray(NewArray);
Console.WriteLine();
NewArray = SortArray(NewArray);
PrintArray(NewArray);

int[,] SortArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    int result = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = result;
                }
            }
        }

    }
    return array;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

/* Задача №56 Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;
Console.Clear();
Console.Write("Введите количество строк в массиве n - ");
int n= int.Parse(Console.ReadLine());
Console.Write("Введите количество строк в массиве m - ");
int m= int.Parse(Console.ReadLine());
int[,] NewArray = GetArray(n, m, 0, 10);
PrintArray(NewArray);
Console.WriteLine();
MinSumArray(NewArray);

void MinSumArray(int[,] array)
{
    int row = 0; int minsum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minsum += array[i, j];
        }
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {row} строке");
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

using System;
Console.Clear();
Console.Write("Введите количество строк в массиве n - ");
int n= int.Parse(Console.ReadLine());
Console.Write("Введите количество строк в массиве m - ");
int m= int.Parse(Console.ReadLine());
int[,] NewArray1 = GetArray(n, m, 0, 10);
PrintArray(NewArray1);
Console.WriteLine();
int[,] NewArray2 = GetArray(n, m, 0, 10);
PrintArray(NewArray2);
Console.WriteLine();
Console.WriteLine("Их произведение будет равно следующему массиву:");
Console.WriteLine();
int[,] ResultArray = ProductArray(NewArray1, NewArray2, n, m);
PrintArray(ResultArray);

int[,] ProductArray(int[,] array1, int[,] array2, int rows, int columns)
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j]=array1[i,j]*array2[i,j];
        }
        
    }
    return resultArray;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

/*Задача №60. Сформируйте трёхмерный массив из неповторяющихся
 двузначных чисел. Напишите программу, которая будет построчно 
 выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

using System;
Console.Clear();
Console.Write("Введите длину трехмерного массива x - ");
int x= int.Parse(Console.ReadLine());
Console.Write("Введите длину трехмерного массива y - ");
int y= int.Parse(Console.ReadLine());
Console.Write("Введите длину трехмерного массива z - ");
int z= int.Parse(Console.ReadLine());
int[,,] NewArray = GetArray(x, y, z, 10, 99);
PrintArray(NewArray);


int[,,] GetArray(int leng, int breadth, int depth, int minValue, int maxValue)
{
    int[,,] array = new int[leng, breadth, depth];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Домашняя работа №9.

/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/

using System;
using static System.Console;
Clear();
Write("Введите число М - ");
int M=int.Parse(ReadLine());
Write("Введите число N - ");
int N=int.Parse(ReadLine());

string result=GetNumbers(M,N);
WriteLine(result);

/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;
Clear();
Write("Введите число М - ");
int M=int.Parse(ReadLine());
Write("Введите число N - ");
int N=int.Parse(ReadLine());

int result=SumNumbers(M,N);
WriteLine(result);


static int SumNumbers(int start, int end)
{
    if (start>end) return 0;
    return start+SumNumbers(start+1, end);
}

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

using System;
using static System.Console;
Clear();
int res = A(3,2);
WriteLine(res);

static int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}


static string GetNumbers(int start, int end)
{
    if (start==end) return start.ToString();
    return(end+" "+GetNumbers(start, end-1));

}
