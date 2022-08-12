/*
Задача 23.
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
int square = 1;
while (a<= number)
{
    Console.WriteLine(square = a*a*a);
    a = a + 1;
}
