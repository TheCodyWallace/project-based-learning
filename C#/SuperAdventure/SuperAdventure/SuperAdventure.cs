using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private player _player;

        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house");



            _player = new player();
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.gold = 20;
            _player.EXP = 0;
            _player.level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.gold.ToString();
            lblEXP.Text = _player.EXP.ToString();
            lblLevel.Text = _player.level.ToString();

        }

        
        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}
