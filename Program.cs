// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
// Console.Write("Введите координату Х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

// Console.WriteLine(d);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int i = 1;
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// while (i <= N)
// {
//     Console.WriteLine(Math.Pow(i,3));
//      i++; 
// }

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("введите пятизначное число");
// int number = int.Parse(Console.ReadLine());
// int pal = 0, num = number;
// while (number > 0) {pal = pal * 10 + number % 10; number /= 10;}
//  Console.WriteLine(num == pal ? "палиндром" : "не палиндром");

// Console.WriteLine("введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int num1 = number / 10000 % 10;
// int num2 = number / 1000 % 10;
// int rev1 = number / 10 % 10;
// int rev2 = number % 10;
// int nul = number / 10000;
        
// if (nul < 1 || nul > 9)
// {
// Console.WriteLine(number + "Не 5-значный номер");
// }
// else if  (num1 == rev2 && num2 == rev1)
// {
// Console.WriteLine(number + " это палиндром");
// }
// else{
// Console.WriteLine(number + " это НЕ палиндром");
// }



