// // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

/*
Console.WriteLine ("Введите пятизначное число: ");
string num = Console.ReadLine()!;
if (num.Length != 5) 
{
     Console.WriteLine ("Введенное число не пятизначное!");
     return;
}
if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine("Введенное число является полиндромом!");
else Console.WriteLine("Введенное число не является полиндромом!");
*/




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Вариант 1
/*
int[]mas = {3, 6, 8, 2, 1, -7};
int[]mas = {7, -5, 0, 1, -1, 9};
double ras = Math.Sqrt(Math.Pow(mas[0] - mas[3],2) + Math.Pow(mas[1] - mas[4],2) + Math.Pow(mas[2] - mas[5],2));
Console.WriteLine($"Расстояние между точками: {ras:f2}");
*/


// Вариант 2
/*
Console.WriteLine("Введите координату x1 точки A: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y1 точки A: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z1 точки A: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x2 точки B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2 точки B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z2 точки B: ");
int z2 = int.Parse(Console.ReadLine()!);
double ras = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
Console.WriteLine($"Расстояние между точками: {ras:f2}");
*/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i < N + 1; i++)
{
     Console.Write($"{Math.Pow(i,3)} ");
}