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
            Console.WriteLine("Welcome to bowling. Enter the number of players:");
            int numPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numPlayers);
        }
    }
}