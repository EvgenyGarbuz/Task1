// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53 

// int InputN(string message)
// {
// System.Console.Write($»{message}> «);
// int value;
// if (int.TryParse(Console.ReadLine(), out value))
// {
// return value;
// }
// System.Console.WriteLine(«Вы ввели не число»);
// Environment.Exit(1);
// return 0;
// }

// int x1 = InputN («Введите координату X точки A»);
// int y1 = InputN («Введите координату Y точки A»);
// int z1 = InputN («Введите координату Z точки A»);
// int x2 = InputN («Введите координату X точки B»);
// int y2 = InputN («Введите координату Y точки B»);
// int z2 = InputN («Введите координату Z точки B»);

// double dis(int x1, int y1, int z1, int x2, int y2, int z2)
// {
// int deltax = x2 — x1;
// int deltay = y2 — y1;
// int deltaz = z2 — z1;
// return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
// }
// System.Console.Write($»Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2} «);



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int number = ReadInt("Введите число: ");

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i * i * i}, ");
// }

// // Метод
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }