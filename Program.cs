using System;

namespace UserInputKennethEllington
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are delclaring a variable to hold the users input.
            string starWars = "";
            Console.WriteLine("Hello this is Kenneth Ellington");

            //We are creating the prompt for the user.
            Console.WriteLine("Plese enter in your favorite star wars character.\n " +
                "After your finished please hit the enter sign button.");
            //We are setting the users input equal to our variable.
            starWars = Console.ReadLine();

            //We are decalring anc concating this string to desplay towards the user. 
            Console.WriteLine("Your favorite character is " + starWars);


        }
    }
}
