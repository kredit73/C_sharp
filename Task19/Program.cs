// Программа проверяет пятизначное число на палиндромом
Console.WriteLine("Input integer: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>9999 & n<100000)
{
    int a = n/10000;
    int b = n%10;
    int c = (n/1000)%10;
    int d = (n%100)/10;
    if (a == b && c == d)
    {
        Console.WriteLine("Integer is Palindrome! ");
    }
    else Console.WriteLine("Integer is not Palindrome! ");

}
else Console.WriteLine("Was entered not a five-digit number!");
