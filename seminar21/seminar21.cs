//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


Console.WriteLine("Enter a number from 1 to 7:");
int day = Convert.ToInt32(Console.ReadLine());

if(day < 1 || day > 7)
    Console.WriteLine("Error! Enter a number from 1 to 7");
    
if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5) 
    Console.WriteLine("Result: NO");

if(day == 6 || day == 7)
    Console.WriteLine("Result: YES");

