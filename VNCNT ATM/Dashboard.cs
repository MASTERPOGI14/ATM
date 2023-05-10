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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            this.Hide();
            with.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            this.Hide();
            dep.ShowDialog();

        }
    }
}
