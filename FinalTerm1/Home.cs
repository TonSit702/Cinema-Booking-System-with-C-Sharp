using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTerm1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btticket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Getticket main = new Getticket();
            main.ShowDialog();
        }

        private void btlistticket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report main = new Report();
            main.ShowDialog();
        }

        private void btmanagemv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage main = new Manage();
            main.ShowDialog();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register main = new Register();
            main.ShowDialog();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.ShowDialog();
        }
    }
}
