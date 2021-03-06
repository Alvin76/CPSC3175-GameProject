﻿using System.Collections;
using System.Collections.Generic;
using System;
using StarterGame.Commands;

namespace StarterGame
{
    public class Parser
    {
        private CommandWords commands;

        public Parser() : this(new CommandWords())
        {

        }

        public Parser(CommandWords newCommands)
        {
            commands = newCommands;
        }

        public Command parseCommand(string commandString)
        {
            Command command = null;
            string[] words = commandString.Split(' ');
            if (words.Length > 0)
            {
                command = commands.get(words[0]);
                if (command != null)
                {
                    if (words.Length > 1)
                    {
                        command.secondWord = words[1];
                        //Console.WriteLine("word 2");
                    }
                    else
                    {
                        command.secondWord = null;
                    }
                    if (words.Length > 2)
                    {
                        command.thirdWord = words[2];
                        //Console.WriteLine("Hell yea");
                    }
                    else
                    {
                        command.thirdWord = null;
                        //Console.WriteLine("I made it here");
                    }
                }
                else
                {
                    Console.WriteLine(">>>Did not find the command " + words[0]);
                }
            }
            else
            {
                Console.WriteLine("No words parsed!");
            }
            return command;
        }

        public string description()
        {
            return commands.description();
        }
    }
}
