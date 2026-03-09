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
        private Player _player;

        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house");



<<<<<<< HEAD
            _player = new Player(10,10,20,0,1);
=======
            _player = new player();
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.gold = 20;
            _player.EXP = 0;
            _player.level = 1;
>>>>>>> c4d2a1f93fdbba99709fb0f9d17deba1db76cdee

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblEXP.Text = _player.EXP.ToString();
            lblLevel.Text = _player.Level.ToString();

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
