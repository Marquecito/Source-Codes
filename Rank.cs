using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    internal class Rank : Status
    {
        public string rank { get; set; }

        public Rank(string name, string sex, int age, string team, string game) : base(name, sex, age, team, game)
        {
            this.rank = rank;
        }

        public void theRank()
        {
            Console.WriteLine(name + "'s Rank: Magaling" + rank);
        }
    }
}
