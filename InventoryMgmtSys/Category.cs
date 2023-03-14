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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            ShowCategory();
        }

        private void ShowCategory()
        {
            conn.Open();
            string Query = "select * from CategoryTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CategoryGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kabir\OneDrive\Documents\InventoryDB.mdf;Integrated Security = True; Connect Timeout = 30");


        private void DeleteCategory()
        {
            conn.Open();
            string Query = "delete from CategoryTbl where CategoryName='" + CatNameTb.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category Successfully Deleted!!");
            conn.Close();
            ShowCategory();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }


        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatNameTb.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl values(@CategoryName)", conn);
                    cmd.Parameters.AddWithValue("@CategoryName", CatNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Category Saved!!!");
                    conn.Close();
                    ShowCategory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
