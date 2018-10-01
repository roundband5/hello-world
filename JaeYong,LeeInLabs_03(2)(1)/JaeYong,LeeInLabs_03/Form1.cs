using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaeYong_LeeInLabs_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double cPi = 3.14159;

        private void btnTotalVolume_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txtRadius.Text);
            double height = double.Parse(txtHeight.Text);

            double volumePerCan = cPi * radius * radius * height;

            int numberOfCans = int.Parse(txtCounts.Text);
            double totalVolume = numberOfCans * volumePerCan;

            txtDisplay.Text = "Radius: " + radius.ToString("n") + " in\r\nHeight: " + height.ToString("n") + " in\r\nIndividual Volume: " + volumePerCan.ToString("n") + " cubic inches\r\n# of Cans: " + numberOfCans.ToString() + "\r\nTotal Volume: " + totalVolume.ToString("n") + " cubic inches";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCounts.Clear();
            txtDisplay.Clear();
            txtHeight.Clear();
            txtRadius.Clear();
            txtRadius.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
