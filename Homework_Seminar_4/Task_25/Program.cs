//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

//2, 4 -> 16

//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow
Console.WriteLine("Input A!");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input B!");
int b = int.Parse(Console.ReadLine());

int result = a;

for(int i = 1; i < b; i++)
{
    result = result*a;
    
} 
Console.WriteLine($"А в степени B равно =  {result}");