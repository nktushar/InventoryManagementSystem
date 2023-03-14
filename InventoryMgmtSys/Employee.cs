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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            ShowEmployee();
        }
        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void ShowEmployee()
        {
            conn.Open();
            string Query = "select * from EmployeeTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            EmpGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void DeleteEmploye()
        {
            conn.Open();
            string Query = "delete from EmployeeTbl where EmpName='" + EmpNameTb.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Successfully Removed!!");
            conn.Close();
            ShowEmployee();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kabir\OneDrive\Documents\InventoryDB.mdf;Integrated Security = True; Connect Timeout = 30");


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void EmpGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmpGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAgeTb.Text = EmpGV.SelectedRows[0].Cells[2].Value.ToString();
            DesignationTb.Text = EmpGV.SelectedRows[0].Cells[3].Value.ToString();
            SalaryTb.Text = EmpGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DeleteEmploye();
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("update EmployeeTbl set EmpName='" + EmpNameTb.Text + "', EmpAge='" + EmpAgeTb.Text + "', Designatiion='" + DesignationTb.Text + "', Salary='" + SalaryTb.Text + "' where EmpName='" + EmpNameTb.Text + "'", conn);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Info Successfully Updated!!");
            conn.Close();
            ShowEmployee();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpAgeTb.Text == "" || DesignationTb.Text == "" || SalaryTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl values(@EmpName, @EmpAge, @Designation, @Salary)", conn);
                    cmd.Parameters.AddWithValue("@EmpName", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EmpAge", EmpAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Designation", DesignationTb.Text);
                    cmd.Parameters.AddWithValue("@Salary", SalaryTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Employee info Added!!!");
                    conn.Close();
                    ShowEmployee();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
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
