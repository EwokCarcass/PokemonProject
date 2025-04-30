using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProjectv2
{
    public class MatchSetUp
    {
        public User user { get; set; }
        public User NPC { get; set; }

        public MatchSetUp()
        {
            User user = new User("Player1");
            User npc = new User("NPC");
            this.user = user;
            this.NPC = npc;
        }
    }
}
