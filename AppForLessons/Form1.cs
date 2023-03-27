using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForLessons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                new Dashboarad().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User data is invalid! TRY AGAIN!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ExitBoxLog_MouseHover(object sender, EventArgs e)
        {
            ExitBoxLog.BackColor = System.Drawing.Color.Red;
        }

        private void ExitBoxLog_MouseLeave(object sender, EventArgs e)
        {
            ExitBoxLog.BackColor = System.Drawing.Color.GhostWhite;
        }
    }
}
