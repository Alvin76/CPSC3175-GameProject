using System.Collections;
using System.Collections.Generic;
using System;
using StarterGame.Commands;
using StarterGame.Characters;

namespace StarterGame
{
    public class Game
    {
        EndOfGame Victory = new EndOfGame();
        Player player;
        Parser parser;
        bool playing;

        public Game()
        {
            playing = false;
            parser = new Parser(new CommandWords());
            player = new Player(createWorld());
        }

        public Room createWorld()
        {
            Room outside = new Room("outside the main entrance of the university");
            Room cctparking = new Room("in the parking lot at CCT");
            Room boulevard = new Room("on the boulevard");
            Room universityParking = new Room("in the parking lot at University Hall");
            Room parkingDeck = new Room("in the parking deck");
            Room cct = new Room("in the CCT building");
            Room theGreen = new Room("in the green in from of Schuster Center");
            Room universityHall = new Room("in University Hall");
            Room schuster = new Room("in the Schuster Center");
            Room temp1 = new Room("lost room");
            // add more rooms here around the school 
            // add post event rooms here too XD 
            // will need to figure out to change when the room go from one event to another

            outside.setExit("west", boulevard);
            //outside.getItems();

            boulevard.setExit("east", outside);
            boulevard.setExit("south", cctparking);
            boulevard.setExit("west", theGreen);
            boulevard.setExit("north", universityParking);

            cctparking.setExit("west", cct);
            cctparking.setExit("north", boulevard);

            cct.setExit("east", cctparking);
            cct.setExit("north", schuster);

            schuster.setExit("south", cct);
            schuster.setExit("north", universityHall);
            schuster.setExit("east", theGreen);

            theGreen.setExit("west", schuster);
            theGreen.setExit("east", boulevard);

            universityHall.setExit("south", schuster);
            universityHall.setExit("east", universityParking);

            universityParking.setExit("south", boulevard);
            universityParking.setExit("west", universityHall);
            universityParking.setExit("north", parkingDeck);

            parkingDeck.setExit("south", universityParking);

            return outside;
        }

        /**
     *  Main play routine.  Loops until end of play.
     */
        public void play()
        {

            // Enter the main command loop.  Here we repeatedly read commands and
            // execute them until the game is over.

            bool finished = false;
            while (!finished)
            {
                Console.Write("\n>");
                Command command = parser.parseCommand(Console.ReadLine());
                if (command == null)
                {
                    Console.WriteLine("I don't understand...");
                }
                else
                {
                    finished = command.execute(player);
                }
            }
        }


        public void start()
        {
            playing = true;
            player.outputMessage(welcome());
        }

        public void end()
        {
            playing = false;
            player.outputMessage(goodbye());
        }

        public string welcome()
        {
            return "Welcome to the World of CSU!\n\n The World of CSU is a new, incredibly boring adventure game.\n\nType 'help' if you need help." + player.currentRoom.description();
        }

        public string goodbye()
        {
            if (Victory.Win())
            {
                return "\n Congrats on wining the game! Thank you for playing, Goodbye. \n";
            }
            else
            {
                return "\nI'm sorry you did not win. Thank you for playing, Goodbye. \n";
            }
        }

    }
}
