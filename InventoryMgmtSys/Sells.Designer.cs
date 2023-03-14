namespace InventoryMgmtSys
{
    partial class Sells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sells));
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.SellCat = new System.Windows.Forms.ComboBox();
            this.SellsItem = new System.Windows.Forms.ComboBox();
            this.SellQtt = new System.Windows.Forms.NumericUpDown();
            this.SellGV = new System.Windows.Forms.DataGridView();
            this.Ok = new System.Windows.Forms.Button();
            this.DateCombo = new System.Windows.Forms.ComboBox();
            this.Hide = new System.Windows.Forms.ComboBox();
            this.PreQtt = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new ePOSOne.btnProduct.Button_WOC();
            this.AddBut = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SellQtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTime
            // 
            this.DateTime.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateTime.CustomFormat = "dd/MM/yyy";
            this.DateTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(36, 164);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(275, 31);
            this.DateTime.TabIndex = 72;
            this.DateTime.Tag = "";
            this.DateTime.Value = new System.DateTime(2021, 12, 27, 23, 56, 23, 0);
            // 
            // SellCat
            // 
            this.SellCat.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SellCat.FormattingEnabled = true;
            this.SellCat.Location = new System.Drawing.Point(36, 239);
            this.SellCat.Name = "SellCat";
            this.SellCat.Size = new System.Drawing.Size(220, 31);
            this.SellCat.TabIndex = 73;
            this.SellCat.Text = "Category";
            // 
            // SellsItem
            // 
            this.SellsItem.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SellsItem.FormattingEnabled = true;
            this.SellsItem.Location = new System.Drawing.Point(36, 318);
            this.SellsItem.Name = "SellsItem";
            this.SellsItem.Size = new System.Drawing.Size(275, 31);
            this.SellsItem.TabIndex = 74;
            this.SellsItem.Text = "Item";
            this.SellsItem.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // SellQtt
            // 
            this.SellQtt.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SellQtt.Location = new System.Drawing.Point(36, 392);
            this.SellQtt.Name = "SellQtt";
            this.SellQtt.Size = new System.Drawing.Size(275, 27);
            this.SellQtt.TabIndex = 75;
            this.SellQtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SellGV
            // 
            this.SellGV.AllowUserToAddRows = false;
            this.SellGV.AllowUserToDeleteRows = false;
            this.SellGV.AllowUserToResizeRows = false;
            this.SellGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellGV.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.SellGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SellGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.SellGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SellGV.ColumnHeadersHeight = 30;
            this.SellGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.SellGV.EnableHeadersVisualStyles = false;
            this.SellGV.GridColor = System.Drawing.Color.PowderBlue;
            this.SellGV.Location = new System.Drawing.Point(347, 167);
            this.SellGV.Name = "SellGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SellGV.RowHeadersVisible = false;
            this.SellGV.RowHeadersWidth = 51;
            this.SellGV.RowTemplate.Height = 29;
            this.SellGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SellGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellGV.Size = new System.Drawing.Size(900, 522);
            this.SellGV.TabIndex = 78;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(267, 239);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(44, 28);
            this.Ok.TabIndex = 79;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // DateCombo
            // 
            this.DateCombo.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateCombo.FormattingEnabled = true;
            this.DateCombo.Location = new System.Drawing.Point(369, 0);
            this.DateCombo.Name = "DateCombo";
            this.DateCombo.Size = new System.Drawing.Size(250, 31);
            this.DateCombo.TabIndex = 83;
            this.DateCombo.Tag = "";
            this.DateCombo.Text = "Select Date";
            // 
            // Hide
            // 
            this.Hide.Font = new System.Drawing.Font("Pristina", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hide.FormattingEnabled = true;
            this.Hide.ItemHeight = 21;
            this.Hide.Location = new System.Drawing.Point(36, 435);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(30, 29);
            this.Hide.TabIndex = 84;
            this.Hide.Visible = false;
            // 
            // PreQtt
            // 
            this.PreQtt.FormattingEnabled = true;
            this.PreQtt.Location = new System.Drawing.Point(36, 461);
            this.PreQtt.Name = "PreQtt";
            this.PreQtt.Size = new System.Drawing.Size(30, 28);
            this.PreQtt.TabIndex = 85;
            this.PreQtt.Visible = false;
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
            this.panel1.TabIndex = 86;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 12);
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
            this.label1.Location = new System.Drawing.Point(553, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sell Info.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.iconButton1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(634, -1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(124, 35);
            this.iconButton1.TabIndex = 92;
            this.iconButton1.Text = "Search";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton2.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(764, -1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(124, 35);
            this.iconButton2.TabIndex = 92;
            this.iconButton2.Text = "Refresh";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 687);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1247, 14);
            this.panel4.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Select Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(27, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Select Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(27, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 88;
            this.label4.Text = "Select Food :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(27, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 88;
            this.label5.Text = "Quantity :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 621);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
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
            this.Home.TabIndex = 89;
            this.Home.Text = "HOME";
            this.Home.TextColor = System.Drawing.Color.Black;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddBut.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddBut.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddBut.IconColor = System.Drawing.Color.DarkSlateGray;
            this.AddBut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBut.IconSize = 25;
            this.AddBut.Location = new System.Drawing.Point(101, 444);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(132, 45);
            this.AddBut.TabIndex = 91;
            this.AddBut.Text = "ADD";
            this.AddBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.DateCombo);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(347, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 56);
            this.panel2.TabIndex = 93;
            // 
            // Sells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 701);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PreQtt);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.SellGV);
            this.Controls.Add(this.SellQtt);
            this.Controls.Add(this.SellsItem);
            this.Controls.Add(this.SellCat);
            this.Controls.Add(this.DateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sells";
            this.Load += new System.EventHandler(this.Sells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellQtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.ComboBox SellCat;
        private System.Windows.Forms.ComboBox SellsItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown SellQtt;
        private System.Windows.Forms.DataGridView SellGV;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.ComboBox DateCombo;
        private System.Windows.Forms.ComboBox Hide;
        private System.Windows.Forms.ComboBox PreQtt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC Home;
        private FontAwesome.Sharp.IconButton AddBut;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel2;
    }
}