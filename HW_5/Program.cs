// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// int countEven = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + " ");

//     if (array[i] % 2 == 0) // 
//     {
//         countEven++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Number of even elements: " + countEven++);


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Write("Enter the amont of elements in the array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// for(int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-100, 101);
//     Console.Write(array[i] + " ");
// }

// int sumUnpair = 0;

// for (int i = 0; i < size; i+=2)
// {
//     sumUnpair += array[i];
// }
// Console.WriteLine(" ");
// Console.WriteLine($"Sum of unpair elements of the array equal to {sumUnpair}");


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.Write("Enter the amont of elements in the array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// double [] array = new double [size];

// for ( int i = 0; i < size; i++)
// {
//     array[i] = Convert.ToDouble(new Random().Next(0, 1000)) / 100; 
//     Console.Write(array[i] + " ");
// }

// double max = array.Max();
// double min = array.Min();

// Console.WriteLine($"Max value from the array = {max}, min value = {min}");
// Console.WriteLine($"The difference between max/min values = {max - min}");
