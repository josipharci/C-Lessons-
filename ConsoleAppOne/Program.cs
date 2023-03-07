using System;
// 
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your FirstName");
        String FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your LastName");
        String LastName = Console.ReadLine();

        Console.WriteLine("Hello {0}, {1}", FirstName , LastName);

        //Console.WriteLine("Hello " + UserName);

        Console.ReadLine();
    }
}
