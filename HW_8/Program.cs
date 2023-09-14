// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Enter the number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of columns");
// int n = Convert.ToInt32(Console.ReadLine());

// Random rand = new Random();

// int[,] matrixBeforeSort = new int[m, n]; 
// int[,] matrixAfterSort = new int[m, n];
// int[] sort = new int[n]; 

// int[,] FillArray(int[,] arr) 
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++) 
//     {
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             arr[rows, columns] = rand.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] arr) 
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             Console.Write(arr[rows, columns] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SortArray(int[,] arr)
// {
//     for (int rows = 0; rows < matrixBeforeSort.GetLength(0); rows++)
//     {
//         for (int columns1 = 0; columns1 < matrixBeforeSort.GetLength(1); columns1++)
//             sort[columns1] = arr[rows, columns1];
//         Array.Sort(sort);
//         Array.Reverse(sort);
//         for (int columns2 = 0; columns2 < matrixBeforeSort.GetLength(1); columns2++)
//         {
//             arr[rows, columns2] = sort[columns2];
//         }
//     }
//     return arr;
// }

// Console.WriteLine("Before sort");
// PrintArray(FillArray(matrixBeforeSort));
// matrixAfterSort = matrixBeforeSort;
// Console.WriteLine("After sort");
// PrintArray(SortArray(matrixAfterSort));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Enter the number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of columns");
// int n = Convert.ToInt32(Console.ReadLine());

// Random rand = new Random();

// int[,] matrix = new int[m, n];

// int[,] FillArray(int[,] arr)  
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             arr[rows, columns] = rand.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] arr) 
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             Console.Write(arr[rows, columns] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int MinSumInRow(int[,] arr) 
// {
//     int[] HelpArray = new int[arr.GetLength(0)]; 
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         int sum = 0;
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             sum = sum + arr[rows, columns];
//         }
//         HelpArray[rows] = sum;
//     }
//     int min = HelpArray.Min();
//     int outRow = Array.IndexOf(HelpArray, min);
//     return outRow;
// }

// PrintArray(FillArray(matrix));

// Console.WriteLine("Min sum of the elements in a row is " + (MinSumInRow(matrix) + 1));


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] RandomArray(int[,,] arr)
// {
//     int count = 1;
//     for (int rows1 = 0; rows1 < arr.GetLength(0); rows1++)
//     {
//         for (int columns1 = 0; columns1 < arr.GetLength(1); columns1++)
//         {
//             for (int field1 = 0; field1 < arr.GetLength(2); field1++)
//             {
//                 arr[rows1, columns1, field1] = 10 * count;
//                 count++;
//             }
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,,] arr)
// {
//     for (int rows2 = 0; rows2 < arr.GetLength(0); rows2++)
//     {
//         for (int columns2 = 0; columns2 < arr.GetLength(1); columns2++)
//         {
//             Console.WriteLine();
//             for (int field2 = 0; field2 < arr.GetLength(2); field2++)
//             {
//                 Console.Write($"{arr[rows2, columns2, field2]}({rows2},{columns2},{field2}) ");
//             }
//         }
//     }
// }

// int[,,] myArray = new int[2, 2, 2];
// PrintArray(RandomArray(myArray));


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] FillArray(int[,] array)
// {
//     int SizeX = array.GetUpperBound(0);
//     int SizeY = array.GetUpperBound(1);
//     int maxX = SizeX + 1;
//     int maxY = SizeY;
//     int dirX = 1;
//     int dirY = 1;

//     int x = -1;
//     int y = 0;
//     int val = 1;
//     while ((maxX >= 0) && (maxY >= 0))
//     {
//         for (int xval = 1; xval <= maxX; xval++)
//         {
//             array[x + dirX * xval, y] = val;
//             val++;
//         }

//         x = x + dirX * maxX;
//         dirX = -dirX;
//         maxX--;

//         for (int yval = 1; yval <= maxY; yval++)
//         {
//             array[x, y + dirY * yval] = val;
//             val++;
//         }

//         y = y + dirY * maxY;
//         dirY = -dirY;
//         maxY--;
//     }

//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             Console.Write(arr[rows, columns] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CoilArray = new int[4, 4];
// PrintArray(FillArray(CoilArray));