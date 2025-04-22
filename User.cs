using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProjectv2
{
    public class User
    {
        public string name { get; set; }
        public List<Pokemon> pokeballs = new List<Pokemon>();
        public List<int> items = new List<int>();
        public int total { get; set; }

        public User(string NAME)
        {
            this.name = NAME;
        }
        public void add(Pokemon pokemon)
        {
            pokeballs.Add(pokemon);
            total++;
        }
        public void addpotion(int num)
        {
            items.Add(num);
        }
    }
}
