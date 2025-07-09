//IF else conditional statement program
using System;
class IFelse
{
    public static void Main(String [] args)
    {
        int Age;
        Console.WriteLine("\nEnter your age..");
        Age=Convert.ToInt32(Console.ReadLine());
        if(Age>=18)
        {
            Console.WriteLine("\nEligible for voting...");
        }
        else
        {
            Console.WriteLine("\nNot eligible for voting....");
        }
    }
}
