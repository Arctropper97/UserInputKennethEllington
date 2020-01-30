using System;

namespace UserInputKennethEllington
{
    class Program
    {
        static void Main(string[] args)
        {
            string starWars = "";
            Console.WriteLine("Hello this is Kenneth Ellington");

            Console.WriteLine("Plese enter in your favorite star wars charcater. \n " +
                "After your finished please hit the enter sign button.");
            starWars = Console.ReadLine();

            Console.WriteLine("Your favorite chacter is " + starWars);


        }
    }
}
