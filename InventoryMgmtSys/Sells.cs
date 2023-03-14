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
    public partial class Sells : Form
    {
        public Sells()
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

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kabir\OneDrive\Documents\InventoryDB.mdf;Integrated Security = True; Connect Timeout = 30");

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
                SellCat.ValueMember = "CategoryName";
                SellCat.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }

        void FillItem()
        {
            string query = "select FoodName from ItemsTbl where Category='" + SellCat.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("FoodName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                SellsItem.ValueMember = "FoodName";
                SellsItem.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }

        
        void UnitPrice()
        {
            string query = "select Price from ItemsTbl where FoodName='" + SellsItem.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Price", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Hide.ValueMember = "Price";
                Hide.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }

        private void ShowSellsRecord()
        {
            conn.Open();
            string Query = "select * from SellTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            SellGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void ShowBySearch()
        {
            conn.Open();
            string Query1 = "select * from SellTbl where Sell_Date='" + DateCombo.SelectedValue.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query1, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            SellGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        

        void FillDateCombo()
        {
            string query = "select distinct * from SellTbl";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Sell_Date", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                DateCombo.ValueMember = "Sell_Date";
                DateCombo.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

       
        private void Sells_Load(object sender, EventArgs e)
        {
            FillCategory();
            FillItem();
            ShowSellsRecord();
            FillDateCombo();
            //Amount();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            FillItem();
        }

        int Price=0, Qtty=0, Total=0;


        int P, N, T;
        string Tot;

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ShowBySearch();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ShowSellsRecord();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            UnitPrice();
            Qtt();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SellTbl values(@Sell_Date, @FoodItem, @Quantity, @UnitPrice, @SellAmount)", conn);
                cmd.Parameters.AddWithValue("@Sell_Date", DateTime.Text);
                cmd.Parameters.AddWithValue("@FoodItem", SellsItem.Text);
                cmd.Parameters.AddWithValue("@Quantity", SellQtt.Value);
                cmd.Parameters.AddWithValue("@UnitPrice", Hide.Text);
                Price = Convert.ToInt32(Hide.Text);
                Qtty = (int)SellQtt.Value;
                Total = Price * Qtty;
                cmd.Parameters.AddWithValue("@SellAmount", Total);
                cmd.ExecuteNonQuery();
                MessageBox.Show(this, "Sells info Saved!!!");


                N = Convert.ToInt32(SellQtt.Text);
                P = Convert.ToInt32(PreQtt.Text);
                T = P - N;
                Tot = T.ToString();


                SqlCommand cmd2 = new SqlCommand("update ItemsTbl set Quantity='" + Tot + "' where FoodName='" + SellsItem.Text + "'", conn);
                cmd2.ExecuteNonQuery();

                conn.Close();
                ShowSellsRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }


        void Qtt()
        {
            string query = "select Quantity from ItemsTbl where FoodName='" + SellsItem.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Quantity", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PreQtt.ValueMember = "Quantity";
                PreQtt.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }

    }
}
