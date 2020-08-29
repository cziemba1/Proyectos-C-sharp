using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void btbWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome Claudia");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye Claudia");
        }

        private void btnRadioSad_CheckedChanged(object sender, EventArgs e)
        {
            imgHappy.Visible = false;
            imgSad.Visible = true;
        }

        private void btnRadioHappy_CheckedChanged(object sender, EventArgs e)
        {
            imgHappy.Visible = true;
            imgSad.Visible = false;
        }
    }
}
