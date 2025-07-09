//IF Conditional Statement program
using System;
class IF
{
    public static void Main(String [] args)
    {
        String Password;
        Console.WriteLine("\nEnter your password...");
        Password=Console.ReadLine();
        if(Password=="Love")
        {
            Console.WriteLine("\nWelcome....");
        }
        if(Password!="Love")
        {
            Console.WriteLine("\nPlease try again...");
        }
    }
}
