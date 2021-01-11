using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2020_Task_3
{
    class GameRecorder
    {
        public event EventHandler<GameEventArgs> GEA;

        
        public void Record(Game game)
        {
            Console.WriteLine("Recording");
            OnGameRecorded(game);
        }
        public void OnGameRecorded(Game game)
        {
            GEA?.Invoke(this, new GameEventArgs() { Game = game });
        }
    }

   
}
