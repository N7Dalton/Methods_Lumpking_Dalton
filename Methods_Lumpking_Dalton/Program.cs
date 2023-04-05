using System;

namespace Methods_Lumpking_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("would you like to find a new number(n) or come into my house?(h)");
            string twoOptions = Console.ReadLine();
            if (twoOptions == "n")
            {
                Numbers();
            }
            if (twoOptions == "h")
            {
                enterHouse();
            }

            void enterHouse()
            {
                Console.WriteLine("Whats your name??");
                string name = Console.ReadLine();
                Console.WriteLine($"Welcome {name} to my lovely home!");
                Console.WriteLine("now go away.");
            }
            void Numbers()
            {
                Console.WriteLine("whats your age");
                int Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("whats your fav number?");
                int favNum = Convert.ToInt32(Console.ReadLine());
                int multipliedNum = Age * favNum;
                Console.WriteLine($"your new lucky number is....{multipliedNum}!! now get out of my coffee shop.");
            }
           
        }
    }
}
