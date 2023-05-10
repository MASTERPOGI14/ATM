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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double amt;
            amt = Convert.ToDouble(txtAmt.Text);

            if (amt <= 13000)
            {
                MessageBox.Show("Expel Money!", "Please get your cash.",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Insufficient Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard= new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
    }

