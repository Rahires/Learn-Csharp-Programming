//Function program
using System;
class Function
{
    public static void Square(int x)
    {
        Console.WriteLine("\nSquare ="+(x*x));
    }
    public static void Main(String [] args)
    {
        Console.WriteLine("\nEnter a no...");
        int Num=Convert.ToInt32(Console.ReadLine());
        Square(Num);
    }
}
