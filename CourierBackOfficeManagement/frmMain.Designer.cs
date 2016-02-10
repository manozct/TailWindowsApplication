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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuState = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corporateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCorporateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.corporateClientToolStripMenuItem});
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
            this.fIleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
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
            this.countryToolStripMenuCountry.Size = new System.Drawing.Size(152, 22);
            this.countryToolStripMenuCountry.Text = "Country";
            this.countryToolStripMenuCountry.Click += new System.EventHandler(this.countryToolStripMenuCountry_Click);
            // 
            // stateToolStripMenuState
            // 
            this.stateToolStripMenuState.Name = "stateToolStripMenuState";
            this.stateToolStripMenuState.Size = new System.Drawing.Size(152, 22);
            this.stateToolStripMenuState.Text = "State";
            this.stateToolStripMenuState.Click += new System.EventHandler(this.stateToolStripMenuState_Click);
            // 
            // locationToolStripMenuLocation
            // 
            this.locationToolStripMenuLocation.Name = "locationToolStripMenuLocation";
            this.locationToolStripMenuLocation.Size = new System.Drawing.Size(152, 22);
            this.locationToolStripMenuLocation.Text = "Location";
            this.locationToolStripMenuLocation.Click += new System.EventHandler(this.locationToolStripMenuLocation_Click);
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
            this.clientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // corporateClientToolStripMenuItem
            // 
            this.corporateClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCorporateClientToolStripMenuItem,
            this.addContractToolStripMenuItem,
            this.addCourierToolStripMenuItem});
            this.corporateClientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corporateClientToolStripMenuItem.Name = "corporateClientToolStripMenuItem";
            this.corporateClientToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.corporateClientToolStripMenuItem.Text = "C.Client";
            this.corporateClientToolStripMenuItem.Click += new System.EventHandler(this.corporateClientToolStripMenuItem_Click);
            // 
            // addCorporateClientToolStripMenuItem
            // 
            this.addCorporateClientToolStripMenuItem.Name = "addCorporateClientToolStripMenuItem";
            this.addCorporateClientToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addCorporateClientToolStripMenuItem.Text = " Corporate Client";
            this.addCorporateClientToolStripMenuItem.Click += new System.EventHandler(this.addCorporateClientToolStripMenuItem_Click);
            // 
            // addContractToolStripMenuItem
            // 
            this.addContractToolStripMenuItem.Name = "addContractToolStripMenuItem";
            this.addContractToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addContractToolStripMenuItem.Text = " Contract";
            this.addContractToolStripMenuItem.Click += new System.EventHandler(this.addContractToolStripMenuItem_Click);
            // 
            // addCourierToolStripMenuItem
            // 
            this.addCourierToolStripMenuItem.Name = "addCourierToolStripMenuItem";
            this.addCourierToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addCourierToolStripMenuItem.Text = " Courier";
            this.addCourierToolStripMenuItem.Click += new System.EventHandler(this.addCourierToolStripMenuItem_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.priceToolStripMenuItem.Text = " Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 433);
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
        private System.Windows.Forms.ToolStripMenuItem addContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuCountry;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuState;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuLocation;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
    }
}

