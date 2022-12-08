//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Input 3 digit integer: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99 & a<1000)
{
   a = a/10%10;
   Console.WriteLine(a);
}
else Console.WriteLine("Was entered not a three-digit number!");


