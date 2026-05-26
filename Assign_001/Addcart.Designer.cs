namespace Assign_001
{
    partial class Addcart
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
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtBname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Image = global::Assign_001.Properties.Resources.button;
            this.add.Location = new System.Drawing.Point(403, 556);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(167, 68);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Book";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.Color.White;
            this.qty.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(517, 416);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(194, 34);
            this.qty.TabIndex = 3;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtsh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(258, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::Assign_001.Properties.Resources._101_1017087_search_icon_our_vision_png_icon_transparent_png;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsh
            // 
            this.txtsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsh.Location = new System.Drawing.Point(211, 30);
            this.txtsh.Multiline = true;
            this.txtsh.Name = "txtsh";
            this.txtsh.Size = new System.Drawing.Size(178, 43);
            this.txtsh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "BookID";
            // 
            // txtBid
            // 
            this.txtBid.BackColor = System.Drawing.Color.White;
            this.txtBid.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBid.Location = new System.Drawing.Point(516, 197);
            this.txtBid.Multiline = true;
            this.txtBid.Name = "txtBid";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(194, 46);
            this.txtBid.TabIndex = 6;
            // 
            // txtBname
            // 
            this.txtBname.BackColor = System.Drawing.Color.White;
            this.txtBname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBname.Location = new System.Drawing.Point(516, 336);
            this.txtBname.Multiline = true;
            this.txtBname.Name = "txtBname";
            this.txtBname.ReadOnly = true;
            this.txtBname.Size = new System.Drawing.Size(194, 44);
            this.txtBname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book Name";
            // 
            // txtPric
            // 
            this.txtPric.BackColor = System.Drawing.Color.White;
            this.txtPric.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPric.Location = new System.Drawing.Point(516, 463);
            this.txtPric.Multiline = true;
            this.txtPric.Name = "txtPric";
            this.txtPric.ReadOnly = true;
            this.txtPric.Size = new System.Drawing.Size(194, 45);
            this.txtPric.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 651);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(843, 31);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Assign_001.Properties.Resources.G6;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(516, 266);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(194, 46);
            this.txtuser.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assign_001.Properties.Resources.G9_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(45, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 132);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Addcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.add);
            this.Name = "Addcart";
            this.Text = "Addcart";
            this.Load += new System.EventHandler(this.Addcart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.TextBox txtBname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsh;
    }
}