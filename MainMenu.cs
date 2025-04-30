using System;
using System.Windows.Forms;


namespace PokemonProjectv2
{
    public partial class MainMenu : Form
    {
        public MatchSetUp m { get; set; }
        public MainMenu(MatchSetUp match)
        {
            this.m = match;
            InitializeComponent();
        }
        public void Venusaur_Click(object sender, EventArgs e)
        {
            Pokemon venusaur = new Pokemon("Venusaur");
            m.user.add(venusaur);
            UserTeamListBox.Items.Add(venusaur.IDname);
        }

        public void Blastoise_Click(object sender, EventArgs e)
        {
            Pokemon blastoise = new Pokemon("Blastoise");
            m.user.add(blastoise);
            UserTeamListBox.Items.Add(blastoise.IDname);
        }
        public void Charizard_Click(object sender, EventArgs e)
        {
            Pokemon charizard = new Pokemon("Charizard");
            m.user.add(charizard);
            UserTeamListBox.Items.Add(charizard.IDname);
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBattle_Click_1(object sender, EventArgs e)
        {
            int t = m.user.total;
            if (t == 0)
            {
                MessageBox.Show("Please Add a Pokemon Before Starting the Battle!");
            }
            else
            {
                // create NPC's team
                Random rnd = new Random();
                for (int i = 0; i < t; i++)
                {
                    int r = rnd.Next(6);
                    if (r == 0)
                    {
                        Pokemon v = new Pokemon("Venusaur");
                        m.NPC.add(v);
                    }
                    else if (r == 1)
                    {
                        Pokemon c = new Pokemon("Charizard");
                        m.NPC.add(c);
                    }
                    else if (r == 2)
                    {
                        Pokemon b = new Pokemon("Blastoise");
                        m.NPC.add(b);
                    }
                    else if (r == 3)
                    {
                        Pokemon u = new Pokemon("Unfezant");
                        m.NPC.add(u);
                    }
                    else if (r == 4)
                    {
                        Pokemon f = new Pokemon("Falinks");
                        m.NPC.add(f);
                    }
                    else if (r == 5)
                    {
                        Pokemon s = new Pokemon("Stonjourner");
                        m.NPC.add(s);
                    }

                }
                BattleScreen battle = new BattleScreen(m);
                battle.Show();
                this.Hide();

            }
        }

        private void Stonjourner_Click(object sender, EventArgs e)
        {
            Pokemon stonjourner = new Pokemon("Stonjourner");
            m.user.add(stonjourner);
            UserTeamListBox.Items.Add(stonjourner.IDname);

        }

        private void Unfezant_Click(object sender, EventArgs e)
        {
            Pokemon unfezant = new Pokemon("Unfezant");
            m.user.add(unfezant);
            UserTeamListBox.Items.Add(unfezant.IDname);
        }

        private void Falinks_Click(object sender, EventArgs e)
        {
            Pokemon falinks = new Pokemon("Falinks");
            m.user.add(falinks);
            UserTeamListBox.Items.Add(falinks.IDname);
        }
    }
}
