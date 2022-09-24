namespace RockPaperScissorsGame
{
    using System;
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            Console.WriteLine("Welcome to the game Rock Paper Scissors!");
            Console.WriteLine();
            Console.Write("When you are ready to play, press [r]: ");
            string readyForGame = Console.ReadLine();
            while(readyForGame != "r")
            {
                Console.Write("Invalid input! Try again: ");
                readyForGame = Console.ReadLine();
            }
            Console.Write("Choose (r)ock, (p)aper, (s)cissors: ");
            string playerInput = Console.ReadLine();
            string playerChoice = string.Empty;
            if(playerInput == "r" || playerInput == "rock")
            {
                playerChoice = rock;
            }
            else if(playerInput == "p" || playerInput == "paper")
            {
                playerChoice = paper;
            }
            else if(playerInput == "s" || playerInput == "scissors")
            {
                playerChoice = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerChoice = string.Empty;
            switch (computerRandomNumber)
            {
                case 1:
                    computerChoice = rock;
                    break;
                case 2:
                    computerChoice = paper;
                    break;
                case 3:
                    computerChoice = scissors;
                    break;
            }
            Console.WriteLine($"The computer chose {computerChoice}");
            if((playerChoice == rock && computerChoice == scissors) || (playerChoice == paper && computerChoice == rock) || (playerChoice == scissors && computerChoice == paper))
            {
                Console.WriteLine("You win.");
            }
            else if((playerChoice == rock && computerChoice == paper) || (playerChoice == paper && computerChoice == scissors) || (playerChoice == scissors && computerChoice == rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game is a draw.");
            }
        }
    }
}
