using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonProjectv2
{
    public partial class BattleScreen : Form
    {
        private MatchSetUp m;
        public BattleScreen(MatchSetUp m)
        {
            InitializeComponent();
            this.m = m;
        }
    }
}
