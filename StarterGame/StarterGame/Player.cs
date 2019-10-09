using System.Collections;
using System.Collections.Generic;
using System;

namespace StarterGame
{
    public class Player
    {
        private Room _currentRoom = null;
        public Room currentRoom
        {
            get
            {
                return _currentRoom;
            }
            set
            {
                _currentRoom = value;
            }
        }

        public Player(Room room)//, GameOutput output)
        {
            _currentRoom = room;
        }
        //This is to move into each room or how the GoComand works
        public void waltTo(string direction)
        {
            Room nextRoom = this._currentRoom.getExit(direction);
            if (nextRoom != null)
            {
                this._currentRoom = nextRoom;
                this.outputMessage("\n" + this._currentRoom.description());
            }
            else
            {
                this.outputMessage("\nThere is no door on " + direction);
            }
        }
        //This is to find items in the room
        public void findMe(string fObject)
        {
            Room items = this._currentRoom.//add funtion in rooms
        }

        public void outputMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
