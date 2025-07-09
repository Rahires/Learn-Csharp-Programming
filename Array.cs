//Array program
using System;
class Array
{
    public static void Main(String [] args)
    {
    int [] Numbers=new int [5];
    Console.WriteLine("\nEnter 5 numbers....");
    for(int x=0; x<=4; x++)
    {
        Numbers[x]=Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("\nGiven 5 no...");
    for(int x=0; x<=4; x++)
    {
        Console.WriteLine("\n"+(Numbers[x]));
    }
    }
}
