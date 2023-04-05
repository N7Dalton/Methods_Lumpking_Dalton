using System;

namespace Methods_Lumpking_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks them the question
            Console.WriteLine("would you like to find a new number(n) or come into my house?(h)");
            //sets twoOptions to what they say
            string twoOptions = Console.ReadLine();
            //checks if they answered N or H
            if (twoOptions == "n")
            {
                Numbers();
            }
            if (twoOptions == "h")
            {
                EnterHouse();
            }
            //this is the method
            void EnterHouse()
            {
                //asks name
                Console.WriteLine("Whats your name??");
                //declares name
                string name = Console.ReadLine();
                Console.WriteLine($"Welcome {name} to my lovely home!");
                Console.WriteLine("now go away.");
            }
            void Numbers()
            {
                //asks for age
                Console.WriteLine("whats your age");
                //declares age
                int Age = Convert.ToInt32(Console.ReadLine());
                //asks for their fav number
                Console.WriteLine("whats your fav number?");
                //declares favNum
                int favNum = Convert.ToInt32(Console.ReadLine());
                //does sum dumb math crap
                int multipliedNum = Age * favNum;
                //tells them to get out of the coffee shop
                Console.WriteLine($"your new lucky number is....{multipliedNum}!! now get out of my coffee shop.");
            }
           
        }
    }
}
