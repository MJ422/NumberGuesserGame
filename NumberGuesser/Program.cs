using System;

namespace NumberGuesser
{
    //class is used to create objects of it
    class Program
        
    {
        //entry point for our application
        static void Main(string[] args)
        {
           

            Console.WriteLine("\tHello and Welcome to NumberGuesser! \n\tThe most fun game you can play!\n\n\n");
            Console.WriteLine("What is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("\nHello {0}, let's get to it!", playerName);


            //init the correct number - create the var and set a number as the default
            //int goalNum = 7;
            // init the guess variable

            //goal number is a new Random obect
            while (true)
            {

                Random random = new Random();

                int goalNum = random.Next(1, 20);

                int guess = 0;

            

                Console.WriteLine("\nGuess a number between 1 and 20 - \"Q\" to quit game: ");


                while (guess != goalNum)
                {
                    string playerGuess = Console.ReadLine();


                    if (playerGuess.ToLower().StartsWith("Q".ToLower()))
                    {
                        break;
                    }

                    else if (!int.TryParse(playerGuess, out guess))
                    {
                        //red warning message if user enters non integer or non-"Q"
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect! Please only enter integers");
                        Console.ResetColor();

                    }




                    else if (guess != goalNum)
                    {
                        //red warning message if guess int != goalnum
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect! Please try again");
                        Console.ResetColor();
                    }
                }

                //once the while loop for guess != goalNum 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct! Well done friend");
                Console.ResetColor();

                //now, ask the user if they would like to play again
                Console.WriteLine("Would you like to play again?\n");
                string replayResponse = Console.ReadLine();

                if (replayResponse.ToLower().Contains("Yes".ToLower())
                    || replayResponse.ToLower().StartsWith("Y".ToLower()))
                {
                    continue;

                }
                else if (replayResponse.ToLower().Contains("NO".ToLower())
                    || replayResponse.ToLower().StartsWith("N".ToLower()))
                {
                    return;
                }
                else
                {
                    return;
                }
            }//end while true

                


        }//end main

    }//end program


     

}//end namespace

static void ShowAppInfo()
{
    //app vars init
    String appName = "NumberGuesser"; //important to use double quotes
    String appVers = "1.0.0";
    String appAuthor = "Mike C";


    // change text color
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Application: {0}:\n Version {1} \n Author: {2}\n", appName, appVers, appAuthor);

    // reset the text color after app info printed
    Console.ResetColor();


}


 
