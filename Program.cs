using System;

namespace Tamagottagettemall
{
    class Program
    {
        public static Boolean quit = false;
        static void Main(string[] args)
        {
            
            

            // show the title screen
            GameManager.ShowTitleScreen();
            
            // start the game
            GameManager.StartGame();

            // main game loop
            while (!quit) {
                // get the command, check if the commands are valid, run command
                GameManager.ShowInfo();
                Console.Write("enter a command: ");
                GameCommands.CheckTheCommand(Console.ReadLine());
            }
        }
    }
}
