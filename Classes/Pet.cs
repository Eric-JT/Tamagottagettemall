using System;


namespace Tamagottagettemall
{
    class Pet
    {
        // Variables for the pets sleep, hunger, happy, name
        private static int m_iSleepiness = 5;
        private static int m_iHappiness = 5;
        private static int m_iHunger = 5;
        private static string m_sName = "Marty";

      

        /* get and set parameters */
        public static int iSleepiness
        {
            get { return m_iSleepiness; }
        }

        public static int iHappiness 
        {
            get { return m_iHappiness; }
        }

        public static int iHunger 
        {
            get { return m_iHunger; }
        }

       

        // sleep
        public static void Sleep()
        {
            // no input, no return type
            // decrease sleep
            // write message to the console
            m_iSleepiness -= 2;

            if (m_iSleepiness < 0) {
                // stop sleep from going below 0
                m_iSleepiness = 0;
            }
            Console.WriteLine("{0} has slept!", m_sName);
        }

        // eat
        public static void Eat(string item)
        {
            if (item == "") {
                // if no argument is passed through, set a default
                item = "french fries";
            }else {
                //  if argument was passedthrough, drop item
                Player.DropItem(item);
                Console.Clear();
            }
            // no input, no return type
            // decrease hunger
            // write message to the console
            m_iHunger -= 2;
            if (m_iHunger < 0) {
                // stop unger from going below 0
                m_iHunger = 0;
            }
            Console.WriteLine(m_sName + " has eaten {0}!", item);
        }

        // tricks
        public static void RollOver()
        {
            // no input, no return type
            // increase hunger, sleepiness, and happiness
            // write message to the console
            m_iHunger += 1;
            m_iSleepiness += 2;
            m_iHappiness += 4;

            if (m_iHunger > 20) {
                // prevent hunger going over 20
                m_iHunger = 20;
            }

            if (m_iSleepiness > 20) {
                // prevent sleep going over 20
                m_iSleepiness = 20;
            }

            if (m_iHappiness > 20) {
                // prevent happyness going over 20
                m_iHappiness = 20;
            }

            Console.WriteLine("{0} rolled over. That made him hungry, tired, but happy!", m_sName);
        }

         public static void GoFetch( string item)
        {
            if (item == ""){
                // if no argument is passed through, set a default
                item = "dogs leg";
            }else {
                //  if argument was passedthrough, drop item
                Player.DropItem(item);
                Console.Clear();
            }

            // no input, no return type
            // increase hunger, sleepiness, and happiness
            // write message to the console
            m_iHunger += 1;
            m_iSleepiness += 2;
            m_iHappiness += 4;

            if (m_iHunger > 20) {
                // prevent hunger going over 20
                m_iHunger = 20;
            }

            if (m_iSleepiness > 20) {
                // prevent sleep going over 20
                m_iSleepiness = 20;
            }

            if (m_iHappiness > 20) {
                // prevent happyness going over 20
                m_iHappiness = 20;
            }

            Console.WriteLine("{0} Ran and tried to catch the {1}. But his tiny arms made him miss so the {1} is on the floor. that made him hungry, tired, but happy!", m_sName, item );
        }
    }
    
}
