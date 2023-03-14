namespace InventoryMgmtSys
{
    partial class FoodItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodItems));
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FoodItemsGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FoodQttTb = new System.Windows.Forms.RichTextBox();
            this.FoodPriceTb = new System.Windows.Forms.RichTextBox();
            this.FoodNameTb = new System.Windows.Forms.RichTextBox();
            this.SlctFood = new System.Windows.Forms.ComboBox();
            this.Qntty = new System.Windows.Forms.NumericUpDown();
            this.hideqtt = new System.Windows.Forms.ComboBox();
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
            this.button_woc3 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.FoodItemsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qntty)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatCombo
            // 
            this.CatCombo.BackColor = System.Drawing.Color.Honeydew;
            this.CatCombo.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(36, 392);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(275, 31);
            this.CatCombo.TabIndex = 37;
            this.CatCombo.Text = "SelectCategory";
            this.CatCombo.SelectedIndexChanged += new System.EventHandler(this.CatCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(450, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 35);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quantity Control:";
            // 
            // FoodItemsGV
            // 
            this.FoodItemsGV.AllowUserToAddRows = false;
            this.FoodItemsGV.AllowUserToDeleteRows = false;
            this.FoodItemsGV.AllowUserToResizeRows = false;
            this.FoodItemsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FoodItemsGV.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.FoodItemsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodItemsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FoodItemsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FoodItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodItemsGV.EnableHeadersVisualStyles = false;
            this.FoodItemsGV.GridColor = System.Drawing.Color.PowderBlue;
            this.FoodItemsGV.Location = new System.Drawing.Point(347, 167);
            this.FoodItemsGV.Name = "FoodItemsGV";
            this.FoodItemsGV.RowHeadersVisible = false;
            this.FoodItemsGV.RowHeadersWidth = 51;
            this.FoodItemsGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FoodItemsGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.FoodItemsGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodItemsGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.FoodItemsGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.FoodItemsGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.FoodItemsGV.RowTemplate.Height = 29;
            this.FoodItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodItemsGV.Size = new System.Drawing.Size(900, 522);
            this.FoodItemsGV.TabIndex = 35;
            this.FoodItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodItemsGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(27, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(27, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "FoodName :";
            // 
            // FoodQttTb
            // 
            this.FoodQttTb.BackColor = System.Drawing.Color.Honeydew;
            this.FoodQttTb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodQttTb.Location = new System.Drawing.Point(36, 318);
            this.FoodQttTb.Name = "FoodQttTb";
            this.FoodQttTb.Size = new System.Drawing.Size(275, 39);
            this.FoodQttTb.TabIndex = 25;
            this.FoodQttTb.Text = "";
            // 
            // FoodPriceTb
            // 
            this.FoodPriceTb.BackColor = System.Drawing.Color.Honeydew;
            this.FoodPriceTb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodPriceTb.Location = new System.Drawing.Point(36, 239);
            this.FoodPriceTb.Name = "FoodPriceTb";
            this.FoodPriceTb.Size = new System.Drawing.Size(275, 39);
            this.FoodPriceTb.TabIndex = 26;
            this.FoodPriceTb.Text = "";
            // 
            // FoodNameTb
            // 
            this.FoodNameTb.BackColor = System.Drawing.Color.Honeydew;
            this.FoodNameTb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodNameTb.Location = new System.Drawing.Point(36, 158);
            this.FoodNameTb.Name = "FoodNameTb";
            this.FoodNameTb.Size = new System.Drawing.Size(275, 39);
            this.FoodNameTb.TabIndex = 27;
            this.FoodNameTb.Text = "";
            // 
            // SlctFood
            // 
            this.SlctFood.BackColor = System.Drawing.Color.Honeydew;
            this.SlctFood.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SlctFood.FormattingEnabled = true;
            this.SlctFood.Location = new System.Drawing.Point(685, 126);
            this.SlctFood.Name = "SlctFood";
            this.SlctFood.Size = new System.Drawing.Size(207, 31);
            this.SlctFood.TabIndex = 39;
            this.SlctFood.Text = "Select Food Item";
            // 
            // Qntty
            // 
            this.Qntty.BackColor = System.Drawing.Color.Honeydew;
            this.Qntty.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Qntty.Location = new System.Drawing.Point(910, 126);
            this.Qntty.Name = "Qntty";
            this.Qntty.Size = new System.Drawing.Size(150, 29);
            this.Qntty.TabIndex = 40;
            // 
            // hideqtt
            // 
            this.hideqtt.FormattingEnabled = true;
            this.hideqtt.Location = new System.Drawing.Point(1211, 126);
            this.hideqtt.Name = "hideqtt";
            this.hideqtt.Size = new System.Drawing.Size(24, 28);
            this.hideqtt.TabIndex = 42;
            this.hideqtt.Visible = false;
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
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(385, 20);
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
            this.label1.Location = new System.Drawing.Point(477, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Food Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 687);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 14);
            this.panel3.TabIndex = 44;
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBut.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.DeleteBut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBut.IconSize = 40;
            this.DeleteBut.Location = new System.Drawing.Point(110, 512);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(132, 53);
            this.DeleteBut.TabIndex = 47;
            this.DeleteBut.Text = "Remove";
            this.DeleteBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBut.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.UpdateBut.IconColor = System.Drawing.Color.Navy;
            this.UpdateBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateBut.IconSize = 40;
            this.UpdateBut.Location = new System.Drawing.Point(179, 452);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(132, 54);
            this.UpdateBut.TabIndex = 46;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBut.UseVisualStyleBackColor = false;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddBut.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBut.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddBut.IconColor = System.Drawing.Color.Green;
            this.AddBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBut.IconSize = 40;
            this.AddBut.Location = new System.Drawing.Point(36, 452);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(132, 54);
            this.AddBut.TabIndex = 45;
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
            this.pictureBox1.TabIndex = 49;
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
            this.Home.TabIndex = 48;
            this.Home.Text = "HOME";
            this.Home.TextColor = System.Drawing.Color.Black;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // button_woc3
            // 
            this.button_woc3.BackColor = System.Drawing.Color.Transparent;
            this.button_woc3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_woc3.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button_woc3.ButtonColor = System.Drawing.Color.DarkGreen;
            this.button_woc3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_woc3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_woc3.FlatAppearance.BorderSize = 0;
            this.button_woc3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_woc3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_woc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_woc3.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc3.Location = new System.Drawing.Point(1077, 119);
            this.button_woc3.Name = "button_woc3";
            this.button_woc3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_woc3.OnHoverButtonColor = System.Drawing.Color.LightGreen;
            this.button_woc3.OnHoverTextColor = System.Drawing.Color.DarkGreen;
            this.button_woc3.Size = new System.Drawing.Size(71, 39);
            this.button_woc3.TabIndex = 65;
            this.button_woc3.Text = "+";
            this.button_woc3.TextColor = System.Drawing.Color.White;
            this.button_woc3.UseVisualStyleBackColor = false;
            this.button_woc3.Click += new System.EventHandler(this.button_woc3_Click);
            // 
            // FoodItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_woc3);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.hideqtt);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FoodNameTb);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Qntty);
            this.Controls.Add(this.SlctFood);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FoodItemsGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FoodQttTb);
            this.Controls.Add(this.FoodPriceTb);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.FoodItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodItemsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qntty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView FoodItemsGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox FoodQttTb;
        private System.Windows.Forms.RichTextBox FoodPriceTb;
        private System.Windows.Forms.RichTextBox FoodNameTb;
        private System.Windows.Forms.ComboBox SlctFood;
        private System.Windows.Forms.NumericUpDown Qntty;
        private System.Windows.Forms.ComboBox hideqtt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton DeleteBut;
        private FontAwesome.Sharp.IconButton UpdateBut;
        private FontAwesome.Sharp.IconButton AddBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC Home;
        private ePOSOne.btnProduct.Button_WOC button_woc3;
    }
}