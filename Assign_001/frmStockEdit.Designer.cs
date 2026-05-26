namespace Assign_001
{
    partial class frmStockEdit
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTadd = new System.Windows.Forms.Button();
            this.BTregis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtwriter = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(629, 729);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 32);
            this.linkLabel1.TabIndex = 121;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(593, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 793);
            this.panel1.TabIndex = 124;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Assign_001.Properties.Resources.button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(35, 720);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 58);
            this.button2.TabIndex = 123;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 583);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BTadd);
            this.panel2.Controls.Add(this.BTregis);
            this.panel2.Location = new System.Drawing.Point(2, 706);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 85);
            this.panel2.TabIndex = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.BackgroundImage = global::Assign_001.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(188, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 65);
            this.button1.TabIndex = 120;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTadd
            // 
            this.BTadd.BackColor = System.Drawing.SystemColors.Menu;
            this.BTadd.BackgroundImage = global::Assign_001.Properties.Resources.button;
            this.BTadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTadd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.BTadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTadd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTadd.ForeColor = System.Drawing.Color.Black;
            this.BTadd.Location = new System.Drawing.Point(337, 17);
            this.BTadd.Margin = new System.Windows.Forms.Padding(4);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(164, 53);
            this.BTadd.TabIndex = 122;
            this.BTadd.Text = "Add";
            this.BTadd.UseVisualStyleBackColor = false;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // BTregis
            // 
            this.BTregis.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BTregis.BackgroundImage = global::Assign_001.Properties.Resources.button;
            this.BTregis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTregis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTregis.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.BTregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTregis.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTregis.ForeColor = System.Drawing.Color.Black;
            this.BTregis.Location = new System.Drawing.Point(16, 15);
            this.BTregis.Margin = new System.Windows.Forms.Padding(4);
            this.BTregis.Name = "BTregis";
            this.BTregis.Size = new System.Drawing.Size(153, 57);
            this.BTregis.TabIndex = 119;
            this.BTregis.Text = "Delete";
            this.BTregis.UseVisualStyleBackColor = false;
            this.BTregis.Click += new System.EventHandler(this.BTregis_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtable);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtyear);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtcate);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txt);
            this.panel3.Controls.Add(this.txtwriter);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 708);
            this.panel3.TabIndex = 126;
            // 
            // txtable
            // 
            this.txtable.BackColor = System.Drawing.Color.White;
            this.txtable.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtable.ForeColor = System.Drawing.Color.Black;
            this.txtable.Location = new System.Drawing.Point(220, 630);
            this.txtable.Margin = new System.Windows.Forms.Padding(4);
            this.txtable.Name = "txtable";
            this.txtable.Size = new System.Drawing.Size(273, 34);
            this.txtable.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 637);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 27);
            this.label5.TabIndex = 137;
            this.label5.Text = "Availability";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.Location = new System.Drawing.Point(220, 561);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(273, 34);
            this.txtprice.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 568);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 135;
            this.label7.Text = "Price";
            // 
            // txtyear
            // 
            this.txtyear.BackColor = System.Drawing.Color.White;
            this.txtyear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.ForeColor = System.Drawing.Color.Black;
            this.txtyear.Location = new System.Drawing.Point(220, 354);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(276, 34);
            this.txtyear.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 361);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 27);
            this.label9.TabIndex = 133;
            this.label9.Text = "Released Year";
            // 
            // txtcate
            // 
            this.txtcate.BackColor = System.Drawing.Color.White;
            this.txtcate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcate.ForeColor = System.Drawing.Color.Black;
            this.txtcate.Location = new System.Drawing.Point(220, 493);
            this.txtcate.Margin = new System.Windows.Forms.Padding(4);
            this.txtcate.Name = "txtcate";
            this.txtcate.Size = new System.Drawing.Size(273, 34);
            this.txtcate.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 500);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 27);
            this.label10.TabIndex = 131;
            this.label10.Text = "Category";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(220, 216);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(276, 34);
            this.txtID.TabIndex = 130;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Black;
            this.txt.Location = new System.Drawing.Point(34, 219);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(92, 27);
            this.txt.TabIndex = 129;
            this.txt.Text = "BookID";
            // 
            // txtwriter
            // 
            this.txtwriter.BackColor = System.Drawing.Color.White;
            this.txtwriter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwriter.ForeColor = System.Drawing.Color.Black;
            this.txtwriter.Location = new System.Drawing.Point(220, 283);
            this.txtwriter.Margin = new System.Windows.Forms.Padding(4);
            this.txtwriter.Name = "txtwriter";
            this.txtwriter.Size = new System.Drawing.Size(276, 34);
            this.txtwriter.TabIndex = 128;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(220, 424);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 34);
            this.txtName.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(34, 290);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 27);
            this.label11.TabIndex = 126;
            this.label11.Text = "Writer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 125;
            this.label4.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(39, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(478, 150);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Box";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.BackgroundImage = global::Assign_001.Properties.Resources._101_1017087_search_icon_our_vision_png_icon_transparent_png;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(359, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 36);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSK
            // 
            this.txtSK.BackColor = System.Drawing.Color.White;
            this.txtSK.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSK.Location = new System.Drawing.Point(76, 86);
            this.txtSK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSK.Name = "txtSK";
            this.txtSK.Size = new System.Drawing.Size(258, 34);
            this.txtSK.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter Book ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(538, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 55);
            this.button3.TabIndex = 123;
            this.button3.Text = "Cl";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmStockEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1326, 791);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStockEdit";
            this.Load += new System.EventHandler(this.frmStockEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTregis;
        private System.Windows.Forms.Button BTadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtwriter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}