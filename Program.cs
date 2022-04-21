using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player1 p1 = new Player1("Marc", "Male", 19, "Nyoging Esports", "VALORANT");
        
            p1.introduction();

            Console.WriteLine("\n");

            Status p2 = new Status("Stina", "Female", 18, "Nyoging Esports", "ROBLOX");
         
            p2.introduction();
            p2.StatusInGame();

            Console.WriteLine("\n");

            Rank p3 = new Rank("Jio", "Male", 20, "Nyoging Gaming", "ART");
            p3.introduction();
            p3.StatusInGame();
            p3.theRank();

            Console.WriteLine("\n\nPress ENTER to exit");
            Console.ReadLine();


        }
    }
}
