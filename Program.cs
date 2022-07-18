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
            if (input == 1)
            {
                Console.WriteLine("Rock");
            }

            if (keepPlaying == 'n')
            {
                playing = false;
                break;
            }
        }

    }
}