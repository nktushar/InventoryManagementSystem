namespace InventoryMgmtSys
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label6 = new System.Windows.Forms.Label();
            this.SalaryTb = new System.Windows.Forms.RichTextBox();
            this.EmpGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesignationTb = new System.Windows.Forms.RichTextBox();
            this.EmpAgeTb = new System.Windows.Forms.RichTextBox();
            this.EmpNameTb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteBut = new FontAwesome.Sharp.IconButton();
            this.UpdateBut = new FontAwesome.Sharp.IconButton();
            this.AddBut = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(26, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Salary :";
            // 
            // SalaryTb
            // 
            this.SalaryTb.BackColor = System.Drawing.Color.LavenderBlush;
            this.SalaryTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryTb.Location = new System.Drawing.Point(36, 395);
            this.SalaryTb.Name = "SalaryTb";
            this.SalaryTb.Size = new System.Drawing.Size(275, 39);
            this.SalaryTb.TabIndex = 55;
            this.SalaryTb.Text = "";
            // 
            // EmpGV
            // 
            this.EmpGV.AllowUserToAddRows = false;
            this.EmpGV.AllowUserToDeleteRows = false;
            this.EmpGV.AllowUserToResizeRows = false;
            this.EmpGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpGV.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.EmpGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmpGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.EmpGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpGV.ColumnHeadersHeight = 35;
            this.EmpGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmpGV.EnableHeadersVisualStyles = false;
            this.EmpGV.GridColor = System.Drawing.Color.PowderBlue;
            this.EmpGV.Location = new System.Drawing.Point(347, 112);
            this.EmpGV.Name = "EmpGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmpGV.RowHeadersVisible = false;
            this.EmpGV.RowHeadersWidth = 51;
            this.EmpGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmpGV.RowTemplate.Height = 29;
            this.EmpGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmpGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpGV.Size = new System.Drawing.Size(900, 577);
            this.EmpGV.TabIndex = 52;
            this.EmpGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(26, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Designation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(26, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Employee\'s Name :";
            // 
            // DesignationTb
            // 
            this.DesignationTb.BackColor = System.Drawing.Color.LavenderBlush;
            this.DesignationTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DesignationTb.Location = new System.Drawing.Point(36, 318);
            this.DesignationTb.Name = "DesignationTb";
            this.DesignationTb.Size = new System.Drawing.Size(275, 39);
            this.DesignationTb.TabIndex = 42;
            this.DesignationTb.Text = "";
            // 
            // EmpAgeTb
            // 
            this.EmpAgeTb.BackColor = System.Drawing.Color.LavenderBlush;
            this.EmpAgeTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpAgeTb.Location = new System.Drawing.Point(36, 239);
            this.EmpAgeTb.Name = "EmpAgeTb";
            this.EmpAgeTb.Size = new System.Drawing.Size(275, 39);
            this.EmpAgeTb.TabIndex = 43;
            this.EmpAgeTb.Text = "";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.BackColor = System.Drawing.Color.LavenderBlush;
            this.EmpNameTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpNameTb.Location = new System.Drawing.Point(36, 164);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(275, 39);
            this.EmpNameTb.TabIndex = 44;
            this.EmpNameTb.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button_woc1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 113);
            this.panel1.TabIndex = 57;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_woc1
            // 
            this.button_woc1.BackColor = System.Drawing.Color.Transparent;
            this.button_woc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_woc1.BorderColor = System.Drawing.Color.Black;
            this.button_woc1.ButtonColor = System.Drawing.Color.Crimson;
            this.button_woc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_woc1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_woc1.FlatAppearance.BorderSize = 0;
            this.button_woc1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_woc1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_woc1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc1.Location = new System.Drawing.Point(1211, 3);
            this.button_woc1.Name = "button_woc1";
            this.button_woc1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_woc1.OnHoverButtonColor = System.Drawing.Color.Honeydew;
            this.button_woc1.OnHoverTextColor = System.Drawing.Color.Red;
            this.button_woc1.Size = new System.Drawing.Size(33, 31);
            this.button_woc1.TabIndex = 40;
            this.button_woc1.Text = "X";
            this.button_woc1.TextColor = System.Drawing.Color.White;
            this.button_woc1.UseVisualStyleBackColor = false;
            this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(481, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 687);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 14);
            this.panel3.TabIndex = 58;
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBut.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.DeleteBut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBut.IconSize = 40;
            this.DeleteBut.Location = new System.Drawing.Point(110, 512);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(132, 53);
            this.DeleteBut.TabIndex = 61;
            this.DeleteBut.Text = "Remove";
            this.DeleteBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBut.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.UpdateBut.IconColor = System.Drawing.Color.Navy;
            this.UpdateBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateBut.IconSize = 40;
            this.UpdateBut.Location = new System.Drawing.Point(179, 452);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(132, 54);
            this.UpdateBut.TabIndex = 60;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBut.UseVisualStyleBackColor = false;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBut.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddBut.IconColor = System.Drawing.Color.Green;
            this.AddBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBut.IconSize = 40;
            this.AddBut.Location = new System.Drawing.Point(36, 452);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(132, 54);
            this.AddBut.TabIndex = 59;
            this.AddBut.Text = "Add";
            this.AddBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 621);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Home.BorderColor = System.Drawing.Color.Black;
            this.Home.ButtonColor = System.Drawing.Color.CadetBlue;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home.Location = new System.Drawing.Point(91, 621);
            this.Home.Name = "Home";
            this.Home.OnHoverBorderColor = System.Drawing.Color.DarkCyan;
            this.Home.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.Home.OnHoverTextColor = System.Drawing.Color.White;
            this.Home.Size = new System.Drawing.Size(151, 48);
            this.Home.TabIndex = 62;
            this.Home.Text = "HOME";
            this.Home.TextColor = System.Drawing.Color.Black;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SalaryTb);
            this.Controls.Add(this.EmpGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DesignationTb);
            this.Controls.Add(this.EmpAgeTb);
            this.Controls.Add(this.EmpNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox SalaryTb;
        private System.Windows.Forms.DataGridView EmpGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DesignationTb;
        private System.Windows.Forms.RichTextBox EmpAgeTb;
        private System.Windows.Forms.RichTextBox EmpNameTb;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton DeleteBut;
        private FontAwesome.Sharp.IconButton UpdateBut;
        private FontAwesome.Sharp.IconButton AddBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC Home;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}