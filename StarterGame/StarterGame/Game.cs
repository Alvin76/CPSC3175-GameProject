using System.Collections;
using System.Collections.Generic;
using System;
using StarterGame.Commands;
using StarterGame.Characters;

namespace StarterGame
{
    public class Game
    {
        EndOfGame Victory = EndOfGame.oneEnd();
        Characters.Player player;
        Parser parser;
        bool playing;

        public Game()
        {
            playing = false;
            parser = new Parser(new CommandWords());
            player = Characters.Player.getInstance();
            createWorld();
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
            Room clockTower = new Room("at the clock tower");
            Room lenoir = new Room(" in the Lenoir");
            Room temple = new Room("in a hidden temple pass the Lenoir, unseen by the naked eye");
            // add more rooms here around the school
            // add post event rooms here too XD
            // will need to figure out to change when the room go from one event to another

            // IGoods.NewNonEquipments tree = new IGoods.NewNonEquipments("Tree", 800f, 1000f, 1, 0, 0, false);
            player.addToInventory(new IGoods.NewNonEquipments("Paper", 0.1f, 0.002f, 1, 0, 0, true));
            player.addToInventory(new IGoods.NewNonEquipments("Chocolate", 4f, 2f, 2, 2, 3, true));
            player.addToInventory(new IGoods.NewEquipments("Binder", 40f, 4f, 1, 2, 2, 10, true, true));
            

            outside.setExit("west", boulevard);
            outside.addItem(new IGoods.NewNonEquipments("Tree", 800f, 1000f, 2, 0, 0, false));
            outside.addItem(new IGoods.NewEquipments("Ball Pen", 1f, 0.5f, 1, 1, 0, 0, false, false));

            boulevard.setExit("east", outside);
            boulevard.setExit("south", cctparking);
            boulevard.setExit("west", theGreen);
            boulevard.setExit("north", universityParking);

            cctparking.setExit("west", cct);
            cctparking.setExit("north", boulevard);
            cctparking.addItem(new IGoods.NewNonEquipments("Tree", 800f, 1000f, 10, 0, 0, false));
            cctparking.addItem(new IGoods.NewEquipments("Wrench", 30f, 4f, 1, 2, 3, 8, false, false));

            cct.setExit("east", cctparking);
            cct.setExit("north", schuster);
            cct.addItem(new IGoods.NewEquipments("Keyboard", 60f, 1.5f, 1, 2, 3, 3, true, false));

            schuster.setExit("south", cct);
            schuster.setExit("north", universityHall);
            schuster.setExit("east", theGreen);
            schuster.setExit("west", clockTower);
            schuster.addItem(new IGoods.NewNonEquipments("Burger", 15f, 0.5f, 6, 1, 10, false));

            theGreen.setExit("west", schuster);
            theGreen.setExit("east", boulevard);
            theGreen.addItem(new IGoods.NewNonEquipments("Tree", 800f, 1000f, 4, 0, 0, false));

            universityHall.setExit("south", schuster);
            universityHall.setExit("east", universityParking);

            universityParking.setExit("south", boulevard);
            universityParking.setExit("west", universityHall);
            universityParking.setExit("north", parkingDeck);

            parkingDeck.setExit("south", universityParking);

            clockTower.setExit("west", lenoir);
            clockTower.setExit("east", schuster);

            lenoir.setExit("west", temple);
            lenoir.setExit("east", clockTower);

            temple.setExit("south", lenoir);
            temple.VictoryCondition = true;

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
