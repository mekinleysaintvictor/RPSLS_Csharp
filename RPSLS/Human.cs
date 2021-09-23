using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables unique to human players go here
        public Human(string name) //inheriting name from parent
            :base(name)
        {
            this.name = name;
        }
    }
}
