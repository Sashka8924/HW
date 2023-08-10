// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Enter the number");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the number");
// int Y = Convert.ToInt32(Console.ReadLine());

// if(X > 0 && Y > 0)
// {
//     Console.WriteLine("1");
// }
// else if(X < 0 && Y > 0)
// {
//     Console.WriteLine("2");
// }
// else if(X < 0 && Y < 0)
// {
//     Console.WriteLine("3");
// }
// else if(X < 0 && Y < 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("The point is laying on the axis");
// }


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// 

// Second way of solving the task thanks to "Switch"

// Console.WriteLine("Enter the number");
// int num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.Write("X>0 Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.Write("X<0 Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.Write("X<0 Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.Write("X>0 Y<0");
//         break;
//     }
//     default:
//     {
//         Console.Write("Не подходит");
//         break;
//     }
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Console.Write("Enter number : ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number : ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number : ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double s = Math.Sqrt((Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2)));

// System.Console.WriteLine(s);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Enter number : ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     // double y = Math.Pow(i,2);
//     Console.WriteLine(Math.Pow(i,2));
// }
