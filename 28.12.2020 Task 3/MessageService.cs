using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2020_Task_3
{
    class MessageService
    {
        public void OnGameRecorded(object o, GameEventArgs args)
        {
            Console.WriteLine($"Printing from MessageService : {args.Game.Name} : {args.Game.Gender}");
        }
    }
}
