namespace CourierBackOfficeManagement
{
    partial class frmGridCorporateClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCorporateClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCDContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCDContactPersonPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCDContactPersonEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddNewCorporate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblShowRows = new System.Windows.Forms.Label();
            this.cmbShowRow = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDContactPersonMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corporateClientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorporateClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corporateClientInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCorporateClient
            // 
            this.dataGridViewCorporateClient.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewCorporateClient.AllowUserToAddRows = false;
            this.dataGridViewCorporateClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewCorporateClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCorporateClient.AutoGenerateColumns = false;
            this.dataGridViewCorporateClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCorporateClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCorporateClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCorporateClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCorporateClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCorporateClient.ColumnHeadersHeight = 35;
            this.dataGridViewCorporateClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCorporateClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clientNameDataGridViewTextBoxColumn,
            this.LCDContactPerson,
            this.lCDContactPersonMobileDataGridViewTextBoxColumn,
            this.Address,
            this.PhoneNumber,
            this.EmailAddress,
            this.HOAddress,
            this.LCDepartment,
            this.LCDContactPersonPhone,
            this.LCDContactPersonEmail,
            this.SLA,
            this.Contract,
            this.EditButton,
            this.DeleteButton});
            this.dataGridViewCorporateClient.DataSource = this.corporateClientInfoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCorporateClient.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCorporateClient.EnableHeadersVisualStyles = false;
            this.dataGridViewCorporateClient.GridColor = System.Drawing.Color.White;
            this.dataGridViewCorporateClient.Location = new System.Drawing.Point(94, 176);
            this.dataGridViewCorporateClient.Name = "dataGridViewCorporateClient";
            this.dataGridViewCorporateClient.ReadOnly = true;
            this.dataGridViewCorporateClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCorporateClient.RowHeadersWidth = 40;
            this.dataGridViewCorporateClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCorporateClient.Size = new System.Drawing.Size(1050, 258);
            this.dataGridViewCorporateClient.TabIndex = 0;
            this.dataGridViewCorporateClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCorporateClient_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CorporateClientID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // LCDContactPerson
            // 
            this.LCDContactPerson.DataPropertyName = "LCDContactPerson";
            this.LCDContactPerson.HeaderText = "LCD Contact Person";
            this.LCDContactPerson.Name = "LCDContactPerson";
            this.LCDContactPerson.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Visible = false;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Visible = false;
            // 
            // HOAddress
            // 
            this.HOAddress.DataPropertyName = "HOAddress";
            this.HOAddress.HeaderText = "HOAddress";
            this.HOAddress.Name = "HOAddress";
            this.HOAddress.ReadOnly = true;
            this.HOAddress.Visible = false;
            // 
            // LCDepartment
            // 
            this.LCDepartment.DataPropertyName = "LCDepartment";
            this.LCDepartment.HeaderText = "LCDepartment";
            this.LCDepartment.Name = "LCDepartment";
            this.LCDepartment.ReadOnly = true;
            this.LCDepartment.Visible = false;
            // 
            // LCDContactPersonPhone
            // 
            this.LCDContactPersonPhone.DataPropertyName = "LCDContactPersonPhone";
            this.LCDContactPersonPhone.HeaderText = "LCDContactPersonPhone";
            this.LCDContactPersonPhone.Name = "LCDContactPersonPhone";
            this.LCDContactPersonPhone.ReadOnly = true;
            this.LCDContactPersonPhone.Visible = false;
            // 
            // LCDContactPersonEmail
            // 
            this.LCDContactPersonEmail.DataPropertyName = "LCDContactPersonEmail";
            this.LCDContactPersonEmail.HeaderText = "LCDContactPersonEmail";
            this.LCDContactPersonEmail.Name = "LCDContactPersonEmail";
            this.LCDContactPersonEmail.ReadOnly = true;
            this.LCDContactPersonEmail.Visible = false;
            // 
            // SLA
            // 
            this.SLA.DataPropertyName = "SLA";
            this.SLA.HeaderText = "SLA";
            this.SLA.Name = "SLA";
            this.SLA.ReadOnly = true;
            this.SLA.Visible = false;
            // 
            // Contract
            // 
            this.Contract.FillWeight = 40.20303F;
            this.Contract.HeaderText = "";
            this.Contract.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Contract.Name = "Contract";
            this.Contract.ReadOnly = true;
            this.Contract.Text = "Contract";
            this.Contract.UseColumnTextForLinkValue = true;
            // 
            // EditButton
            // 
            this.EditButton.DataPropertyName = "CorporateClientID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(84, 0, 84, 0);
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(84, 0, 84, 0);
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // btnAddNewCorporate
            // 
            this.btnAddNewCorporate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCorporate.Location = new System.Drawing.Point(94, 46);
            this.btnAddNewCorporate.Name = "btnAddNewCorporate";
            this.btnAddNewCorporate.Size = new System.Drawing.Size(151, 37);
            this.btnAddNewCorporate.TabIndex = 1;
            this.btnAddNewCorporate.Text = "Add New Corporate";
            this.btnAddNewCorporate.UseVisualStyleBackColor = true;
            this.btnAddNewCorporate.Click += new System.EventHandler(this.btnAddNewCorporate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblShowRows);
            this.groupBox1.Controls.Add(this.cmbShowRow);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(94, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(229, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblShowRows
            // 
            this.lblShowRows.AutoSize = true;
            this.lblShowRows.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShowRows.Location = new System.Drawing.Point(837, 22);
            this.lblShowRows.Name = "lblShowRows";
            this.lblShowRows.Size = new System.Drawing.Size(82, 20);
            this.lblShowRows.TabIndex = 2;
            this.lblShowRows.Text = "Show rows";
            this.lblShowRows.Click += new System.EventHandler(this.lblShowRows_Click);
            // 
            // cmbShowRow
            // 
            this.cmbShowRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShowRow.FormattingEnabled = true;
            this.cmbShowRow.Location = new System.Drawing.Point(923, 19);
            this.cmbShowRow.Name = "cmbShowRow";
            this.cmbShowRow.Size = new System.Drawing.Size(100, 28);
            this.cmbShowRow.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 22);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.FillWeight = 40.20303F;
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lCDContactPersonMobileDataGridViewTextBoxColumn
            // 
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.DataPropertyName = "LCDContactPersonMobile";
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.FillWeight = 40.20303F;
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.Name = "lCDContactPersonMobileDataGridViewTextBoxColumn";
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corporateClientInfoBindingSource
            // 
            this.corporateClientInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.CorporateClient.CorporateClientInfo);
            // 
            // frmGridCorporateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1362, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddNewCorporate);
            this.Controls.Add(this.dataGridViewCorporateClient);
            this.Name = "frmGridCorporateClient";
            this.Text = "Corporate Client Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGridCorporateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorporateClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corporateClientInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource corporateClientInfoBindingSource;
        private System.Windows.Forms.Button btnAddNewCorporate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblShowRows;
        private System.Windows.Forms.ComboBox cmbShowRow;
        internal System.Windows.Forms.DataGridView dataGridViewCorporateClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCDContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDContactPersonMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCDContactPersonPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCDContactPersonEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLA;
        private System.Windows.Forms.DataGridViewLinkColumn Contract;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.Button btnSearch;
    }
}