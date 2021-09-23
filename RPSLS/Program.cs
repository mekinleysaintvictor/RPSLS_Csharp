using System;
using System.Collections.Generic;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            Console.WriteLine("What option do you choose?");

            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }

            //instantiate human player
            Human player1 = new Human("MeKinley");
            //instantiate robot player

            //human player make move

            //robot make move

            //compare moves

            //declare winner
        }
    }
}
