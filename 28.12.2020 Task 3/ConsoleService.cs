using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2020_Task_3
{
    class ConsoleService
    {
        public void OnGameRecorded(object o, GameEventArgs args)
        {
            Console.WriteLine($"Print details by console : {args.Game.Name} : {args.Game.Gender}");
        }
    }
}
