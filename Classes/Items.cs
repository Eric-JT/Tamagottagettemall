using System;

namespace Tamagottagettemall
{
    class Items
    {
        // item name
        private string m_sTitle;
        // store text to display when picking item up
        private string m_sPickupText;
        // description of item
        private string m_sItemDescription;
        

        public string sPickupText
        {
            // get and set the pick up text for items
            get { return m_sPickupText; }
            set { m_sPickupText = value; }
        }

        public string sItemDescription
        {
            // get and set description for items
            get { return m_sItemDescription; }
            set { m_sItemDescription = value; }
        }

        public string sTitle
        {
            // get and set the title of items
            get { return m_sTitle; }
            set { m_sTitle = value; }
        }
    }
}