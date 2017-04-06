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

            Room room = new Room(); // create a new Room object
            Items item; // create a new item object for the Room

            // Store the room
            m_arrayPetRoom[0] = room;

            // Setup the Room
            room.sRoomTitle = "Your Pets Room";
            room.sDescription = "Your pet t-rex's room is full of dead animals and people.";

           // create items
            item = new Items();
            item.sTitle = "human skull";
            item.sPickupText = "You just picked up skull";
            item.sItemDescription = "Skulls are fun to play catch with.";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "human leg";
            item.sPickupText = "You just grabbed a leg.";
            item.sItemDescription = "You can feed MArty or play fetch with the leg.";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "dead bird";
            item.sPickupText = "Ew! You touched a dead bird.";
            item.sItemDescription = "You better get rid of it";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "live cat";
            item.sPickupText = "Awe you picked up the cure kitty. It purrs as you pet it.";
            item.sItemDescription = "Throw the cat at the t-rex?";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "bacon";
            item.sPickupText = "mmm Bacon!";
            item.sItemDescription = "Marty Might want some bacon!";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "dead alligator";
            item.sPickupText = "Why do oyu have a dead alligator in your house?";
            item.sItemDescription = "feed it to Marty your t-rex?";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "large stick";
            item.sPickupText = "Fetch? anyone.";
            item.sItemDescription = "You can toss the stick";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "human foot";
            item.sPickupText = "You have been saving this foot for a special ocassion...";
            item.sItemDescription = "People have been getting suspicious... better get rid of the foot.";
            room.Items.Add(item);

            item = new Items();
            item.sTitle = "live squirrel";
            item.sPickupText = "A cute squirrel leaped into your arms";
            item.sItemDescription = "time to throw a squirrel at Marty!";
            room.Items.Add(item);

            
            // place the player in the game
            Player.iPos = 0;
        }
  
    }
}