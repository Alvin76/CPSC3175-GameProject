using System.Collections;
using System.Collections.Generic;
using System;
using StarterGame.Commands;
using System.IO;

namespace StarterGame
{
    public class CommandWords
    {
        //private TextWriter pathlog = new StreamWriter("C:\\PathLog.txt");
        // @R I think this is used to accesses commands and place them in
        Dictionary<string, Command> commands;
        private static Command[] commandArray = { new GoCommand(),
                                                  new QuitCommand(),
                                                  new FindCommand(),
                                                  new BackCommand(),
                                                  new AttackCommand(), 
                                                  new EquipCommand(), 
                                                  new InvantoryCommand(), 
                                                  new ConditionCommand(), 
                                                  new StatisCommand()
        };
        //Added in FindCommand 

        public CommandWords() : this(commandArray)
        {
        }

        public CommandWords(Command[] commandList)
        {
            commands = new Dictionary<string, Command>();
            foreach (Command command in commandList)
            {
                commands[command.name] = command;
            }
            Command help = new HelpCommand(this);
            commands[help.name] = help;
        }

        public Command get(string word)
        {
            Command command = null;
            commands.TryGetValue(word, out command);
            return command;
        }

        public string description()
        {
            string commandNames = "";
            Dictionary<string, Command>.KeyCollection keys = commands.Keys;
            foreach (string commandName in keys)
            {
                commandNames += " " + commandName;
            }
            return commandNames;


        }
    }
}
