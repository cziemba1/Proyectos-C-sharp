using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         int firstNumber;
         int secondNumber;
         int thirdNumber;
         double average;
        private void BtnAverage_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Por favor ingrese un numero", "Averages", "", 120,120));

            secondNumber =
                int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Por favor igrese otro numero", "Averages", "",
                    120, 120));

            thirdNumber =
                int.Parse(Microsoft.VisualBasic.Interaction.InputBox("POr favor ingrese otro numero", "Averages", "",
                    120, 120));

            average = (double)(firstNumber + secondNumber + thirdNumber) / 3;

            MessageBox.Show($"Your average is {average}");
        }
    }
}
