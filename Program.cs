// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

internal class Program
{

    public static void Main(string[] args)
    {
        Dictionary<int, string> choices = new Dictionary<int, string>();
        choices.Add(1, "Rock");
        choices.Add(2, "Paper");
        choices.Add(3, "Scissors");

        bool playing = true;
        int userPoints = 0;
        int computerPoints = 0;
        while (playing)
        {
            // Game Logic ...

            Console.WriteLine("Hello, Welcome to Rock, Paper, Scissors Game. Enter your choice below.");
            Console.WriteLine("Press 1 Rock");
            Console.WriteLine("Press 2 Paper");
            Console.WriteLine("Press 3 Scissors");
            int input = int.Parse(Console.ReadLine());


            Random randomChoice = new Random();
            int computerChoice = randomChoice.Next(1, 3);
            char keepPlaying = Console.ReadKey().KeyChar;

            switch (computerChoice)
            {
                case 1:

                    if (input == 1)
                    {
                        Console.WriteLine("User choose Rock");
                        Console.WriteLine("Computer choose Rock");
                        Console.WriteLine("Tie Game");
                    }

                    else if (input == 2)
                    {
                        Console.WriteLine("User choose Paper");
                        Console.WriteLine("Computer choose Rock");
                        Console.WriteLine("Player Wins!");
                        userPoints++;
                    }
                    if (input == 3)
                    {
                        Console.WriteLine("User choose Scissors");
                        Console.WriteLine("Computer choose Rock");
                        Console.WriteLine("Player Losses!");
                        computerPoints++;
                    }
                    break;
                case 2:

                    if (input == 1)
                    {
                        Console.WriteLine("User choose Rock");
                        Console.WriteLine("Computer choose Paper");
                        Console.WriteLine("Player Loses");
                        computerPoints++;
                    }

                    else if (input == 2)
                    {
                        Console.WriteLine("User choose Paper");
                        Console.WriteLine("Computer choose Paper");
                        Console.WriteLine("Tie Game");

                    }
                    if (input == 3)
                    {
                        Console.WriteLine("User choose Scissors");
                        Console.WriteLine("Computer choose Paper");
                        Console.WriteLine("Player Wins!");
                        userPoints++;
                    }
                    break;
                case 3:

                    if (input == 1)
                    {
                        Console.WriteLine("User choose Rock");
                        Console.WriteLine("Computer choose Scissors");
                        Console.WriteLine("Tie Game");
                        userPoints++;
                    }

                    else if (input == 2)
                    {
                        Console.WriteLine("User choose Paper");
                        Console.WriteLine("Computer choose Scissors");
                        Console.WriteLine("Player Wins!");
                        computerPoints++;
                    }
                    if (input == 3)
                    {
                        Console.WriteLine("User choose Scissors");
                        Console.WriteLine("Computer choose Scissors");
                        Console.WriteLine("Tie Game");

                    }
                    break;

            }




            Console.WriteLine("Do you wish to play again?")
            if (keepPlaying == 'n')
            {
                playing = false;
                break;
            }
        }

    }
}