// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());
if((num<=10) & (num >=10000));
  
    int a = num % 10 ; int c = num / 10;
    int b = (num % 100) ; int d = (num / 100) ;
   
    
   if(a == c && b == d)
{
    Console.WriteLine($"  палиндром");
} 
else
{
    Console.WriteLine( $" не палиндром");
    }
Console.WriteLine($"{num>=10000} не пятизначное");