using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonProjectv2
{
    public class Pokemon
    {
        public string IDname { get; set; }
        public int Strength { get; set; }
        public int Special { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public class move
        {
            public int power;
            public string name;
            public bool IsSpecial;
            public string type;
            public int hitpercent;
        };
        public move[] moves { get; set; }
        public Pokemon(string name)
        {

            if (name == "Venusaur")
            {
                // set Venusaur stats
                this.IDname = name;
                this.Strength = 82;
                this.Health = 80;
                this.Special = 100;
                this.Speed = 80;
                this.Defense = 83;

                this.moves[0].power = 95;
                this.moves[0].name = "Razor Leaf";
                this.moves[0].IsSpecial = true;
                this.moves[0].type = "Grass";
                this.moves[0].hitpercent = 95;

                this.moves[1].power = 85;
                this.moves[1].name = "Body Slam";
                this.moves[1].IsSpecial = false;
                this.moves[1].type = "Normal";
                this.moves[1].hitpercent = 100;

                this.moves[2].power = 100;
                this.moves[2].name = "Earthquake";
                this.moves[2].IsSpecial = false;
                this.moves[2].type = "Ground";
                this.moves[2].hitpercent = 100;

                this.moves[3].power = 150;
                this.moves[3].name = "Hyper Beam";
                this.moves[3].IsSpecial = false;
                this.moves[3].type = "Normal";
                this.moves[3].hitpercent = 90;

            }
            else if (name == "Charizard")
            {
                // set Charizard stats
                this.IDname = name;
                this.Health = 78;
                this.Strength = 84;
                this.Defense = 78;
                this.Special = 85;
                this.Speed = 100;

                this.moves[0].power = 95;
                this.moves[0].name = "Flamethrower";
                this.moves[0].IsSpecial = true;
                this.moves[0].type = "Fire";
                this.moves[0].hitpercent = 100;

                this.moves[1].power = 70;
                this.moves[1].name = "Slash";
                this.moves[1].IsSpecial = false;
                this.moves[1].type = "Normal";
                this.moves[1].hitpercent = 100;


                this.moves[2].power = 70;
                this.moves[2].name = "Fly";
                this.moves[2].IsSpecial = false;
                this.moves[2].type = "Flying";
                this.moves[2].hitpercent = 95;

                this.moves[3].power = 100;
                this.moves[3].name = "Earthquake";
                this.moves[3].IsSpecial = false;
                this.moves[3].type = "Ground";
                this.moves[3].hitpercent = 100;

            }
            else if (name == "Blastoise")
            {
                // set Blastoise Stats
                this.IDname = name;
                this.Strength = 83;
                this.Health = 79;
                this.Defense = 100;
                this.Special = 85;
                this.Speed = 78;

                this.moves[0].power = 95;
                this.moves[0].name = "Surf";
                this.moves[0].IsSpecial = true;
                this.moves[0].type = "Water";
                this.moves[0].hitpercent = 95;

                this.moves[1].power = 95;
                this.moves[1].name = "Ice Beam";
                this.moves[1].IsSpecial = true;
                this.moves[1].type = "Ice";
                this.moves[1].hitpercent = 95;


                this.moves[2].power = 60;
                this.moves[2].name = "Bite";
                this.moves[2].IsSpecial = false;
                this.moves[2].type = "Dark";
                this.moves[2].hitpercent = 100;

                this.moves[3].power = 85;
                this.moves[3].name = "Body Slam";
                this.moves[3].IsSpecial = false;
                this.moves[3].type = "Normal";
                this.moves[3].hitpercent = 85;
            }
        }
    }
}
