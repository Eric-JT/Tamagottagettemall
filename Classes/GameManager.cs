using System;

namespace Tamagottagettemall
{
    class GameManager
    {
        private static int m_iMoveCount = 0; // used to keep track of days

        /* Get set move count */
        public static int iMoveCount
        {
            get { return m_iMoveCount; }
            set { m_iMoveCount = value; }
        }

        public static void MoveCount(){
            GameManager.iMoveCount += 1;
        }

        public static void ShowTitleScreen()
        {
            Console.Clear();
            Console.WriteLine("My T-rex Marty");
            Console.WriteLine("\nType 'help' at any time to see a list of commands");
            Console.WriteLine("You must take care of your pet t-rex.");
            Console.WriteLine("\nPress a key to begin");

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.Clear();
        }

        public static void StartGame()
        {
            // bring the pet to life
            Game.InitializePetRoom();
            Player.GetCurrentRoom().DescribePetRoom();
            
        }

        public static void ShowInfo()
        {
            // display pets happy, sleep, and hunger level. display your move count
            Console.WriteLine("\n\nMarty");
            Console.WriteLine("-----");
            Console.WriteLine("Happiness: {0}\nSleepiness: {1}\nHunger: {2}\nMove Count: {3}",Pet.iHappiness, Pet.iSleepiness, Pet.iHunger, GameManager.m_iMoveCount);
        }

        public static void EndGame(string endingText)
        {
            // quit the while loop by changing quit to true
            Program.quit = true;

            // clear console
            Console.Clear();

            // display ending message
            Console.WriteLine("Game is over");
            Console.Write("\nYou may now close this window.");
            Console.CursorVisible = false;

            
        }

        public static void Rules(){
            // set the rules for the game
            int count = GameManager.iMoveCount;
            if (count % 2 == 0 && count != 0) {
                // if count is even and not 0 it becomes a new day
                // marty should sleep
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("It is time for Wally's nap.");
                Console.WriteLine("Wally is played out, you should put him to sleep and play with him again tomorrow.");
            }
            if (Pet.iHunger == 20) {
                // if hunger is 20, marty dies
                // game over
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("Oopsy, Looks like Wally starved to death.");
                Console.WriteLine("Well you killed your pet t-rex... ");
                Console.WriteLine("Goobye.");
                Program.quit = true;
            }
            if (Pet.iSleepiness == 20) {
                // if sleep is 20, marty kills you
                // game over
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("You haven't let wally sleep for a long time.");
                Console.WriteLine("Wally passed out...");
                Console.WriteLine("... the next day ...");
                Console.WriteLine("Wally awoke in an rage and bit your head off.");
                Console.WriteLine("Game Over!");
                Program.quit = true;
            }
            if (Pet.iHappiness == 0) {
                // if happy is 0, marty kills you
                // game over
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("From the look in Wally's eyes you can see he is bored of you..");
                Console.WriteLine("You haven't showed your pet t-rex as much attention as it would have liked.");
                Console.WriteLine("You head just got bit off");
                Console.WriteLine("Goodbye.");
                Program.quit = true;
            }
            if (Pet.iHappiness == 3){
                // warning to play with marty
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("You better show your pet some love.");
                Console.WriteLine("Something bad might happen if you don't play with Wally.");
            }
            if (Pet.iHunger == 17){
                // warning to feed marty
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("You better feed your pet.");
                Console.WriteLine("Something bad might happen if you don't feed Wally.");
            }
            if (Pet.iSleepiness == 17){
                // warning to put marty to sleep
                Console.Clear();
                GameManager.ShowInfo();
                Console.WriteLine("You better let your pet sleep.");
                Console.WriteLine("Something bad might happen if you don't put Wally to sleep.");
            }
        }
    }
}