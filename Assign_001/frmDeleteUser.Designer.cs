namespace Assign_001
{
    partial class frmDeleteUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.combGender = new System.Windows.Forms.ComboBox();
            this.BTregis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Assign_001.Properties.Resources.pngegg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(39, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 177);
            this.panel1.TabIndex = 105;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(32, 828);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(105, 40);
            this.linkLabel2.TabIndex = 104;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "BACK";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtID.Location = new System.Drawing.Point(451, 250);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(262, 34);
            this.txtID.TabIndex = 103;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt.Location = new System.Drawing.Point(318, 254);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(86, 27);
            this.txt.TabIndex = 102;
            this.txt.Text = "UserID";
            // 
            // combGender
            // 
            this.combGender.BackColor = System.Drawing.Color.White;
            this.combGender.Enabled = false;
            this.combGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGender.ForeColor = System.Drawing.SystemColors.InfoText;
            this.combGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female",
            "Prefer not to say"});
            this.combGender.Location = new System.Drawing.Point(921, 571);
            this.combGender.Margin = new System.Windows.Forms.Padding(4);
            this.combGender.Name = "combGender";
            this.combGender.Size = new System.Drawing.Size(188, 33);
            this.combGender.TabIndex = 101;
            // 
            // BTregis
            // 
            this.BTregis.BackgroundImage = global::Assign_001.Properties.Resources.button;
            this.BTregis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTregis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTregis.FlatAppearance.BorderSize = 0;
            this.BTregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTregis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTregis.Location = new System.Drawing.Point(690, 660);
            this.BTregis.Margin = new System.Windows.Forms.Padding(4);
            this.BTregis.Name = "BTregis";
            this.BTregis.Size = new System.Drawing.Size(223, 88);
            this.BTregis.TabIndex = 100;
            this.BTregis.Text = "Delete";
            this.BTregis.UseVisualStyleBackColor = true;
            this.BTregis.Click += new System.EventHandler(this.BTregis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(759, 571);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 99;
            this.label5.Text = "Gender";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPhone.Location = new System.Drawing.Point(921, 419);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(270, 107);
            this.txtPhone.TabIndex = 98;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.White;
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAdd.Location = new System.Drawing.Point(451, 395);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ReadOnly = true;
            this.txtAdd.Size = new System.Drawing.Size(262, 79);
            this.txtAdd.TabIndex = 97;
            this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAge.Location = new System.Drawing.Point(921, 322);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(262, 34);
            this.txtAge.TabIndex = 96;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPass.Location = new System.Drawing.Point(921, 250);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(270, 34);
            this.txtPass.TabIndex = 95;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(451, 322);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(262, 34);
            this.txtName.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(759, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 27);
            this.label11.TabIndex = 93;
            this.label11.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(759, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 27);
            this.label10.TabIndex = 92;
            this.label10.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(318, 447);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 27);
            this.label9.TabIndex = 91;
            this.label9.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(755, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 27);
            this.label7.TabIndex = 90;
            this.label7.Text = "Phone_Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(318, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 89;
            this.label4.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(447, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(632, 194);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Here";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(442, 120);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 44);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSK
            // 
            this.txtSK.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtSK.Location = new System.Drawing.Point(274, 46);
            this.txtSK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSK.Name = "txtSK";
            this.txtSK.Size = new System.Drawing.Size(343, 34);
            this.txtSK.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter User ID";
            // 
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 893);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.combGender);
            this.Controls.Add(this.BTregis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDeleteUser";
            this.Text = "U_delete";
            this.Load += new System.EventHandler(this.frmDeleteUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.ComboBox combGender;
        private System.Windows.Forms.Button BTregis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSK;
        private System.Windows.Forms.Label label1;
    }
}