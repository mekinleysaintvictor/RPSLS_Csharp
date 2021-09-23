using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        //member variables that can be used for child (HAS-A)
        protected string gesture;
        protected string name;
        protected int wins;

        public Player() //empty constructor for parent
        {
     
        }
        public Player(string name) //would this only be availible for human ?
        {
            this.name = name;
            Console.WriteLine("Hello my name is {0} and I'm ready to win!", name);
        }

        public string Choice(string choice) //only for human class child to inherit
        {
            Console.WriteLine("What is your choice?");
            choice = Console.ReadLine();
            return choice;
        }

        public void Attack(string choice) //method to check and set gesture for both child classes
        {
            switch (choice)
            {
                case "rock":
                    gesture = "rock";
                    break;
                case "paper":
                    gesture = "paper";
                    break;
                case "scissors":
                    gesture = "scissors";
                    break;
                case "lizard":
                    gesture = "lizard";
                    break;
                case "spock":
                    gesture = "spock";
                    break;
                default:
                    Console.WriteLine("Not a vaild choice"); //how can we reprompt choice?
                    break;

            }
        }


    }
}
