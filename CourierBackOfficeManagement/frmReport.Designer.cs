namespace CourierBackOfficeManagement
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.txtGeneralSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterAllCourier = new System.Windows.Forms.ComboBox();
            this.lblFilterAllCourier = new System.Windows.Forms.Label();
            this.cmbFilterByCorporateClient = new System.Windows.Forms.ComboBox();
            this.lblFilterByCorporateClient = new System.Windows.Forms.Label();
            this.lblFilterByLocation = new System.Windows.Forms.Label();
            this.cmbFilterByLocation = new System.Windows.Forms.ComboBox();
            this.lblFilterByStaff = new System.Windows.Forms.Label();
            this.cmbFilterByStaff = new System.Windows.Forms.ComboBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.courierReportInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.lblReportNamebyButton = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStripReport = new System.Windows.Forms.MenuStrip();
            this.bookedCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inRouteCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectedCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delieveredCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPackageWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourierNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierReportInfoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStripReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGeneralSearch
            // 
            this.txtGeneralSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneralSearch.Location = new System.Drawing.Point(6, 24);
            this.txtGeneralSearch.MinimumSize = new System.Drawing.Size(150, 26);
            this.txtGeneralSearch.Multiline = true;
            this.txtGeneralSearch.Name = "txtGeneralSearch";
            this.txtGeneralSearch.Size = new System.Drawing.Size(163, 26);
            this.txtGeneralSearch.TabIndex = 21;
            // 
            // cmbFilterAllCourier
            // 
            this.cmbFilterAllCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterAllCourier.FormattingEnabled = true;
            this.cmbFilterAllCourier.Location = new System.Drawing.Point(237, 134);
            this.cmbFilterAllCourier.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbFilterAllCourier.Name = "cmbFilterAllCourier";
            this.cmbFilterAllCourier.Size = new System.Drawing.Size(163, 24);
            this.cmbFilterAllCourier.TabIndex = 11;
            this.cmbFilterAllCourier.SelectedValueChanged += new System.EventHandler(this.cmbFilterAllCourier_SelectedValueChanged);
            // 
            // lblFilterAllCourier
            // 
            this.lblFilterAllCourier.AutoSize = true;
            this.lblFilterAllCourier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterAllCourier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFilterAllCourier.Location = new System.Drawing.Point(234, 114);
            this.lblFilterAllCourier.Name = "lblFilterAllCourier";
            this.lblFilterAllCourier.Size = new System.Drawing.Size(105, 17);
            this.lblFilterAllCourier.TabIndex = 9;
            this.lblFilterAllCourier.Text = "Filter All Courier";
            // 
            // cmbFilterByCorporateClient
            // 
            this.cmbFilterByCorporateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterByCorporateClient.FormattingEnabled = true;
            this.cmbFilterByCorporateClient.Location = new System.Drawing.Point(406, 134);
            this.cmbFilterByCorporateClient.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbFilterByCorporateClient.Name = "cmbFilterByCorporateClient";
            this.cmbFilterByCorporateClient.Size = new System.Drawing.Size(163, 24);
            this.cmbFilterByCorporateClient.TabIndex = 12;
            // 
            // lblFilterByCorporateClient
            // 
            this.lblFilterByCorporateClient.AutoSize = true;
            this.lblFilterByCorporateClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByCorporateClient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFilterByCorporateClient.Location = new System.Drawing.Point(403, 114);
            this.lblFilterByCorporateClient.Name = "lblFilterByCorporateClient";
            this.lblFilterByCorporateClient.Size = new System.Drawing.Size(141, 17);
            this.lblFilterByCorporateClient.TabIndex = 13;
            this.lblFilterByCorporateClient.Text = "Filter Corporate Client";
            // 
            // lblFilterByLocation
            // 
            this.lblFilterByLocation.AutoSize = true;
            this.lblFilterByLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByLocation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFilterByLocation.Location = new System.Drawing.Point(572, 114);
            this.lblFilterByLocation.Name = "lblFilterByLocation";
            this.lblFilterByLocation.Size = new System.Drawing.Size(112, 17);
            this.lblFilterByLocation.TabIndex = 15;
            this.lblFilterByLocation.Text = "Filter By Location";
            // 
            // cmbFilterByLocation
            // 
            this.cmbFilterByLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterByLocation.FormattingEnabled = true;
            this.cmbFilterByLocation.Location = new System.Drawing.Point(575, 134);
            this.cmbFilterByLocation.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbFilterByLocation.Name = "cmbFilterByLocation";
            this.cmbFilterByLocation.Size = new System.Drawing.Size(163, 24);
            this.cmbFilterByLocation.TabIndex = 14;
            // 
            // lblFilterByStaff
            // 
            this.lblFilterByStaff.AutoSize = true;
            this.lblFilterByStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByStaff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFilterByStaff.Location = new System.Drawing.Point(741, 114);
            this.lblFilterByStaff.Name = "lblFilterByStaff";
            this.lblFilterByStaff.Size = new System.Drawing.Size(88, 17);
            this.lblFilterByStaff.TabIndex = 17;
            this.lblFilterByStaff.Text = "Filter By Staff";
            // 
            // cmbFilterByStaff
            // 
            this.cmbFilterByStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterByStaff.FormattingEnabled = true;
            this.cmbFilterByStaff.Location = new System.Drawing.Point(744, 134);
            this.cmbFilterByStaff.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbFilterByStaff.Name = "cmbFilterByStaff";
            this.cmbFilterByStaff.Size = new System.Drawing.Size(163, 24);
            this.cmbFilterByStaff.TabIndex = 16;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(913, 132);
            this.txtStartDate.MinimumSize = new System.Drawing.Size(163, 26);
            this.txtStartDate.Multiline = true;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(163, 26);
            this.txtStartDate.TabIndex = 18;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            this.txtStartDate.Enter += new System.EventHandler(this.txtStartDate_Enter);
            this.txtStartDate.Leave += new System.EventHandler(this.txtStartDate_Leave);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(1082, 132);
            this.txtEndDate.MinimumSize = new System.Drawing.Size(163, 26);
            this.txtEndDate.Multiline = true;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(163, 26);
            this.txtEndDate.TabIndex = 19;
            this.txtEndDate.TextChanged += new System.EventHandler(this.txtEndDate_TextChanged);
            this.txtEndDate.Enter += new System.EventHandler(this.txtEndDate_Enter);
            this.txtEndDate.Leave += new System.EventHandler(this.txtEndDate_Leave);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblStartDate.Location = new System.Drawing.Point(910, 114);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 17);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblEndDate.Location = new System.Drawing.Point(1079, 112);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(63, 17);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(1260, 130);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 28);
            this.btnFilter.TabIndex = 22;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeColumns = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.AutoGenerateColumns = false;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFrom,
            this.clmTo,
            this.clmSender,
            this.clmReceiver,
            this.clmCourierNumber,
            this.clmPackageWeight,
            this.clmQuantity,
            this.clmCharge,
            this.clmStatus});
            this.dataGridViewReport.DataSource = this.courierReportInfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 164);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersWidth = 50;
            this.dataGridViewReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(1338, 506);
            this.dataGridViewReport.TabIndex = 23;
            this.dataGridViewReport.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewReport_DataBindingComplete);
            // 
            // courierReportInfoBindingSource
            // 
            this.courierReportInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.CourierReport.CourierReportInfo);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(849, -4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(1018, -4);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 25;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            this.monthCalendar2.Leave += new System.EventHandler(this.monthCalendar2_Leave);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // lblReportNamebyButton
            // 
            this.lblReportNamebyButton.AutoSize = true;
            this.lblReportNamebyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportNamebyButton.ForeColor = System.Drawing.Color.White;
            this.lblReportNamebyButton.Location = new System.Drawing.Point(18, 67);
            this.lblReportNamebyButton.Name = "lblReportNamebyButton";
            this.lblReportNamebyButton.Size = new System.Drawing.Size(0, 21);
            this.lblReportNamebyButton.TabIndex = 29;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(388, 57);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(614, 37);
            this.lblCompanyName.TabIndex = 32;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(105, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(131, 67);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(242, 57);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(140, 50);
            this.lblContact.TabIndex = 34;
            this.lblContact.Text = "Contact";
            this.lblContact.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(315, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGeneralSearch);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 58);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Search";
            // 
            // menuStripReport
            // 
            this.menuStripReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookedCourierToolStripMenuItem,
            this.inRouteCourierToolStripMenuItem,
            this.collectedCourierToolStripMenuItem,
            this.delieveredCourierToolStripMenuItem});
            this.menuStripReport.Location = new System.Drawing.Point(0, 0);
            this.menuStripReport.Name = "menuStripReport";
            this.menuStripReport.Size = new System.Drawing.Size(1362, 25);
            this.menuStripReport.TabIndex = 38;
            this.menuStripReport.Text = "menuStrip1";
            // 
            // bookedCourierToolStripMenuItem
            // 
            this.bookedCourierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedCourierToolStripMenuItem.Name = "bookedCourierToolStripMenuItem";
            this.bookedCourierToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.bookedCourierToolStripMenuItem.Text = "Booked Courier";
            this.bookedCourierToolStripMenuItem.Click += new System.EventHandler(this.bookedCourierToolStripMenuItem_Click);
            // 
            // inRouteCourierToolStripMenuItem
            // 
            this.inRouteCourierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inRouteCourierToolStripMenuItem.Name = "inRouteCourierToolStripMenuItem";
            this.inRouteCourierToolStripMenuItem.Size = new System.Drawing.Size(112, 21);
            this.inRouteCourierToolStripMenuItem.Text = "InRouteCourier";
            this.inRouteCourierToolStripMenuItem.Click += new System.EventHandler(this.inRouteCourierToolStripMenuItem_Click);
            // 
            // collectedCourierToolStripMenuItem
            // 
            this.collectedCourierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectedCourierToolStripMenuItem.Name = "collectedCourierToolStripMenuItem";
            this.collectedCourierToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.collectedCourierToolStripMenuItem.Text = "Collected Courier";
            this.collectedCourierToolStripMenuItem.Click += new System.EventHandler(this.collectedCourierToolStripMenuItem_Click);
            // 
            // delieveredCourierToolStripMenuItem
            // 
            this.delieveredCourierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delieveredCourierToolStripMenuItem.Name = "delieveredCourierToolStripMenuItem";
            this.delieveredCourierToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.delieveredCourierToolStripMenuItem.Text = "Delievered Courier";
            this.delieveredCourierToolStripMenuItem.Click += new System.EventHandler(this.delieveredCourierToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::CourierBackOfficeManagement.Properties.Resources.refresh8;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1260, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 28);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::CourierBackOfficeManagement.Properties.Resources.excel_icon;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExport.Location = new System.Drawing.Point(1260, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 28);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "  Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::CourierBackOfficeManagement.Properties.Resources.printer_icon;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPrint.Location = new System.Drawing.Point(1260, 66);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 28);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "  Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(558, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // clmStatus
            // 
            this.clmStatus.DataPropertyName = "Status";
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmCharge
            // 
            this.clmCharge.DataPropertyName = "CourierCharge";
            this.clmCharge.HeaderText = "Charge";
            this.clmCharge.Name = "clmCharge";
            this.clmCharge.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.DataPropertyName = "NoOfPackage";
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            // 
            // clmPackageWeight
            // 
            this.clmPackageWeight.DataPropertyName = "WeightOfPackage";
            this.clmPackageWeight.HeaderText = "Pkg.wt.";
            this.clmPackageWeight.Name = "clmPackageWeight";
            this.clmPackageWeight.ReadOnly = true;
            // 
            // clmCourierNumber
            // 
            this.clmCourierNumber.DataPropertyName = "PackageID";
            this.clmCourierNumber.HeaderText = "Courier No.";
            this.clmCourierNumber.Name = "clmCourierNumber";
            this.clmCourierNumber.ReadOnly = true;
            // 
            // clmReceiver
            // 
            this.clmReceiver.DataPropertyName = "Receiver";
            this.clmReceiver.HeaderText = "Receiver";
            this.clmReceiver.Name = "clmReceiver";
            this.clmReceiver.ReadOnly = true;
            // 
            // clmSender
            // 
            this.clmSender.DataPropertyName = "Sender";
            this.clmSender.HeaderText = "Sender";
            this.clmSender.Name = "clmSender";
            this.clmSender.ReadOnly = true;
            // 
            // clmTo
            // 
            this.clmTo.DataPropertyName = "DropTo";
            this.clmTo.HeaderText = "To";
            this.clmTo.Name = "clmTo";
            this.clmTo.ReadOnly = true;
            // 
            // clmFrom
            // 
            this.clmFrom.DataPropertyName = "PickupFrom";
            this.clmFrom.HeaderText = "From";
            this.clmFrom.Name = "clmFrom";
            this.clmFrom.ReadOnly = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbFilterByCorporateClient);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblFilterByCorporateClient);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbFilterByLocation);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblFilterByLocation);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmbFilterAllCourier);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.cmbFilterByStaff);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.lblFilterAllCourier);
            this.Controls.Add(this.lblFilterByStaff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblReportNamebyButton);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.menuStripReport);
            this.Controls.Add(this.txtEndDate);
            this.MainMenuStrip = this.menuStripReport;
            this.Name = "frmReport";
            this.Text = "Report Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierReportInfoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStripReport.ResumeLayout(false);
            this.menuStripReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFilterAllCourier;
        private System.Windows.Forms.ComboBox cmbFilterAllCourier;
        private System.Windows.Forms.ComboBox cmbFilterByCorporateClient;
        private System.Windows.Forms.Label lblFilterByCorporateClient;
        private System.Windows.Forms.Label lblFilterByLocation;
        private System.Windows.Forms.ComboBox cmbFilterByLocation;
        private System.Windows.Forms.Label lblFilterByStaff;
        private System.Windows.Forms.ComboBox cmbFilterByStaff;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtGeneralSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.BindingSource courierReportInfoBindingSource;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Label lblReportNamebyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStripReport;
        private System.Windows.Forms.ToolStripMenuItem bookedCourierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inRouteCourierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectedCourierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delieveredCourierToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourierNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPackageWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
    }
}