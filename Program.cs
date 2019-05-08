using System;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            User currentUser = new User();
            Console.WriteLine("Please insert your name: ");
            currentUser.username = Console.ReadLine();
            Console.WriteLine("Now insert a new password!: ");
            currentUser.password = Console.ReadLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Welcome {0} great job!.", currentUser.username);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");


        }
    }
}
