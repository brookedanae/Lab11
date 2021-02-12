using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();

        }
        private static string GetUserInput()
        {
            string response;
            do
            {
                Console.WriteLine("Welcome to the Movie List Application!" + "\r\n" + "There are 100 movies in this list." + "\r\n" +
              "What category are you interested in?");
                response = Console.ReadLine();
                
            } while (!IsUserInputValid(response));

            return response;
        }
        private static bool IsUserInputValid(string response)
        {
            if (response == "Scifi" || response == "Horror" || response == "Animated" || response == "Drama")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
