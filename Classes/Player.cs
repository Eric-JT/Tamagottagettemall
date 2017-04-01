using System;
using System.Collections.Generic;

namespace Tamagottagettemall
{
    static class Player
    {
        private static int m_iPlayerPos;
        private static List<Items> m_listItemInventory;
        private static int m_iMaxWeight = 6;

        public static int iPos
        {
            get { return m_iPlayerPos; }
            set { m_iPlayerPos = value; }
        }



        static Player()
        {
            m_listItemInventory = new List<Items>();
        }

        public static int InventoryWeight
        {
            get
            {
                int result = 0;
                foreach (Items item in m_listItemInventory)
                {
                    result += item.iWeight;
                }
                return result;
            }
        }
       
        public static void PickupItem(string itemName)
        {
            Room cave = Player.GetCurrentRoom();
            Items item = cave.GetItem(itemName);

            if (item != null)
            {
                if (Player.InventoryWeight + item.iWeight > Player.m_iMaxWeight)
                {
                    Console.WriteLine("You must firt drop some weight before you can pick up that item.");
                    return;
                }

                cave.Items.Remove(item);
                Player.m_listItemInventory.Add(item);
                Console.WriteLine(item.sPickupText);
            }
            else
            {
                Console.WriteLine("There is no " + itemName + " in this room.");
            }
        }

        public static void DropItem (string itemName)
        {
            Room cave = Player.GetCurrentRoom();
            Items item = GetInventoryItem(itemName);

            if (item != null)
            {
                Player.m_listItemInventory.Remove(item);
                cave.Items.Add(item);
                Console.WriteLine("The " + itemName + " has been dropped into this room");
            }
            else if (itemName == "")
                Console.WriteLine("You can't drop nothing. How do you think that would work?");
            else
                Console.WriteLine("There is no " + itemName + " in your inventory");
        }

        public static void DisplayInventory()
        {
            string message = "Your inventory contains:";
            string items = "";
            string underline = "";
            underline = underline.PadLeft(message.Length, '-');

            if (m_listItemInventory.Count > 0)
            {
                foreach (Items item in m_listItemInventory)
                {
                    items += "\n[" + item.sTitle + "] Wt: " + item.iWeight.ToString();
                }
            }
            else
                items = "\n<no items>";

            items += "\n\nTotal Wt: " + Player.InventoryWeight + " / " + Player.m_iMaxWeight;

            Console.WriteLine(message + "\n" + underline + items);
        }

       

        public static Items GetInventoryItem(string itemName)
        {
            foreach (Items item in m_listItemInventory)
            {
                if (item.sTitle.ToLower() == itemName.ToLower())
                    return item;
            }
            return null;
        }

        public static Room GetCurrentRoom()
        {
            return Game.arrayRooms[m_iPlayerPos];
        }

    }
}