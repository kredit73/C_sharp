//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число и нажмите enter");
int a = int.Parse(Console.ReadLine());
int b = a;
int result = 0;
while (b>0)
{   
    result = result + b%10;//присваиваем сумму остатка
    b = b/10;//делим на 10 для следующего
}
Console.WriteLine($"Сумма цифр числа {a} равно {result}");
