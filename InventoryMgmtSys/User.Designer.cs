namespace InventoryMgmtSys
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.RichTextBox();
            this.PasswordTb = new System.Windows.Forms.RichTextBox();
            this.FnameTb = new System.Windows.Forms.RichTextBox();
            this.UnameTb = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddBut = new FontAwesome.Sharp.IconButton();
            this.UpdateBut = new FontAwesome.Sharp.IconButton();
            this.DeleteBut = new FontAwesome.Sharp.IconButton();
            this.Home = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersGV
            // 
            this.UsersGV.AllowUserToAddRows = false;
            this.UsersGV.AllowUserToDeleteRows = false;
            this.UsersGV.AllowUserToResizeRows = false;
            this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGV.BackgroundColor = System.Drawing.Color.LightCyan;
            this.UsersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.UsersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGV.ColumnHeadersHeight = 35;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGV.EnableHeadersVisualStyles = false;
            this.UsersGV.GridColor = System.Drawing.Color.LightCyan;
            this.UsersGV.Location = new System.Drawing.Point(400, 111);
            this.UsersGV.Name = "UsersGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowHeadersWidth = 51;
            this.UsersGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UsersGV.RowTemplate.Height = 29;
            this.UsersGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGV.Size = new System.Drawing.Size(847, 578);
            this.UsersGV.TabIndex = 52;
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(27, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(27, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(27, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "FullName :";
            // 
            // PhoneTb
            // 
            this.PhoneTb.BackColor = System.Drawing.Color.AliceBlue;
            this.PhoneTb.Location = new System.Drawing.Point(36, 395);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(275, 39);
            this.PhoneTb.TabIndex = 8;
            this.PhoneTb.Text = "";
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.Color.AliceBlue;
            this.PasswordTb.Location = new System.Drawing.Point(36, 318);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(275, 39);
            this.PasswordTb.TabIndex = 9;
            this.PasswordTb.Text = "";
            // 
            // FnameTb
            // 
            this.FnameTb.BackColor = System.Drawing.Color.AliceBlue;
            this.FnameTb.Location = new System.Drawing.Point(36, 239);
            this.FnameTb.Name = "FnameTb";
            this.FnameTb.Size = new System.Drawing.Size(275, 39);
            this.FnameTb.TabIndex = 10;
            this.FnameTb.Text = "";
            this.FnameTb.TextChanged += new System.EventHandler(this.FnameTb_TextChanged);
            // 
            // UnameTb
            // 
            this.UnameTb.BackColor = System.Drawing.Color.AliceBlue;
            this.UnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnameTb.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnameTb.Location = new System.Drawing.Point(36, 164);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(275, 39);
            this.UnameTb.TabIndex = 11;
            this.UnameTb.Text = "";
            this.UnameTb.TextChanged += new System.EventHandler(this.UnameTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "UserName :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(444, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
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
            this.label1.Location = new System.Drawing.Point(536, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 14);
            this.panel2.TabIndex = 29;
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
            this.AddBut.TabIndex = 30;
            this.AddBut.Text = "Add";
            this.AddBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
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
            this.UpdateBut.TabIndex = 31;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBut.UseVisualStyleBackColor = false;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
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
            this.DeleteBut.TabIndex = 32;
            this.DeleteBut.Text = "Remove";
            this.DeleteBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
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
            this.Home.TabIndex = 38;
            this.Home.Text = "HOME";
            this.Home.TextColor = System.Drawing.Color.Black;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 621);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1247, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.FnameTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UsersGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox PhoneTb;
        private System.Windows.Forms.RichTextBox PasswordTb;
        private System.Windows.Forms.RichTextBox FnameTb;
        private System.Windows.Forms.RichTextBox UnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton AddBut;
        private FontAwesome.Sharp.IconButton UpdateBut;
        private FontAwesome.Sharp.IconButton DeleteBut;
        private ePOSOne.btnProduct.Button_WOC Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}