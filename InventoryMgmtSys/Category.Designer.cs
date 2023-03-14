namespace InventoryMgmtSys
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.CategoryGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CatNameTb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new ePOSOne.btnProduct.Button_WOC();
            this.DeleteBut = new FontAwesome.Sharp.IconButton();
            this.AddBut = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryGV
            // 
            this.CategoryGV.AllowUserToAddRows = false;
            this.CategoryGV.AllowUserToDeleteRows = false;
            this.CategoryGV.AllowUserToResizeRows = false;
            this.CategoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGV.BackgroundColor = System.Drawing.Color.MistyRose;
            this.CategoryGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGV.EnableHeadersVisualStyles = false;
            this.CategoryGV.GridColor = System.Drawing.Color.MistyRose;
            this.CategoryGV.Location = new System.Drawing.Point(739, 107);
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.RowHeadersVisible = false;
            this.CategoryGV.RowHeadersWidth = 51;
            this.CategoryGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CategoryGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
            this.CategoryGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CategoryGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CategoryGV.RowTemplate.Height = 29;
            this.CategoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGV.Size = new System.Drawing.Size(508, 582);
            this.CategoryGV.TabIndex = 26;
            this.CategoryGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(78, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Category Name :";
            // 
            // CatNameTb
            // 
            this.CatNameTb.BackColor = System.Drawing.Color.LavenderBlush;
            this.CatNameTb.Location = new System.Drawing.Point(255, 283);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(343, 47);
            this.CatNameTb.TabIndex = 18;
            this.CatNameTb.Text = "";
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
            this.panel1.TabIndex = 87;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.label1.Location = new System.Drawing.Point(498, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 687);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1247, 14);
            this.panel4.TabIndex = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 621);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
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
            this.Home.TabIndex = 92;
            this.Home.Text = "HOME";
            this.Home.TextColor = System.Drawing.Color.Black;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBut.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.DeleteBut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBut.IconSize = 40;
            this.DeleteBut.Location = new System.Drawing.Point(465, 353);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(132, 53);
            this.DeleteBut.TabIndex = 91;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBut.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddBut.IconColor = System.Drawing.Color.Green;
            this.AddBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBut.IconSize = 40;
            this.AddBut.Location = new System.Drawing.Point(255, 352);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(132, 54);
            this.AddBut.TabIndex = 89;
            this.AddBut.Text = "Add";
            this.AddBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CategoryGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CatNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CategoryGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox CatNameTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC Home;
        private FontAwesome.Sharp.IconButton DeleteBut;
        private FontAwesome.Sharp.IconButton AddBut;
    }
}