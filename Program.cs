// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    public static void Main(string[] args)
    {

        bool playing = true;
        while (playing)
        {
            // Game Logic ...

            Console.WriteLine("Hello, Welcome to Rock, Paper, Scissors Game. Enter your choice below.");
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.ReadLine();

            Random randomChoice = new Random();
            string keepPlaying = Console.ReadKey();
            if (keepPlaying == 'n')
            {
                playing = false;
            }
            playing = true;
        }

    }
}