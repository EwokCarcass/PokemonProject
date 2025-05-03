using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonProjectv2
{
    public partial class BattleScreen : Form
    {
        private MatchSetUp m;
        private BattleScreen b;
        public BattleScreen(MatchSetUp m)
        {
            InitializeComponent();
            this.m = m;
            var currentpokemon = m.user.pokeballs[0];
            Move1.Text = currentpokemon.moves[0].Name + " \n Type: " + currentpokemon.moves[0].Type + "\n Power: " + currentpokemon.moves[0].Power + " - " + currentpokemon.moves[0].Hitpercent +"% Accurate";
            Move2.Text = currentpokemon.moves[1].Name + " \n Type: " + currentpokemon.moves[1].Type + "\n Power: " + currentpokemon.moves[1].Power + " - " + currentpokemon.moves[1].Hitpercent + "% Accurate";
            Move3.Text = currentpokemon.moves[2].Name + " \n Type: " + currentpokemon.moves[2].Type + "\n Power: " + currentpokemon.moves[2].Power + " - " + currentpokemon.moves[2].Hitpercent + "% Accurate";
            Move4.Text = currentpokemon.moves[3].Name + " \n Type: " + currentpokemon.moves[3].Type + "\n Power: " + currentpokemon.moves[3].Power + " - " + currentpokemon.moves[3].Hitpercent + "% Accurate";

            setMoveColor(Move1, currentpokemon.moves[0].Type);
            setMoveColor(Move2, currentpokemon.moves[1].Type);
            setMoveColor(Move3, currentpokemon.moves[2].Type);
            setMoveColor(Move4, currentpokemon.moves[3].Type);

            setbackSprite(currentpokemon.IDname);
        }
        private void setbackSprite(string name)
        {
            if (name == "Charizard")
            {
                pokebacksprite.BackgroundImage = Properties.Resources.charizardback;
                pokebacksprite.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (name == "Blastoise")
            {
                pokebacksprite.BackgroundImage = Properties.Resources.blastoiseback;
                pokebacksprite.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (name == "Venusaur")
            {
                pokebacksprite.BackgroundImage = Properties.Resources.venusaurback;
                pokebacksprite.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (name == "Falinks")
            {
                pokebacksprite.BackgroundImage = Properties.Resources.Fakinksback;
                pokebacksprite.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (name == "Stonjourner")
            {
                pokebacksprite.BackgroundImage = Properties.Resources.stonjournerback;
                pokebacksprite.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (name == "Unfezant")
            {
                pokebacksprite.BackgroundImage = Properties.Resources.unfezantback;
                pokebacksprite.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void setMoveColor(Button button, string type)
        {
            if (type == "Fire")
            {
                button.BackColor = Color.OrangeRed;
            }
            else if (type == "Water")
            {
                button.BackColor = Color.CornflowerBlue;
            }
            else if (type == "Grass")
            {
                button.BackColor = Color.Green;
            }
            else if (type == "Flying")
            {
                button.BackColor = Color.LightBlue;
            }
            else if (type == "Fighting")
            {
                button.BackColor = Color.DarkOrange;
            }
            else if (type == "Poison")
            {
                button.BackColor = Color.MediumPurple;
            }
            else if (type == "Normal")
            {
                button.BackColor = Color.LightGray;
            }
            else if (type == "Ground")
            {
                button.BackColor = Color.Brown;
            }
            else if (type == "Steel")
            {
                button.BackColor = Color.SlateGray;
            }
            else if (type == "Ice")
            {
                button.BackColor = Color.SkyBlue;
            }
            else if (type == "Rock")
            {
                button.BackColor = Color.SandyBrown;
            }
            else if (type == "Bug")
            {
                button.BackColor = Color.LightGreen;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            PokemonSwitchScreen switchd = new PokemonSwitchScreen(m, this);
            switchd.Show();
            this.Hide();
        }
    }
}

