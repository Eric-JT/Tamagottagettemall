using System;

namespace Tamagottagettemall
{
    class Game
    {
        // Multidemensional array to store the Room map
        //private static Room[,] m_arrayPetRoom;
        private static Room[] m_arrayPetRoom;

        /* * * Get methods * * */
        /* * * Room* * */
        public static Room[] arrayRooms
        {
          // input two integer values and get the current Room
          get { return m_arrayPetRoom; }
        }

        public static void InitializePetRoom()
        {
          // create the worlds
          BuildRoom();
        }

        private static void BuildRoom()
        {
            // define the world size, how many Rooms
            m_arrayPetRoom = new Room[1];

            Room room; // create a new Room object
            Items item; // create a new item object for the Room

            
            // the Room entrance
            room = new Room();

            // Assign this Room to location 0
            m_arrayPetRoom[0] = room;

            // Setup the Room
            room.sRoomTitle = "Your Pets Room";
            room.sDescription = "Your pets room, is clean";

           // create item
            item = new Items();
            item.sTitle = "piece of shin bone";
            item.sPickupText = "You just picked up the shin bone.";
            room.Items.Add(item);

            // ADD THE PLAYER TO THE GAME
            // place the player in the game
            Player.iPos = 0;
        }
  
    }
}