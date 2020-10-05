using System;

namespace sänkaskepp
{
    class Program
    {
        static void Main(string[] args)
        {
            string right;
            Console.WriteLine("VÄLKOMMEN TILL SÄNKA SKEPP!");
            Console.WriteLine("tryck på någon knapp för att kunna fortsätta");
            right = Console.ReadLine();

            while (right != "6")
            {
                System.Console.WriteLine("Skriv in en koordinat [1-10]");
                right = Console.ReadLine();
                if (right == "6")
                {
                    Console.WriteLine("träff!");
                    System.Console.WriteLine("Du vann!");
                }
                if (right == "1" || right == "2" || right == "3")
                {
                    Console.WriteLine("tyvärr stort miss");
                    Console.WriteLine("försök igen");
                }
                if (right == "4" || right == "5")
                {
                    Console.WriteLine("väldigt nära!");
                    Console.WriteLine("försök igen");
                }
                if (right == "7" || right == "8")
                {
                    Console.WriteLine("väldigt nära men lite för högt siffra");
                    Console.WriteLine("försök igen");

                }
                if (right == "9" || right == "10")
                {
                    Console.WriteLine("tyvärr ett stort miss");
                    Console.WriteLine("försök igen");
                }

                Console.ReadLine();
            }
        }
    }
}




