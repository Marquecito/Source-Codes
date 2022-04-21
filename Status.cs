using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    internal class Status : Player1
    {

        public string hoursPlayed { get; set; }
        public Status(string name, string sex, int age, string team, string game) : base(name, sex, age, team, game)
        {
            this.hoursPlayed = hoursPlayed;
        }

        public void introduction()
        {
            base.introduction();
            Console.WriteLine(name + "'s Time of Playing: 420 Hourses" + hoursPlayed);
        }


        public void StatusInGame()
        {
            Console.WriteLine(name + ": Online");
        }
        
    }

}
