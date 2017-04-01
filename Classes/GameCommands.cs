using System;

namespace Tamagottagettemall
{
    static class GameCommands
    {

        public static string GetCommand(string sPlayerInput)
        {
            // Input string. check if the string has more than one word
            // if string has one word return that string
            // if the string has more than one word return the first word
            int iIndex = sPlayerInput.IndexOf(' ');
            if (iIndex == -1)
                return sPlayerInput;
            else
                return sPlayerInput.Substring(0, iIndex);
        }

        public static string GetArgument(string sPlayerInput)
        {
            // input string. check if the string has more than one word
            // if the string has one word return an empty string
            // if there are more than one word than return all words exept the first one
            int iIndex = sPlayerInput.IndexOf(' ');
            if (iIndex == -1)
                return "";
            else
                return sPlayerInput.Substring(iIndex + 1, sPlayerInput.Length - iIndex - 1);
        }

        public static void CheckTheCommand(string sPlayerInput)
        {

            // store the first word in the string to sCommand, remove whitespace and lower case
            string sCommand = GetCommand(sPlayerInput.Trim()).Trim().ToLower();
            // store all remaing words in the string to sArguments, remove whitespace and lower case
            string sArguments = GetArgument(sPlayerInput.Trim()).Trim().ToLower();

            
            switch (sCommand) {
                case "exit":
                    Program.quit = true;
                    return;
                case "help":
                    ShowHelp();
                    break;  
                case "look":
                    // return information for the pet room
                    Player.GetCurrentRoom().DescribePetRoom();
                    break;
                case "pickup":
                    // check if item on shelf, remove item from shelf, add item to inventory
                    Player.PickupItem(sArguments);
                    break;
                case "drop":
                    // check if item in inventory, remove item from inventory, add item to shelf
                    Player.DropItem(sArguments);
                    break;
                case "inventory":
                    // display all items in inventory
                    Player.DisplayInventory();
                    break;
                default:
                    Console.WriteLine("Invalid Command!");
                    break;
            }
            // apply the game rules  
        }

        public static void ShowHelp()
        {
            // display a help screen with a list of commmands
            Console.WriteLine("List of commands");
            Console.WriteLine("help");
            Console.WriteLine("exit");
            Console.WriteLine("look"); // describe pet
            Console.WriteLine("pickup"); // pick up objects to use on pet
            Console.WriteLine("drop");  // drop objects
            Console.WriteLine("inventory"); // see whats in inventory
        }
    }
}