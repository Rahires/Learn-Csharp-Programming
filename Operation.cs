//All arithmetic operation program
using System;
class Operation
{
    public static void Main(String [] args)
    {
        int Num1,Num2;
        Console.WriteLine("\nEnter 2 numbers....");
        Num1=Convert.ToInt32(Console.ReadLine());
        Num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nAdd ="+(Num1+Num2));
        Console.WriteLine("\nSub ="+(Num1-Num2));
        Console.WriteLine("\nMulti ="+(Num1*Num2));
        Console.WriteLine("\nDiv ="+(Num1/Num2));
    }
}
