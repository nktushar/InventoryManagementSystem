using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace InventoryMgmtSys
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();  
            ShowUser();
        }
        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void ShowUser()
        {
            conn.Open();
            string Query = "select * from UserTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void DeleteUser()
        {
            conn.Open();
            string Query = "delete from UserTbl where UserName='" + UnameTb.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Removed!!");
            conn.Close();
            ShowUser();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kabir\OneDrive\Documents\InventoryDB.mdf;Integrated Security = True; Connect Timeout = 30");
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl values(@UserName, @FullName, @Password, @Phone)", conn);
                    cmd.Parameters.AddWithValue("@UserName", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@FullName", FnameTb.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "User info Added!!!");
                    conn.Close();
                    ShowUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update UserTbl set UserName='" + UnameTb.Text + "', FullName='" + FnameTb.Text + "', Password='" + PasswordTb.Text + "', Phone='" + PhoneTb.Text + "' where UserName='" + UnameTb.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Info. Successfully Updated!!");
            conn.Close();
            ShowUser();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
