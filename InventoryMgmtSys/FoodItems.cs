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
    public partial class FoodItems : Form
    {
        public FoodItems()
        {
            InitializeComponent();
            ShowItems();
        }
        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void ShowItems()
        {
            conn.Open();
            string Query = "select FoodName, Category, Price, Quantity from ItemsTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            FoodItemsGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        void SelectItem()
        {
            string query = "select FoodName from ItemsTbl";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("FoodName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                SlctFood.ValueMember = "FoodName";
                SlctFood.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }

        private void DeleteItems()
        {
            conn.Open();
            string Query = "delete from ItemsTbl where FoodName='"+FoodNameTb.Text+"'";
            SqlCommand cmd=new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item Successfully Removed!!");
            conn.Close();
            ShowItems();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kabir\OneDrive\Documents\InventoryDB.mdf;Integrated Security = True; Connect Timeout = 30");


        

        void HideQtt()
        {
            string query = "select Quantity from ItemsTbl where FoodName='"+SlctFood.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Quantity", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                hideqtt.ValueMember = "Quantity";
                hideqtt.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }


        void FillCategory()
        {
            string query = "select * from CategoryTbl"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CategoryName";
                CatCombo.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }


        private void FoodItems_Load(object sender, EventArgs e)
        {
            FillCategory();
            SelectItem();
            HideQtt();
        }


        private void CatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void FoodItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FoodNameTb.Text = FoodItemsGV.SelectedRows[0].Cells[0].Value.ToString();
            CatCombo.Text = FoodItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            FoodPriceTb.Text = FoodItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            FoodQttTb.Text = FoodItemsGV.SelectedRows[0].Cells[3].Value.ToString();
            

        }


        string NewQtt;
        int Pre, New, Total;

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update ItemsTbl set FoodName='" + FoodNameTb.Text + "', Category='" + CatCombo.Text + "', Price='" + FoodPriceTb.Text + "', Quantity='" + FoodQttTb.Text + "' where FoodName='" + FoodNameTb.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item Successfully Updated!!");
            conn.Close();
            ShowItems();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }


        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            HideQtt();

            try
            {
                conn.Open();
                Pre = Convert.ToInt32(hideqtt.Text);
                New = Convert.ToInt32(Qntty.Text);
                Total = Pre + New;
                NewQtt = Total.ToString();
                SqlCommand cmd = new SqlCommand("update ItemsTbl set Quantity='" + NewQtt + "' where FoodName='" + SlctFood.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added!!");
                conn.Close();
                ShowItems();
            }
            catch
            {

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            if (FoodNameTb.Text == "" || FoodPriceTb.Text == "" || FoodQttTb.Text == "" || CatCombo.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into ItemsTbl values(@FoodName, @Category, @Price, @Quantity)", conn);
                    cmd.Parameters.AddWithValue("@FoodName", FoodNameTb.Text);
                    cmd.Parameters.AddWithValue("@Category", CatCombo.Text);
                    cmd.Parameters.AddWithValue("@Price", FoodPriceTb.Text);
                    cmd.Parameters.AddWithValue("@Quantity", FoodQttTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "New Item Saved!!!");
                    conn.Close();
                    ShowItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
