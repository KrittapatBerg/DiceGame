using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRndNum;
            int RndNumAI;

            int playerPoint = 0;
            int AIPoint = 0; 
            
            Random rnd= new Random();
      
            for (int i = 0; i < 10; i++)   //initializer section; condition section; interator section i++ i increase by one everytime it go through the loop
            {
                 Console.WriteLine("Press ENTER to roll the dice... ");
                 Console.ReadKey();
                    //Console.Clear(); 

                 playerRndNum = rnd.Next(1, 7);  //random number between 1 and 7 
                 Console.WriteLine($"You rolled a  {playerRndNum}");

                 Console.WriteLine("...");
                 System.Threading.Thread.Sleep(1000);
                
                 RndNumAI = rnd.Next(1, 7);   //random number for the programs turn
                 Console.WriteLine($"AI rolled a  {RndNumAI}");

                 if (playerRndNum > RndNumAI)
                 {
                     playerPoint++;
                     Console.WriteLine($"You win this round!");
                 }
                 else if (playerRndNum < RndNumAI)
                 {
                     AIPoint++;
                     Console.WriteLine($"AI win this round! ");
                 }
                 else Console.WriteLine("It's a draw!");
                 
                Console.WriteLine($" The score is now: Player {playerPoint}. AI {AIPoint}. ");
                Console.WriteLine();

                if (playerPoint > AIPoint) Console.WriteLine("You win!! ");
                else if (playerPoint < AIPoint) Console.WriteLine("You lose...");
                else Console.WriteLine("It's a draw! ");
  
            }
        }
    }
}
