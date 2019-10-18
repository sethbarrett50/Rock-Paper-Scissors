/*
*This is a rock, paper, scissors game built by Seth Barrett on 10/18/19 for Project 2 of Professor Aubert's 1301 class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int cRPS = 0, wins = 0, losses = 0, ties = 0;
            bool flag = false, show = false;
            string comp = "", ans;
            Random myRandom = new Random();
            Console.WriteLine("Welcome!");
            //Here I establish my variables, my random and welcome the user.
            do
            {
                Console.WriteLine("Enter R, P, S or Q to quit:");
                ans = Console.ReadLine();
                //Here I take the user's answer.
                cRPS = myRandom.Next(0, 3);
                //Set computer's RPS value between 0, 1, &2
                switch (cRPS)
                {
                    case (0):
                        comp = "Rock";
                        break;
                    case (1):
                        comp = "Paper";
                        break;
                    case (2):
                        comp = "Scissors";
                        break;
                }
                //Assign a string value to each potential cRPS value;

                switch (ans)
                {
                    case ("q"):
                    case ("Q"):
                        flag = true;
                        Console.WriteLine("Bye!");
                        show = false;
                        break;
                        //If q is entered, Bye! is said, do...while ends and the score and comp's play are not displayed.
                    case ("r"):
                    case ("R"):
                        if (cRPS == 0) ties++;
                        else if (cRPS == 1) losses++;
                        else wins++;
                        show = true;
                        break;
                    case ("p"):
                    case ("P"):
                        if (cRPS == 0) wins++;
                        else if (cRPS == 1) ties++;
                        else losses++;
                        show = true;
                        break;
                    case ("s"):
                    case ("S"):
                        if (cRPS == 0) losses++;
                        else if (cRPS == 1) wins++;
                        else ties++;
                        show = true;
                        break;
                        //For cases r,p&s, finds out wins, losss and ties, and allows display of comp's play and score
                    default:
                        Console.WriteLine("Please enter a valid answer!");
                        show = false;
                        break;
                        //If invalid answer is used, tells user to try again and doesn't show comp's play or score.
                }
                if (show)
                {
                    Console.WriteLine($"The computer played {comp}");
                    Console.WriteLine($"Ties: {ties}, Wins: {wins}, Losses: {losses}");
                    //Only show's computer's play and score if show.
                }
            } while (!flag);
            //Allows program to end when q is entered.
        }
    }
}
