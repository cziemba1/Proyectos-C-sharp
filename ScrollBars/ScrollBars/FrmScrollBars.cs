using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBars
{
    public partial class FrmScrollBars : Form
    {
        public FrmScrollBars()
        {
            InitializeComponent();
        }

        private void HsbDemo_Scroll(object sender, ScrollEventArgs e)
        {
            LblDemo.Text = HsbDemo.Value.ToString();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Firebrick;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateBlue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BurlyWood;
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            FrmImage x = new FrmImage();
            x.Show();
        }
    }
}
