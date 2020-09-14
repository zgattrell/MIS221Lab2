using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Choice.");
            Console.WriteLine("1.) Rock");
            Console.WriteLine("2.) Paper");
            Console.WriteLine("3.) Scissors");

            // Check inputs
            String response = Console.ReadLine();
            if (response  != "Rock" && response != "Paper" && response != "Scissors"){
                Console.WriteLine("Invalid Play!");
                return;
            }
            Console.WriteLine("User plays " + response);

            //Convert String of play into integer 0=rock, 1=paper,2=scissors
            int responseInt = playToInt(response);

            //Generate Random number 0-2
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next(3);
            Console.WriteLine(number);
            //Check for Tie
            if(responseInt == number){
                Console.WriteLine("Tie try again!");
                return;
            }

            //Compare Random number to user Choice
            Boolean win = comparePlays(number, responseInt);
            
            if(win) Console.WriteLine("Computer Wins!");
            else Console.WriteLine("User Wins!");
            

        }

        static Boolean comparePlays(int compPlay, int userPlay){
            switch (compPlay){

                case 0:
                    Console.WriteLine("Computer plays Rock");
                    if (userPlay == 1) return true;
                    break;
                case 1:
                    Console.WriteLine("Computer plays Paper");
                    if (userPlay == 2) return true;
                    break;
                case 2:
                    Console.WriteLine("Computer plays Scissors");
                    if (userPlay == 0) return true;
                    break;
            }
            return true;
        }

        static int playToInt(String response){
            int responseInt = 0;
            switch (response){
                case "Rock":
                    responseInt = 0;
                    break;
                case "Paper":
                    responseInt = 1;
                    break;
                case "Scissors":
                    responseInt = 2;
                    break;
            }
            return responseInt;
        }
    }
}
