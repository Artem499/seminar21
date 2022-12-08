//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


Console.WriteLine("Enter a number from 1 to 7:");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 1)
    Console.WriteLine("Error! Enter a number from 1 to 7");
if(day > 7)
    Console.WriteLine("Error! Enter a number from 1 to 7");
if(day == 1) 
    Console.WriteLine("NO");
if(day == 2)    
    Console.WriteLine("NO");
if(day == 3)
    Console.WriteLine("NO");
if(day == 4)
    Console.WriteLine("NO");
if(day == 5)
    Console.WriteLine("NO");
if(day == 6)
    Console.WriteLine("YES");
if(day == 7)
    Console.WriteLine("YES");

