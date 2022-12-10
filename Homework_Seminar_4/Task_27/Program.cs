//Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
//N: 3 [9, 4, 12] => 2097
//Для проверки можно использовать https://numsys.ru/convert/2097/10/15

void FillArray(int[] zero)
{
    for (int i = 0; i < zero.Length; i++)
    {
        zero[i] = new Random().Next(0, 14);
    }
}

void PrintArray(int[] one)
{
    for (int i = 0; i < one.Length; i++)
    {
        Console.Write(one[i] + " ");
    }
}

Console.WriteLine("Введите количество элементов в массиве:");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
PrintArray(array);
double des = 1;
double res = 0;
int sc = n-1;
for (int i = 0; i < n; i++)
{
    des = array[i] * Math.Pow(15, sc);
    res = res + des;
    sc = sc - 1;
}
System.Console.WriteLine($"Число в 15-ричной системе будет равно {res} в 10-ричной");

