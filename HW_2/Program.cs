// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1 = num / 10;
// int num2 = num1 % 10;

// Console.WriteLine(num2);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10,40000);
// Console.WriteLine(num);

// if ((100 < num)&&(num < 999))
// { 
//     int num1 = num % 10;
//     Console.WriteLine(num1);  
// }
// else if ((1000 < num)&&(num < 9999))
// {
//     int num2 = num / 10;
//     int num3 = num2 % 10;
//     Console.WriteLine(num3);
// }
// else if ((10000 < num)&&(num < 40000))
// {
//     int num4 = num / 100;
//     int num5 = num4 % 10;
//     Console.WriteLine(num5);
// }
// else 
// {
//     Console.WriteLine("There is less than three numbers"); 
// }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int num = new Random().Next(1,7);
// Console.WriteLine(num);

// if((num==6) || (num==7))
// {
//     Console.WriteLine("Weekend");
// }
// else
// {
//     Console.WriteLine("Weekday");
// }
