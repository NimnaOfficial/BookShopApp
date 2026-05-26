namespace Assign_001
{
    partial class Admin_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.membersManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMemberReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersManageToolStripMenuItem,
            this.stockManageToolStripMenuItem,
            this.backToOpenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // membersManageToolStripMenuItem
            // 
            this.membersManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMembersToolStripMenuItem,
            this.getMemberReportToolStripMenuItem});
            this.membersManageToolStripMenuItem.Name = "membersManageToolStripMenuItem";
            this.membersManageToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.membersManageToolStripMenuItem.Text = "Members Manage";
            // 
            // editMembersToolStripMenuItem
            // 
            this.editMembersToolStripMenuItem.Name = "editMembersToolStripMenuItem";
            this.editMembersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editMembersToolStripMenuItem.Text = "Edit Members";
            this.editMembersToolStripMenuItem.Click += new System.EventHandler(this.editMembersToolStripMenuItem_Click);
            // 
            // getMemberReportToolStripMenuItem
            // 
            this.getMemberReportToolStripMenuItem.Name = "getMemberReportToolStripMenuItem";
            this.getMemberReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.getMemberReportToolStripMenuItem.Text = "Get Member Report";
            this.getMemberReportToolStripMenuItem.Click += new System.EventHandler(this.getMemberReportToolStripMenuItem_Click);
            // 
            // stockManageToolStripMenuItem
            // 
            this.stockManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editStockToolStripMenuItem,
            this.getStockReportToolStripMenuItem});
            this.stockManageToolStripMenuItem.Name = "stockManageToolStripMenuItem";
            this.stockManageToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.stockManageToolStripMenuItem.Text = "Stock Manage";
            // 
            // editStockToolStripMenuItem
            // 
            this.editStockToolStripMenuItem.Name = "editStockToolStripMenuItem";
            this.editStockToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.editStockToolStripMenuItem.Text = "Edit Stock";
            this.editStockToolStripMenuItem.Click += new System.EventHandler(this.editStockToolStripMenuItem_Click);
            // 
            // getStockReportToolStripMenuItem
            // 
            this.getStockReportToolStripMenuItem.Name = "getStockReportToolStripMenuItem";
            this.getStockReportToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.getStockReportToolStripMenuItem.Text = "Get Stock Report";
            this.getStockReportToolStripMenuItem.Click += new System.EventHandler(this.getStockReportToolStripMenuItem_Click);
            // 
            // backToOpenToolStripMenuItem
            // 
            this.backToOpenToolStripMenuItem.Name = "backToOpenToolStripMenuItem";
            this.backToOpenToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.backToOpenToolStripMenuItem.Text = "Back to Open";
            this.backToOpenToolStripMenuItem.Click += new System.EventHandler(this.backToOpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Assign_001.Properties.Resources.G12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 1055);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "system";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem membersManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMemberReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStockReportToolStripMenuItem;
    }
}