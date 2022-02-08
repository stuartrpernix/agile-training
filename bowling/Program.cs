using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial Setup
            Console.WriteLine("Welcome to bowling. Enter the number of players:");
            int numPlayers = Convert.ToInt32(Console.ReadLine());
            string[] players = new string[numPlayers];
            
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Enter the name of player {0}:", i+1);
                players[i] = Console.ReadLine();
            }

            // Frames
            int numFrames = 10;
            int playerScores = new int[numPlayers]; // Stores cumulative scores

            Console.WriteLine("It's time to start bowling!");
            for (int i = 0; i < numFrames; i++) // 10 frames
            {
                Console.WriteLine($"Frame {i + 1}:");
                for (int j = 0; j < 2; j++) // Each frame has 2 deliveries
                {  
                    Console.WriteLine("Delivery {0}", j+1);
                    for (int k = 0; k < numPlayers; k++) // Get each players's result for delivery
                    {
                        Console.WriteLine("Enter " + players[k] + "'s score for delivery {0}:", j);
                        playerScores[k] += Convert.ToInt32(Console.ReadLine());
                    }
                    
                }
            }

            // Results
        }
    }
}