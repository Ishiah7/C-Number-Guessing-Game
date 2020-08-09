using System;


namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call User Greeting Method

            UserGreeting();

            // Get User Number

            int userNumber = GetUserNumber();

            // Generate Random Number

            int rn = GenerateNumber();

            // Tracks The Chances The User Took To Answer

            int chancesTracker = 1;

            // Loop Runs Until User Guesses The Correct Number

            while (true)
            {
                if (userNumber == rn)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Guessed Correctly!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Guessed The Wrong Number!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Try Again: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    chancesTracker++;
                    userNumber = GetUserNumber();
                }
            }

            // End Screen Method Called

            EndScreen(chancesTracker);
        }

        // Method For Generating Random Number
        private static int GenerateNumber()
        {
            Random rn = new Random();
            int randomNumberGenerated = rn.Next(0, 11);
            return randomNumberGenerated;
        }


        // Method For Handling User Greeting
        private static void UserGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome To Number Guessing Game ");
        }


        // Method For Handling End Message To User
        private static void EndScreen(int score)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations, It Took You {0} Chances!", score);
            Console.WriteLine("Thanks For Playing :)");
            Console.ForegroundColor = ConsoleColor.White;
        }


        // Method For Handling User Input
        private static int GetUserNumber()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|Guess Number Between 0 - 10: ");
            while (true)
            {
                String user_input = Console.ReadLine();
                int user_number;

                bool isNumber = Int32.TryParse(user_input, out user_number);

                if (isNumber){
                    if (user_number >= 0 && user_number <= 10)
                    {
                        return user_number;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Number Must Be Between 0 - 10!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Guess Number Between 0 - 10: ");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter A Number!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|Guess Number Between 0 - 10: ");
                }
            }
        }
    }
}
