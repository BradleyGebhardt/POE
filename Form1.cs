using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POEAssignment
{
    public partial class Form1 : Form
    {
        GameEngine engine;

        public Form1()
        {
            InitializeComponent();

            engine = new GameEngine();
            lblMap.Text = engine.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            engine.GetMap().MoveHero(Character.MovementEnum.Up);
            lblMap.Text = engine.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WeaponRange_Label_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            engine.GetMap().MoveHero(Character.MovementEnum.Down);
            lblMap.Text = engine.ToString();
        }
    }
}
