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
        public move[] moves { get; set; }
        public class move
        {
            public int Power { get; set; }
            public string Name { get; set; }
            public bool IsSpecial { get; set; }
            public string Type { get; set; }
            public int Hitpercent { get; set; }
            public move(string name, int power, bool isSpecial, string type, int accuracy)
            {
                this.Name = name;
                this.Power = power;
                this.IsSpecial = IsSpecial;
                this.Type = type;
                this.Hitpercent = accuracy;
            }
        }


        public Pokemon(string name)
        {
            this.moves = new move[4];

            if (name == "Venusaur")
            {
                // set Venusaur stats
                this.IDname = name;
                this.Strength = 82;
                this.Health = 80;
                this.Special = 100;
                this.Speed = 80;
                this.Defense = 83;

                this.moves[0] = new move("Razor Leaf", 55, true, "Grass", 100); 
                this.moves[1] = new move("Body Slam", 85, false, "Normal", 100);
                this.moves[2] = new move("Sleep Powder", 0, true, "Poison", 75);
                this.moves[3] = new move("Sludge Bomb", 90, true, "Poison", 100);

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

                this.moves[0] = new move("Flamethrower",95, true, "Fire", 100);
                this.moves[1] = new move("Slash", 70, false, "Normal", 100);
                this.moves[2] = new move("Fly", 70, false, "Flying", 95);
                this.moves[3] = new move("Earthquake", 100, false, "Ground", 100);

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

                this.moves[0] = new move("Scald", 80, true, "Water", 100);
                this.moves[1] = new move("Ice Beam", 90, true, "Ice", 100);
                this.moves[2] = new move("Blizard", 120, true, "Ice", 95);
                this.moves[3] = new move("Body Slam", 85, false, "Normal", 100);

            }
            else if (name == "Unfezant")
            {
                this.IDname = name;
                this.Strength = 115;
                this.Defense = 80;
                this.Special = 65;
                this.Health = 80;
                this.Speed = 93;

                this.moves[0] = new move("Air Slash", 75, false, "Flying", 95);
                this.moves[1] = new move("Return", 102, false, "Normal", 100);
                this.moves[2] = new move("Steel Wing", 70, false, "Steel", 90);
                this.moves[3] = new move("Quick Attack", 40, false, "Normal", 100);

            }
            else if (name == "Stonjourner")
            {
                this.IDname = name;
                this.Strength = 125;
                this.Health = 100;
                this.Speed = 70;
                this.Special = 20;
                this.Defense = 135;

                this.moves[0] = new move("Rock Slide", 75, false, "Rock", 90);
                this.moves[1] = new move("Earthquake", 100, false, "Ground", 100);
                this.moves[2] = new move("Heavy Slam", 80, false, "Steel", 100);
                this.moves[3] = new move("Body Press", 80, false, "Fighting", 100);
            }
            else if (name == "Falinks")
            {
                this.IDname = name;
                this.Strength = 100;
                this.Health = 65;
                this.Defense = 100;
                this.Speed = 75;
                this.Special = 70;

                this.moves[0] = new move("Close Combat", 120, false, "Fighting", 100);
                this.moves[1] = new move("Megahorn", 120, false, "Bug", 85);
                this.moves[2] = new move("Rock Tomb", 60, false, "Rock", 95);
                this.moves[3] = new move("Body Slam", 85, false, "Normal", 100);
            }
        }
    }
}
