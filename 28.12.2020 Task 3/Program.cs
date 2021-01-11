using System;
using System.Collections.Generic;

namespace _28._12._2020_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRecorder gameRecorder = new GameRecorder();
            Game game = new Game("Pubg Mobile", GameType.Shooter);
            
            MessageService messageService = new MessageService();
            MailService mailService = new MailService();
            ConsoleService consoleService = new ConsoleService();

            gameRecorder.GEA += messageService.OnGameRecorded;
            gameRecorder.GEA += mailService.OnGameRecorded;
            gameRecorder.GEA += consoleService.OnGameRecorded;
            gameRecorder.Record(game);
        }
    }
}
