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
    public partial class Stock : Form
    {
        public Stock()
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


        private void quantityControl()
        {
            conn.Open();
            string Query = "select FoodName, Category, Price, Quantity from ItemsTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            StockGV.DataSource = ds.Tables[0];

            int numRows = StockGV.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {

                int quantityColumn;
                string getQuantity;  
                getQuantity = StockGV.Rows[i].Cells[3].Value.ToString();
                quantityColumn = Convert.ToInt32(getQuantity);
                if (quantityColumn <= 10 )
                {

                    StockGV.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 18, 101);
                    StockGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    StockGV.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 18, 101);
                    StockGV.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            conn.Close();
        }
        private void ShowItems()
        {
          
            quantityControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            ShowItems();
            
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
