﻿
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int square = 0;
int i = 0;
Console.WriteLine("Input n!");
int n = int.Parse(Console.ReadLine());
for(i =1; i<=n ; i++)
{
    square = i*i*i;
    Console.WriteLine(square);
} 
