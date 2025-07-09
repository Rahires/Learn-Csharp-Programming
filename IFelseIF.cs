//IF else IF conditional statement program
using System;
class IFelseIF
{
    public static void Main(String [] args)
    {
        int Num;
        Console.WriteLine("\nEnter a no...");
        Num=Convert.ToInt32(Console.ReadLine());
        if(Num>0)
        {
            Console.WriteLine("\nPositive...");
        }
        else if(Num<0)
        {
            Console.WriteLine("\nNegative...");
        }
        else
        {
            Console.WriteLine("\nZero...");
        }
    }
}
