// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Enter number : ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number : ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int Z2 = Convert.ToInt32(Console.ReadLine());


// double s = Math.Sqrt((Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2)));

// System.Console.WriteLine(s);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Enter number : ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     // double y = Math.Pow(i,3);
//     Console.WriteLine(Math.Pow(i,3));
// }

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Enter a five-digit number: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - is a palindrom.");
    }
    else
    {
        Console.WriteLine($"{number} - is not a palindrom.");
    }
}
else
{
    Console.Write("Enter a five-digit number: ");
}
