using System;
using System.Collections.Generic;

namespace Tamagottagettemall
{
    static class Player
    {
        
        private static int m_iPlayerPos; // used to set the player in the game
        private static List<Items> m_listItemInventory; // store player inventory
       
        public static int iPos
        {
            // get and set player position
            get { return m_iPlayerPos; }
            set { m_iPlayerPos = value; }
        }

        static Player()
        {
            m_listItemInventory = new List<Items>();
        }
       
        public static void PickupItem(string itemName)
        {
            //input is a string, output is a message to the player
            Room cave = Player.GetCurrentRoom(); // get tet access to the list of tems in the room
            Items item = cave.GetItem(itemName); 

            if (item != null) {
                

                cave.Items.Remove(item); // remove the item from the room
                Player.m_listItemInventory.Add(item); // place the item on the player
                Console.WriteLine(item.sPickupText); // write out to the screen
            }else {
                // inform the player that there is no item by the name entered in the room
                Console.WriteLine("There is no " + itemName + " in this room.");
            }
        }

        public static void DropItem (string itemName)
        {
            // input is a string. output is a amessage to the player
            Room cave = Player.GetCurrentRoom(); // get tet access to the list of tems in the room
            Items item = GetInventoryItem(itemName);

            if (item != null) {
                // remove the item from the player list
                // add item to the room list
                // inform the player
                Player.m_listItemInventory.Remove(item);
                cave.Items.Add(item);
                Console.WriteLine("The " + itemName + " has been dropped into this room");
            }
            else if (itemName == "") {
            // player drops nothing
                Console.WriteLine("You are waving oyur hands around like a maniac");
            }else {
            // player mispells something
                Console.WriteLine("There is no " + itemName + " in your inventory");
            }
        }

        public static void DisplayInventory()
        {
            string message = "You are holding: ";
            string items = ""; // empty string to store items

            if (m_listItemInventory.Count > 0) {
                foreach (Items item in m_listItemInventory) {
                    // for each item in the inventory add it to the empty string plus the weight of item and a newline
                    items += "\n[" + item.sTitle + "]";
                }
            }
            else {
                items = "\n<no items>"; // no items to display
            }
            
            // write out the info to the user
            Console.WriteLine(message + "\n" + items);
        }


        public static Items GetInventoryItem(string itemName)
        {
            foreach (Items item in m_listItemInventory) {
                // get each item in inventoy list
                if (item.sTitle.ToLower() == itemName.ToLower())
                    return item;
            }
            return null;
        }

        public static string GetItemDescription(string itemName)
        {           
            foreach (Items item in m_listItemInventory) {
                // get each item in inventoy list
                if (item.sTitle.ToLower() == itemName.ToLower())
                     return item.sItemDescription;
            }
            return"Sorry dude, You are not holding that item.";
        }

        public static void ItemDescription(string message)
        {
            Console.WriteLine(message);
        }

        public static Room GetCurrentRoom()
        {
            // get the current room
            return Game.arrayRooms[m_iPlayerPos];
        }

    }
}