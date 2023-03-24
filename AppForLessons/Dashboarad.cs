using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForLessons
{
    public partial class Dashboarad : Form
    {
        public Dashboarad()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
            MessageBox.Show("You are logged out!");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 y = new Form2();
            y.Show();
        }

        private void Dashboarad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void workHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 z = new Form3();
            z.Show();
        }
    }
}
