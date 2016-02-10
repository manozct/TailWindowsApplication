namespace CourierBackOfficeManagement
{
    partial class frmGridGeneralCourier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddNewCourier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewGeneralCourier = new System.Windows.Forms.DataGridView();
            this.generalCourierInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalCourierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPackageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightOfPackageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblShowRows = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralCourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalCourierInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewCourier
            // 
            this.btnAddNewCourier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourier.Location = new System.Drawing.Point(34, 54);
            this.btnAddNewCourier.Name = "btnAddNewCourier";
            this.btnAddNewCourier.Size = new System.Drawing.Size(130, 30);
            this.btnAddNewCourier.TabIndex = 2;
            this.btnAddNewCourier.Text = "Add New Courier";
            this.btnAddNewCourier.UseVisualStyleBackColor = true;
            this.btnAddNewCourier.Click += new System.EventHandler(this.btnAddNewCourier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblShowRows);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(34, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(249, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(43, 22);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 28);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dataGridViewGeneralCourier
            // 
            this.dataGridViewGeneralCourier.AllowUserToAddRows = false;
            this.dataGridViewGeneralCourier.AllowUserToDeleteRows = false;
            this.dataGridViewGeneralCourier.AllowUserToResizeColumns = false;
            this.dataGridViewGeneralCourier.AllowUserToResizeRows = false;
            this.dataGridViewGeneralCourier.AutoGenerateColumns = false;
            this.dataGridViewGeneralCourier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneralCourier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGeneralCourier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneralCourier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.generalCourierIDDataGridViewTextBoxColumn,
            this.courierNumberDataGridViewTextBoxColumn,
            this.senderFullNameDataGridViewTextBoxColumn,
            this.senderAddressDataGridViewTextBoxColumn,
            this.receiverFullNameDataGridViewTextBoxColumn,
            this.receiverAddressDataGridViewTextBoxColumn,
            this.receiverFirstNameDataGridViewTextBoxColumn,
            this.receiverMiddleNameDataGridViewTextBoxColumn,
            this.receiverLastNameDataGridViewTextBoxColumn,
            this.receiverMobileDataGridViewTextBoxColumn,
            this.receiverPhoneDataGridViewTextBoxColumn,
            this.numberOfPackageDataGridViewTextBoxColumn,
            this.weightOfPackageDataGridViewTextBoxColumn,
            this.packageWeightDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.serviceTypeIDDataGridViewTextBoxColumn,
            this.weightUnitIDDataGridViewTextBoxColumn,
            this.senderFirstNameDataGridViewTextBoxColumn,
            this.senderMiddleNameDataGridViewTextBoxColumn,
            this.senderLastNameDataGridViewTextBoxColumn,
            this.senderMobileDataGridViewTextBoxColumn,
            this.senderPhoneDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewGeneralCourier.DataSource = this.generalCourierInfoBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGeneralCourier.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGeneralCourier.Location = new System.Drawing.Point(34, 169);
            this.dataGridViewGeneralCourier.Name = "dataGridViewGeneralCourier";
            this.dataGridViewGeneralCourier.ReadOnly = true;
            this.dataGridViewGeneralCourier.RowHeadersWidth = 45;
            this.dataGridViewGeneralCourier.Size = new System.Drawing.Size(1200, 150);
            this.dataGridViewGeneralCourier.TabIndex = 4;
            this.dataGridViewGeneralCourier.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewGeneralCourier_DataBindingComplete);
            // 
            // generalCourierInfoBindingSource
            // 
            this.generalCourierInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.GeneralCourier.GeneralCourierInfo);
            // 
            // generalCourierIDDataGridViewTextBoxColumn
            // 
            this.generalCourierIDDataGridViewTextBoxColumn.DataPropertyName = "GeneralCourierID";
            this.generalCourierIDDataGridViewTextBoxColumn.HeaderText = "GeneralCourierID";
            this.generalCourierIDDataGridViewTextBoxColumn.Name = "generalCourierIDDataGridViewTextBoxColumn";
            this.generalCourierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.generalCourierIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // courierNumberDataGridViewTextBoxColumn
            // 
            this.courierNumberDataGridViewTextBoxColumn.DataPropertyName = "CourierNumber";
            this.courierNumberDataGridViewTextBoxColumn.HeaderText = "Courier Number";
            this.courierNumberDataGridViewTextBoxColumn.Name = "courierNumberDataGridViewTextBoxColumn";
            this.courierNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderFullNameDataGridViewTextBoxColumn
            // 
            this.senderFullNameDataGridViewTextBoxColumn.DataPropertyName = "SenderFullName";
            this.senderFullNameDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderFullNameDataGridViewTextBoxColumn.Name = "senderFullNameDataGridViewTextBoxColumn";
            this.senderFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderAddressDataGridViewTextBoxColumn
            // 
            this.senderAddressDataGridViewTextBoxColumn.DataPropertyName = "SenderAddress";
            this.senderAddressDataGridViewTextBoxColumn.HeaderText = "Sender Address";
            this.senderAddressDataGridViewTextBoxColumn.Name = "senderAddressDataGridViewTextBoxColumn";
            this.senderAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiverFullNameDataGridViewTextBoxColumn
            // 
            this.receiverFullNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverFullName";
            this.receiverFullNameDataGridViewTextBoxColumn.HeaderText = "Receiver";
            this.receiverFullNameDataGridViewTextBoxColumn.Name = "receiverFullNameDataGridViewTextBoxColumn";
            this.receiverFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiverAddressDataGridViewTextBoxColumn
            // 
            this.receiverAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceiverAddress";
            this.receiverAddressDataGridViewTextBoxColumn.HeaderText = "Receiver Address";
            this.receiverAddressDataGridViewTextBoxColumn.Name = "receiverAddressDataGridViewTextBoxColumn";
            this.receiverAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiverFirstNameDataGridViewTextBoxColumn
            // 
            this.receiverFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverFirstName";
            this.receiverFirstNameDataGridViewTextBoxColumn.HeaderText = "ReceiverFirstName";
            this.receiverFirstNameDataGridViewTextBoxColumn.Name = "receiverFirstNameDataGridViewTextBoxColumn";
            this.receiverFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverFirstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // receiverMiddleNameDataGridViewTextBoxColumn
            // 
            this.receiverMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverMiddleName";
            this.receiverMiddleNameDataGridViewTextBoxColumn.HeaderText = "ReceiverMiddleName";
            this.receiverMiddleNameDataGridViewTextBoxColumn.Name = "receiverMiddleNameDataGridViewTextBoxColumn";
            this.receiverMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverMiddleNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // receiverLastNameDataGridViewTextBoxColumn
            // 
            this.receiverLastNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverLastName";
            this.receiverLastNameDataGridViewTextBoxColumn.HeaderText = "ReceiverLastName";
            this.receiverLastNameDataGridViewTextBoxColumn.Name = "receiverLastNameDataGridViewTextBoxColumn";
            this.receiverLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverLastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // receiverMobileDataGridViewTextBoxColumn
            // 
            this.receiverMobileDataGridViewTextBoxColumn.DataPropertyName = "ReceiverMobile";
            this.receiverMobileDataGridViewTextBoxColumn.HeaderText = "ReceiverMobile";
            this.receiverMobileDataGridViewTextBoxColumn.Name = "receiverMobileDataGridViewTextBoxColumn";
            this.receiverMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverMobileDataGridViewTextBoxColumn.Visible = false;
            // 
            // receiverPhoneDataGridViewTextBoxColumn
            // 
            this.receiverPhoneDataGridViewTextBoxColumn.DataPropertyName = "ReceiverPhone";
            this.receiverPhoneDataGridViewTextBoxColumn.HeaderText = "ReceiverPhone";
            this.receiverPhoneDataGridViewTextBoxColumn.Name = "receiverPhoneDataGridViewTextBoxColumn";
            this.receiverPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverPhoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberOfPackageDataGridViewTextBoxColumn
            // 
            this.numberOfPackageDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPackage";
            this.numberOfPackageDataGridViewTextBoxColumn.HeaderText = "NumberOfPackage";
            this.numberOfPackageDataGridViewTextBoxColumn.Name = "numberOfPackageDataGridViewTextBoxColumn";
            this.numberOfPackageDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfPackageDataGridViewTextBoxColumn.Visible = false;
            // 
            // weightOfPackageDataGridViewTextBoxColumn
            // 
            this.weightOfPackageDataGridViewTextBoxColumn.DataPropertyName = "WeightOfPackage";
            this.weightOfPackageDataGridViewTextBoxColumn.HeaderText = "WeightOfPackage";
            this.weightOfPackageDataGridViewTextBoxColumn.Name = "weightOfPackageDataGridViewTextBoxColumn";
            this.weightOfPackageDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightOfPackageDataGridViewTextBoxColumn.Visible = false;
            // 
            // packageWeightDataGridViewTextBoxColumn
            // 
            this.packageWeightDataGridViewTextBoxColumn.DataPropertyName = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.HeaderText = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.Name = "packageWeightDataGridViewTextBoxColumn";
            this.packageWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageWeightDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceTypeIDDataGridViewTextBoxColumn
            // 
            this.serviceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.HeaderText = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.Name = "serviceTypeIDDataGridViewTextBoxColumn";
            this.serviceTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // weightUnitIDDataGridViewTextBoxColumn
            // 
            this.weightUnitIDDataGridViewTextBoxColumn.DataPropertyName = "WeightUnitID";
            this.weightUnitIDDataGridViewTextBoxColumn.HeaderText = "WeightUnitID";
            this.weightUnitIDDataGridViewTextBoxColumn.Name = "weightUnitIDDataGridViewTextBoxColumn";
            this.weightUnitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightUnitIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderFirstNameDataGridViewTextBoxColumn
            // 
            this.senderFirstNameDataGridViewTextBoxColumn.DataPropertyName = "SenderFirstName";
            this.senderFirstNameDataGridViewTextBoxColumn.HeaderText = "SenderFirstName";
            this.senderFirstNameDataGridViewTextBoxColumn.Name = "senderFirstNameDataGridViewTextBoxColumn";
            this.senderFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderFirstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderMiddleNameDataGridViewTextBoxColumn
            // 
            this.senderMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "SenderMiddleName";
            this.senderMiddleNameDataGridViewTextBoxColumn.HeaderText = "SenderMiddleName";
            this.senderMiddleNameDataGridViewTextBoxColumn.Name = "senderMiddleNameDataGridViewTextBoxColumn";
            this.senderMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderMiddleNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderLastNameDataGridViewTextBoxColumn
            // 
            this.senderLastNameDataGridViewTextBoxColumn.DataPropertyName = "SenderLastName";
            this.senderLastNameDataGridViewTextBoxColumn.HeaderText = "SenderLastName";
            this.senderLastNameDataGridViewTextBoxColumn.Name = "senderLastNameDataGridViewTextBoxColumn";
            this.senderLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderLastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderMobileDataGridViewTextBoxColumn
            // 
            this.senderMobileDataGridViewTextBoxColumn.DataPropertyName = "SenderMobile";
            this.senderMobileDataGridViewTextBoxColumn.HeaderText = "SenderMobile";
            this.senderMobileDataGridViewTextBoxColumn.Name = "senderMobileDataGridViewTextBoxColumn";
            this.senderMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderMobileDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderPhoneDataGridViewTextBoxColumn
            // 
            this.senderPhoneDataGridViewTextBoxColumn.DataPropertyName = "SenderPhone";
            this.senderPhoneDataGridViewTextBoxColumn.HeaderText = "SenderPhone";
            this.senderPhoneDataGridViewTextBoxColumn.Name = "senderPhoneDataGridViewTextBoxColumn";
            this.senderPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderPhoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblShowRows
            // 
            this.lblShowRows.AutoSize = true;
            this.lblShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRows.Location = new System.Drawing.Point(951, 22);
            this.lblShowRows.Name = "lblShowRows";
            this.lblShowRows.Size = new System.Drawing.Size(83, 18);
            this.lblShowRows.TabIndex = 6;
            this.lblShowRows.Text = "Show rows";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1040, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 26);
            this.comboBox1.TabIndex = 7;
            // 
            // frmGridGeneralCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.dataGridViewGeneralCourier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddNewCourier);
            this.Name = "frmGridGeneralCourier";
            this.Text = "General Courier List Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGridGeneralCourier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralCourier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalCourierInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewCourier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewGeneralCourier;
        private System.Windows.Forms.BindingSource generalCourierInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn generalCourierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPackageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightOfPackageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblShowRows;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}