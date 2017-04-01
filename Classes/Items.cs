using System;

namespace Tamagottagettemall
{
    class Items
    {
        // item name
        private string m_sTitle;
        // store text to display when picking item up
        private string m_sPickupText;
        // store weight of item
        private int m_iWeight = 1;

        public int iWeight
        {
            // get and set the weight of items
            get { return m_iWeight; }
            set { m_iWeight = value; }
        }

        public string sPickupText
        {
            // get and set the pick up text for items
            get { return m_sPickupText; }
            set { m_sPickupText = value; }
        }

        public string sTitle
        {
            // get and set the title of items
            get { return m_sTitle; }
            set { m_sTitle = value; }
        }
    }
}