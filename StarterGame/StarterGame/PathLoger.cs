using System;
using System.IO;

namespace StarterGame
{
    public class PathLoger
    {
        public int x = 0;

        public PathLoger()
        {
            x = 2;
        }
        
        public void newGame()
        {
            if (File.Exists("PathLog.txt"))
                File.Delete("PathLog.txt");
            File.Create("PathLog.txt");
        }

        public void PathWriter(string command)
        {
            StreamWriter pathlog = new StreamWriter("PathLog.txt");
            pathlog.WriteLine(command);
            pathlog.Close();
        }

        public void pathLoad()
        {

        }

    }
}
