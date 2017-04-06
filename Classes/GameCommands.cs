using System;

namespace Tamagottagettemall
{
    class GameCommands
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

            if (!IsValidCommand(sCommand))
            {
                Console.WriteLine("You pet is upset you you slurred your words.\n");
            }
            else
            {
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
                    case "whatis":
                        Player.ItemDescription(Player.GetItemDescription(sArguments));
                        break;
                    case "fetch":
                        GameManager.MoveCount(); // increase move count
                        Pet.GoFetch(sArguments);
                        break;
                    case "rollover":
                        GameManager.MoveCount(); // increase move count
                        Pet.RollOver();
                        break;
                    case "sleep":
                        GameManager.MoveCount(); // increase move count
                        Pet.Sleep();
                        break;
                    case "eat":
                        GameManager.MoveCount(); // increase move count
                        Pet.Eat(sArguments);
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }

            GameManager.Rules(); // check the rules for the game
        }

        static bool IsValidCommand(string command){
            // Input is a string, returns either true or false
            // checks if input is valid
            switch (command){
                case "help":
                    return true;
                case "exit":
                    return true;
                case "look":
                    return true;
                case "pickup":
                    return true;
                case "drop":
                    return true;
                case "inventory":
                    return true;
                case "whatis":
                    return true;
                case "fetch":
                    return true;
                case "rollover":
                    return true;
                case "sleep":
                    return true;
                case "eat":
                    return true;
                case "clear":
                    return true;
                default:
                    Console.WriteLine("Invalid Command!!");
                    break;
            }
            return false;
        }

        public static void ShowHelp()
        {
            // display a help screen with a list of commmands
            Console.WriteLine("\nList of commands:");
            Console.WriteLine("help"); // display help menu
            Console.WriteLine("exit"); // exit the game
            Console.WriteLine("look"); // describe pet
            Console.WriteLine("pickup"); // pick up objects to use on pet
            Console.WriteLine("drop");  // drop objects
            Console.WriteLine("inventory"); // see whats in inventory
            Console.WriteLine("whatis"); // see description of the item
            Console.WriteLine("clear");  // clear the screen
            Console.WriteLine("fetch"); // play fetch with dog
            Console.WriteLine("sleep"); // put Marty to sleep
            Console.WriteLine("eat"); // feed marty
            Console.WriteLine("rollover"); // play with marty
        }
    }
}