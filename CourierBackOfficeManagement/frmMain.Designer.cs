namespace CourierBackOfficeManagement
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuState = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corporateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCorporateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.corporateClientToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.expenseToolStripMenuItem});
            this.fIleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fIleToolStripMenuItem.Text = "File";
            this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fIleToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuCountry,
            this.stateToolStripMenuState,
            this.locationToolStripMenuLocation,
            this.priceToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // countryToolStripMenuCountry
            // 
            this.countryToolStripMenuCountry.Name = "countryToolStripMenuCountry";
            this.countryToolStripMenuCountry.Size = new System.Drawing.Size(127, 22);
            this.countryToolStripMenuCountry.Text = "Country";
            this.countryToolStripMenuCountry.Click += new System.EventHandler(this.countryToolStripMenuCountry_Click);
            // 
            // stateToolStripMenuState
            // 
            this.stateToolStripMenuState.Name = "stateToolStripMenuState";
            this.stateToolStripMenuState.Size = new System.Drawing.Size(127, 22);
            this.stateToolStripMenuState.Text = "State";
            this.stateToolStripMenuState.Click += new System.EventHandler(this.stateToolStripMenuState_Click);
            // 
            // locationToolStripMenuLocation
            // 
            this.locationToolStripMenuLocation.Name = "locationToolStripMenuLocation";
            this.locationToolStripMenuLocation.Size = new System.Drawing.Size(127, 22);
            this.locationToolStripMenuLocation.Text = "Location";
            this.locationToolStripMenuLocation.Click += new System.EventHandler(this.locationToolStripMenuLocation_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click);
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expenseToolStripMenuItem.Text = "Expense";
            this.expenseToolStripMenuItem.Click += new System.EventHandler(this.expenseToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // corporateClientToolStripMenuItem
            // 
            this.corporateClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCorporateClientToolStripMenuItem,
            this.addCourierToolStripMenuItem});
            this.corporateClientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corporateClientToolStripMenuItem.Name = "corporateClientToolStripMenuItem";
            this.corporateClientToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.corporateClientToolStripMenuItem.Text = "C.Client";
            this.corporateClientToolStripMenuItem.Click += new System.EventHandler(this.corporateClientToolStripMenuItem_Click);
            // 
            // addCorporateClientToolStripMenuItem
            // 
            this.addCorporateClientToolStripMenuItem.Name = "addCorporateClientToolStripMenuItem";
            this.addCorporateClientToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.addCorporateClientToolStripMenuItem.Text = " Corporate Client";
            this.addCorporateClientToolStripMenuItem.Click += new System.EventHandler(this.addCorporateClientToolStripMenuItem_Click);
            // 
            // addCourierToolStripMenuItem
            // 
            this.addCourierToolStripMenuItem.Name = "addCourierToolStripMenuItem";
            this.addCourierToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.addCourierToolStripMenuItem.Text = " Corporate Client Entry";
            this.addCourierToolStripMenuItem.Click += new System.EventHandler(this.addCourierToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(650, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 433);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back Office Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corporateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCorporateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuCountry;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuState;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuLocation;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

