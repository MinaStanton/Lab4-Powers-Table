//Mina Stanton
//January 23, 2020
//Program Description: This program will take in a number by the user and output a table 
//with the squared and cubed of every number until that user number.

using System;

namespace Lab4_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //informing user about what the program does
            Console.WriteLine("Hello and welcome to Powers Table.");

            //variable created for continuous loop
            string userContinue = "y";

            do
            {
                //prompt user to input a number
                Console.WriteLine("Please enter a number: ");

                //input from user and setting up the table
                int userNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nNumber\tSquared\tCubed");
                Console.WriteLine("====== \t====== \t======");

                //calling the method and sending the user number to it
                PrintPowersTable(userNumber);

               //prompting user to continue
                Console.WriteLine("\nWould you like to go again? (y/n)");
                userContinue = Console.ReadLine().ToLower();

                //validation check if user did not input correct response
                while(userContinue != "y" && userContinue != "n")
                {
                     Console.WriteLine("\nSorry, I didn't catch that! Would you like to go again? (y/n)");
                     userContinue = Console.ReadLine().ToLower();
                }
                
                //if user does not want to continue then exit the loop
                if(userContinue == "n")
                {
                    break;
                }

            }
            while (userContinue == "y");

            Console.WriteLine("\nThanks for playing, bye!");
        }
        //method that calls a method to square the user number and a method to cube a user number then print the result
        public static void PrintPowersTable(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"  {i} \t  {SquareNumber(i)}  \t  {CubeNumber(i)}");
            }
        }
        //method to square a number
        public static double SquareNumber(int num)
        {
            return Math.Pow(num, 2);
        }
        //method to cube a number
        public static double CubeNumber(int num)
        {
            return Math.Pow(num, 3);
        }
    }
}
