using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2020_Task_3
{
     public class Game
    {
        public string Name { get; set; }
        public GameType Gender  { get; set; }

        public  Game(string name, GameType gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
