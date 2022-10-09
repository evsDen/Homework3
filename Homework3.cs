// // Задача 19
// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int b = 0;
// while (n < 10000 || n > 99999)
// {
//     Console.WriteLine("Вы ошиблись! Введите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// a = n / 100;
// b = (((n%10)*100)+(((n%100)/10)*10)+((n%1000)/100));
// if (a==b)
//      Console.WriteLine("Число является палиндромом");
// else
//     Console.WriteLine("Число не является палиндромом");

// // Задача 21
// Console.Clear();
// Console.Write("Введите первую координату х: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите первую координату у: ");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите первую координату z: ");
// double z = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую координату x: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую координату у: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую координату z: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// double s =(Math.Round(Math.Sqrt(Math.Pow(x1 - x , 2) + Math.Pow(y1 - y , 2)+ Math.Pow(z1 - z, 2)), 3));
// Console.WriteLine($"Расстояние между точками: {s}");

// // Задача 23
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
//     Console.Write($"{i * i * i} ");