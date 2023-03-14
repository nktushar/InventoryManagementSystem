using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace InventoryMgmtSys
{
    public partial class Login : Form
    {
       // SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kabir\OneDrive\Documents\InventoryDB.mdf;Integrated Security = True; Connect Timeout = 30");
        public Login()
        {
            InitializeComponent();
            
        }

        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
           


            if (username != string.Empty)
            {
                if (password != string.Empty)
                {

                    if (username == "admin" && password == "123")
                    {
                        Home obj = new Home();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Creditionals !", "Miss-Match Information");

                    }
                }
                else
                    MessageBox.Show("Password Can't be Empty!", "Miss-Match Information");
            }
            else
                MessageBox.Show("Username Can't be Empty!", "Miss-Match Information");
            
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if(ShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar=true;
            }
        }
    }
}
