// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Enter number : ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int GetPow()
// {
    
//     int result = 1;

//     for (int i = 0; i < num2; i++)
//     {
//         result *= num1;
//     }
    
//     return result;
// }
// Console.WriteLine(GetPow());


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum()
{
    int result = 0;  
    int len = 0;
    while (num > 0)
    {
        len = num % 10;
        result += len;
        num /= 10;
    }
    return result;
}
Console.WriteLine(GetSum());

// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] array = new int[8];
// GetArray();

// void GetArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,100);
//         Console.Write(array[i]+" ");
//     }
// }