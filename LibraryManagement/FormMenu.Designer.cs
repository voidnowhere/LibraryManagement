namespace LibraryManagement
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrageManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsibleManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientManagementToolStripMenuItem,
            this.ouvrageManagementToolStripMenuItem,
            this.borrowManagementToolStripMenuItem,
            this.responsibleManagementToolStripMenuItem,
            this.resetPasswordToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(754, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clientManagementToolStripMenuItem
            // 
            this.clientManagementToolStripMenuItem.Name = "clientManagementToolStripMenuItem";
            this.clientManagementToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.clientManagementToolStripMenuItem.Text = "Client Management";
            this.clientManagementToolStripMenuItem.Click += new System.EventHandler(this.clientManagementToolStripMenuItem_Click);
            // 
            // ouvrageManagementToolStripMenuItem
            // 
            this.ouvrageManagementToolStripMenuItem.Name = "ouvrageManagementToolStripMenuItem";
            this.ouvrageManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.ouvrageManagementToolStripMenuItem.Text = "Ouvrage Management";
            this.ouvrageManagementToolStripMenuItem.Click += new System.EventHandler(this.ouvrageManagementToolStripMenuItem_Click);
            // 
            // borrowManagementToolStripMenuItem
            // 
            this.borrowManagementToolStripMenuItem.Name = "borrowManagementToolStripMenuItem";
            this.borrowManagementToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.borrowManagementToolStripMenuItem.Text = "Borrow Management";
            this.borrowManagementToolStripMenuItem.Click += new System.EventHandler(this.borrowManagementToolStripMenuItem_Click);
            // 
            // responsibleManagementToolStripMenuItem
            // 
            this.responsibleManagementToolStripMenuItem.Name = "responsibleManagementToolStripMenuItem";
            this.responsibleManagementToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.responsibleManagementToolStripMenuItem.Text = "Responsible Management";
            this.responsibleManagementToolStripMenuItem.Click += new System.EventHandler(this.responsibleManagementToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 421);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem clientManagementToolStripMenuItem;
        private ToolStripMenuItem ouvrageManagementToolStripMenuItem;
        private ToolStripMenuItem responsibleManagementToolStripMenuItem;
        private ToolStripMenuItem resetPasswordToolStripMenuItem;
        private ToolStripMenuItem borrowManagementToolStripMenuItem;
    }
}