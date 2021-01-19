using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            lblDisplayInfo.Text = "Hello World!";
        }

        private void lblDisplayInfo_Click(object sender, EventArgs e)
        {

        }

        private void bntMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for clicking my button!");
        }

        private void bntGoodbye_Click(object sender, EventArgs e)
        {
            lblDisplayInfo.Text = "Goodbye World";
        }

        private void bntShowPic_Click(object sender, EventArgs e)
        {
            gifEarth.Visible = true;
        }

        private void bntHideWorld_Click(object sender, EventArgs e)
        {
            gifEarth.Visible = false;
        }

        private void gifEarth_Click(object sender, EventArgs e)
        {
            gifEarth.Visible = false;
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
