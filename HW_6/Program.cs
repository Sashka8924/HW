// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Enter the amount of numbers:");
int amount = Convert.ToInt32(Console.ReadLine());
if (amount <=0)
{
    Console.WriteLine("Please, enter the number greater than 0: ");
}

int[] array = new int[amount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter {i+1} a number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
}

int count = 0;

for (int i = 0; i < array.Length; i++);
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("There are " + count + "positive numbers.");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)