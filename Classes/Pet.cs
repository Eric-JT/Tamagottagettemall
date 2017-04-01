using System;


namespace Tamagottagettemall
{
    class Pet
    {
        // Variables for the pets sleep, hunger, happy, name
        private int m_iSleepiness;
        private int m_iHappiness;
        private int m_iHunger;
        private string m_sName;

        public Pet(string name)
        {
            // start the pet off with medium values
            m_sName = name;
            // start the pet off with medium values
            m_iSleepiness = 5;
            m_iHappiness = 5;
            m_iHunger = 5;
        }

        // sleep
        public void Sleep()
        {
            // no input, no return type
            // decrease sleep
            // write message to the console
            m_iSleepiness -= 2;

            if (m_iSleepiness < 0)
            {
                // stop sleep from going below 0
                m_iSleepiness = 0;
            }
            Console.WriteLine("{0} has slept!", m_sName);
        }

        // eat
        public void Eat()
        {
            // no input, no return type
            // decrease hunger
            // write message to the console
            m_iHunger -= 2;
            if (m_iHunger < 0)
            {
                // stop unger from going below 0
                m_iHunger = 0;
            }
            Console.WriteLine(m_sName + " has eaten!");
        }

        // tricks
        public void RollOver()
        {
            // no input, no return type
            // increase hunger, sleepiness, and happiness
            // write message to the console
            m_iHunger += 1;
            m_iSleepiness += 2;
            m_iHappiness += 4;

            if (m_iHunger > 10)
            {
                // prevent hunger going over 10
                m_iHunger = 10;
            }

            if (m_iSleepiness > 10)
            {
                // prevent sleep going over 10
                m_iSleepiness = 10;
            }

            if (m_iHappiness > 10)
            {
                // prevent happyness going over 10
                m_iHappiness = 10;
            }

            Console.WriteLine("{0} rolled over, he is hungry, tired, but happy!", m_sName);
        }
    }
    
}
