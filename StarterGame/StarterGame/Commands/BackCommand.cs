using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace StarterGame.Commands
{
    //This is the back command it part of the 5 things needed 
    public class BackCommand : Command
    {
        Parser parser;
        GoCommand backwards = new GoCommand();
        public BackCommand() : base()
        {
            this.name = "back";

        }

        public override bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                try
                {
                    int values = Convert.ToInt32(this.secondWord);
                    TextReader logs = new StreamReader("PathLog.txt");
                    ArrayList temp = new ArrayList();
                    foreach (var i in logs.ReadLine())
                    {
                        temp.Add(i);
                    }

                    if (values > temp.Count)
                        values = temp.Count;
                    for (int i = values; i > 0; i--)
                    {
                        var x = temp[i];
                        if (x == "west")
                        {
                            x = "east";
                        }
                        else if (x == "east")
                        {
                            x = "west";
                        }
                        else if (x == "north")
                        {
                            x = "south";
                        }
                        else if (x == "south")
                        {
                            x = "north";
                        }

                        Command command = "go" + (string) x; //parser.parseCommand(Console.ReadLine());
                        temp.RemoveAt(i);
                    }

                    player.outputMessage("\nI cannot backup " + this.secondWord);
                }
                catch
                {
                    Console.WriteLine("Your not aloud to do that please continue");
                }

            }
            else
            {
                player.outputMessage("\n How far to return to the past?");
            }

            return false;
        }
    }
}