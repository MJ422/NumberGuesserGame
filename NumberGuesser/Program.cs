using System;

namespace NumberGuesser
{
    //class is used to create objects of it
    class Program
        
    {
        //entry point for our application
        static void Main(string[] args)
        {
            ShowAppInfo();
            GreetUser();

            while (true)
            {
                //init random object
                Random random = new Random();

                //goal number is a new Random obect
                int goalNum = random.Next(1, 20);
                //guess will be parsed from user entry string, init at zero
                int guess = 0;            

                //Prompt user for entry
                Console.WriteLine("\nGuess a number between 1 and 20 - \"Q\" to quit game: ");

                //while 
                while (guess != goalNum)
                {
                    string playerGuess = Console.ReadLine();

                    if (playerGuess.ToLower().StartsWith("Q".ToLower()))
                    {
                        //breaks from the game if user enters quit sentinel
                        break;
                    }

                    else if (!int.TryParse(playerGuess, out guess))
                    {
                        //red warning message if user enters non integer or non-"Q"
                        PrintAlertMessage(ConsoleColor.Red, "Incorrect! Please try again");

                    }

                    else if (guess != goalNum)
                    {
                        //red warning message if user enters wrong integer 
                        PrintAlertMessage(ConsoleColor.Red, "Incorrect! Please try again");
                    }
                }

                //once the while loop for guess != goalNum 
                PrintAlertMessage(ConsoleColor.Green, "Correct! Well done friend");

                //now, ask the user if they would like to play again
                Console.WriteLine("\n\t\tWould you like to play again?\n");
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



        static void ShowAppInfo()
        {
            //app vars init
            String appName = "NumberGuesser"; //important to use double quotes
            String appVers = "1.0.0";
            String appAuthor = "Mike C";


            PrintAlertMessage(ConsoleColor.DarkYellow, (appName + "\n" +appVers + " \nAuthor: " + appAuthor));


        }//end show app info ftn



        static void GreetUser()
        {
            Console.WriteLine("\tHello and Welcome to NumberGuesser! \n\tThe most fun game you can play!\n\n\n");
            Console.WriteLine("What is your name?");

            string playerName = Console.ReadLine();

            PrintAlertMessage(ConsoleColor.Green, "Hello " +playerName +", let's guess a number!\n");


        }//end greetuser ftn

        static void PrintAlertMessage(ConsoleColor alertColor, string message)
        {
            //**primary function used to print in a certain consolecolor (p1) and the string message to print (p2)
            //parameter field inits
            Console.ForegroundColor = alertColor;
            String messageToPrint = message;

            //write message to the program
            Console.WriteLine(messageToPrint);
            //resets foreground color
            Console.ResetColor();
        }



    }//end program

    


}//end namespace




 
