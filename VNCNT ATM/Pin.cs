using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNCNT_ATM
{
    public partial class Pin : Form
    {
        public int enterAttempt = 0;

        public Pin()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int number = +1;
            txtPin.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = +2;
            txtPin.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = +3;
            txtPin.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = +4;
            txtPin.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = +5;
            txtPin.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = +6;
            txtPin.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = +7;
            txtPin.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = +8;
            txtPin.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = +9;
            txtPin.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = +0;
            txtPin.Text += number;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtPin.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == "1414")
            {
                Dashboard dashboard = new Dashboard();
                this.Hide()
; dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong PIN!");
                Reset();

                enterAttempt += 1;

                if (enterAttempt == 3)
                {
                    MessageBox.Show("You have exceeded the number of maximum attempts!", "Your account has been disabled.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPin.Enabled = false;
                    button12.Enabled = false;
                }
            }
        }
            public void Reset()
            {
                txtPin.Text = string.Empty;
            }
        }
}
