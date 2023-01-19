using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] dice = new int[11];
            //Welcoming
            Console.WriteLine("Welcome to dice simulator GPT!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            //Converts input into an integer for the num of rolls
            int rollNum = Convert.ToInt32(Console.ReadLine());
            
            string explain = "\nDICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = "+ rollNum + "\n";
            Console.WriteLine(explain);


            //Simulate the roll of 2 dice the inputed number of times
            for (int i = 0; i < rollNum; i++)
            {
                int Die1 = rnd.Next(6);
                int Die2 = rnd.Next(6);
                int Roll = Die1 + Die2;
                dice[Roll]++;
            }


            for (int i = 0; i < 11; i++)
            {
                double percent = (double)dice[i]/(double)rollNum;
                int numStars = Convert.ToInt32(Math.Round((percent*100), 0, MidpointRounding.AwayFromZero));
                //reset output
                string output = "";
                //Converts number into *'s
                 for (int j = 0; j < numStars; j++)
                {
                    output = output + "*";
                }
                
                output = string.Concat(i + 2, ": ", output);
                Console.WriteLine(output);
            }
            Console.WriteLine("\nThank you for using Dice GPT. \nGoodbye!");
        }
    }
}
