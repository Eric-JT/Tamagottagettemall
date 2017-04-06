using System;
using System.Collections.Generic;

namespace Tamagottagettemall
{
    class Room
    {
        

        // Store titles for each room
        protected string m_sRoomTitle;
        
        // Store description of room
        protected string m_sRoomDescription;
        
        // Store Items in room - list
        protected List<Items> m_listItems;

        public List<Items> Items
        {
            // store and retrieve item names 
            get { return m_listItems; }
            set { m_listItems = value; }
        }

        public Room(){
            // for each cave created, crete a list of items
            m_listItems = new List<Items>();
        }
        
        /* * * Get/Set methods * * */
        /* * * Cave Titles * * */
        public string sRoomTitle
        {
            // store or retrieve cave title
            get { return m_sRoomTitle; }
            set { m_sRoomTitle = value; }
        }

        /* * * Room Description * * */
        public string sDescription
        {
            // store or retrieve cave description
            get { return m_sRoomDescription; }
            set { m_sRoomDescription = value; }
        }

        /* * * Room Description More detail * * */
        public void DescribePetRoom()
        {
            // write out decription, list of items, list of available exits
            Console.WriteLine(this.m_sRoomDescription);
            Console.WriteLine(this.GetListOfItems());
        }

        public Items GetItem(string itemName)
        {
            // input string for item name
            // check each item in the Rooms
            // if the item is in the room return that item
            // else return nothing
            foreach (Items item in this.m_listItems) {
                if (item.sTitle.ToLower() == itemName.ToLower()) {
                    return item;
                }
            }
            return null;
        }

        private string GetListOfItems()
        {
            // create empty string to store items in
            // create output message
            string sItem = "";
            string sOutput = "Items in Rooms:";

            // if the item list of the room is > 0
            // add each item to item list
            // return the list of items
            // else return none
            if (this.m_listItems.Count > 0) {
                foreach (Items item in this.m_listItems) {
                    sItem += "\n[" + item.sTitle + "]";
                }
            }else {
                sItem = "\n<none>";
            }

            return "\n" + sOutput + "\n" + sItem;
        }
   
    }    
}