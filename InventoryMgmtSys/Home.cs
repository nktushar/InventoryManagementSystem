using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InventoryMgmtSys
{
    public partial class Home : Form
    {
       

        public Home()
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
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Stock obj = new Stock();
            obj.ShowDialog();
            //this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click_1(object sender, EventArgs e)
        {
            FoodItems obj = new FoodItems();
            obj.Show();
            this.Hide();
        }

        private void SellInfo_Click(object sender, EventArgs e)
        {
            Sells obj = new Sells();
            obj.Show();
            this.Hide();
        }

        private void ManageEmployee_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void ManageUser_Click(object sender, EventArgs e)
        {
            User obj = new User();
            obj.Show();
            this.Hide();
        }

        private void ManageCat_Click(object sender, EventArgs e)
        {
            Category obj = new Category();
            obj.Show();
            this.Hide();
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
