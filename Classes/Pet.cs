using System;


namespace classexamples
{
    class Pet
    {
        // member variable
        // only this class can use it
        private int m_iSleepiness;
        private int m_iHappiness;
        private int m_iHunger;
        private string m_sName;

        // constructor method no return type
        // shares the same name as class
        // set up any variables apart of our class
        public Pet(string name)
        {
            m_sName = name;
            m_iSleepiness = 5;
            m_iHappiness = 5;
            m_iHunger = 5;
        }

        // tell the pet how to sleep
        public void Sleep()
        {
            m_iHunger -= 2;

            if (m_iSleepiness < 0)
            {
                m_iSleepiness = 0;
            }
            Console.WriteLine(m_sName + " has slept!");
        }

        public void Eat()
        {
            // eat
            // decrease hunger
            m_iHunger -= 2;
            if (m_iHunger < 0)
            {
                m_iHunger = 0;
            }
            Console.WriteLine(m_sName + " has eaten!");
        }

        public void RollOver()
        {
            // roll over increase hunger, sleepiness, and happiness
            m_iHunger += 1;
            m_iSleepiness += 2;
            m_iHappiness += 4;

            if (m_iHunger > 10)
            {
                m_iHunger = 10;
            }

            if (m_iSleepiness > 10)
            {
                m_iSleepiness = 10;
            }

            if (m_iHappiness > 10)
            {
                m_iHappiness = 10;
            }

            Console.WriteLine(m_sName + " rolled over, he is hungry, tired, but happy!");
        }
    }
    
}
