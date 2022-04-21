using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    internal class Player1
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string team { get; set; }
        public string game { get; set; }

        public Player1(string name, string sex, int age, string team, string game)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.team = team;
            this.game = game;
        }


        public void introduction()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Team: " + team);
            Console.WriteLine("Game: " + game);
        }
    }
}
