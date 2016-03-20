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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGridCorporateClient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCorporateName = new System.Windows.Forms.Label();
            this.cmbShowRows = new System.Windows.Forms.ComboBox();
            this.lblShowRows = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewCorporateClient = new System.Windows.Forms.DataGridView();
            this.clmCorporateClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDContactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDContactPersonMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContract = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.corporateClientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddNewCorporate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorporateClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporateClientInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblCorporateName);
            this.groupBox1.Controls.Add(this.cmbShowRows);
            this.groupBox1.Controls.Add(this.lblShowRows);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(89, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(473, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCorporateName
            // 
            this.lblCorporateName.AutoSize = true;
            this.lblCorporateName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorporateName.Location = new System.Drawing.Point(15, 19);
            this.lblCorporateName.Name = "lblCorporateName";
            this.lblCorporateName.Size = new System.Drawing.Size(123, 20);
            this.lblCorporateName.TabIndex = 8;
            this.lblCorporateName.Text = "Corporate Name";
            // 
            // cmbShowRows
            // 
            this.cmbShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShowRows.FormattingEnabled = true;
            this.cmbShowRows.Location = new System.Drawing.Point(1040, 19);
            this.cmbShowRows.Name = "cmbShowRows";
            this.cmbShowRows.Size = new System.Drawing.Size(100, 24);
            this.cmbShowRows.TabIndex = 7;
            this.cmbShowRows.SelectedValueChanged += new System.EventHandler(this.cmbShowRows_SelectedValueChanged);
            // 
            // lblShowRows
            // 
            this.lblShowRows.AutoSize = true;
            this.lblShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRows.Location = new System.Drawing.Point(951, 22);
            this.lblShowRows.Name = "lblShowRows";
            this.lblShowRows.Size = new System.Drawing.Size(89, 18);
            this.lblShowRows.TabIndex = 6;
            this.lblShowRows.Text = "Show Rows";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::CourierBackOfficeManagement.Properties.Resources.search8;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(358, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "  Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(142, 16);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 28);
            this.txtSearch.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 383;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 287;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 287;
            // 
            // dataGridViewCorporateClient
            // 
            this.dataGridViewCorporateClient.AllowUserToAddRows = false;
            this.dataGridViewCorporateClient.AllowUserToDeleteRows = false;
            this.dataGridViewCorporateClient.AllowUserToResizeColumns = false;
            this.dataGridViewCorporateClient.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewCorporateClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCorporateClient.AutoGenerateColumns = false;
            this.dataGridViewCorporateClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCorporateClient.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCorporateClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCorporateClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorporateClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCorporateClientID,
            this.clientNameDataGridViewTextBoxColumn,
            this.lCDContactPersonDataGridViewTextBoxColumn,
            this.lCDContactPersonMobileDataGridViewTextBoxColumn,
            this.clmContract,
            this.clmEdit,
            this.clmDelete});
            this.dataGridViewCorporateClient.DataSource = this.corporateClientInfoBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCorporateClient.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCorporateClient.Location = new System.Drawing.Point(89, 147);
            this.dataGridViewCorporateClient.Name = "dataGridViewCorporateClient";
            this.dataGridViewCorporateClient.ReadOnly = true;
            this.dataGridViewCorporateClient.RowHeadersWidth = 50;
            this.dataGridViewCorporateClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCorporateClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCorporateClient.Size = new System.Drawing.Size(1200, 450);
            this.dataGridViewCorporateClient.TabIndex = 6;
            this.dataGridViewCorporateClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCorporateClient_CellContentClick);
            this.dataGridViewCorporateClient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCorporateClient_DataBindingComplete);
            // 
            // clmCorporateClientID
            // 
            this.clmCorporateClientID.DataPropertyName = "CorporateClientID";
            this.clmCorporateClientID.HeaderText = "CorporateClientID";
            this.clmCorporateClientID.Name = "clmCorporateClientID";
            this.clmCorporateClientID.ReadOnly = true;
            this.clmCorporateClientID.Visible = false;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lCDContactPersonDataGridViewTextBoxColumn
            // 
            this.lCDContactPersonDataGridViewTextBoxColumn.DataPropertyName = "LCDContactPerson";
            this.lCDContactPersonDataGridViewTextBoxColumn.HeaderText = "LCD Contact Person";
            this.lCDContactPersonDataGridViewTextBoxColumn.Name = "lCDContactPersonDataGridViewTextBoxColumn";
            this.lCDContactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lCDContactPersonMobileDataGridViewTextBoxColumn
            // 
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.DataPropertyName = "LCDContactPersonMobile";
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.Name = "lCDContactPersonMobileDataGridViewTextBoxColumn";
            this.lCDContactPersonMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clmContract
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmContract.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmContract.HeaderText = "";
            this.clmContract.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.clmContract.Name = "clmContract";
            this.clmContract.ReadOnly = true;
            this.clmContract.Text = "Contract";
            this.clmContract.UseColumnTextForLinkValue = true;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Image = global::CourierBackOfficeManagement.Properties.Resources.btn_edit10;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::CourierBackOfficeManagement.Properties.Resources.delete10;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // corporateClientInfoBindingSource
            // 
            this.corporateClientInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.CorporateClient.CorporateClientInfo);
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Width = 287;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Width = 287;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Width = 287;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "";
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.ReadOnly = true;
            this.dataGridViewImageColumn7.Width = 287;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.HeaderText = "";
            this.dataGridViewImageColumn8.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn8.Image")));
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.ReadOnly = true;
            this.dataGridViewImageColumn8.Width = 287;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.HeaderText = "";
            this.dataGridViewImageColumn9.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn9.Image")));
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.ReadOnly = true;
            this.dataGridViewImageColumn9.Width = 287;
            // 
            // btnAddNewCorporate
            // 
            this.btnAddNewCorporate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCorporate.Image = global::CourierBackOfficeManagement.Properties.Resources.add10;
            this.btnAddNewCorporate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCorporate.Location = new System.Drawing.Point(89, 34);
            this.btnAddNewCorporate.Name = "btnAddNewCorporate";
            this.btnAddNewCorporate.Size = new System.Drawing.Size(138, 30);
            this.btnAddNewCorporate.TabIndex = 5;
            this.btnAddNewCorporate.Text = "     New Corporate";
            this.btnAddNewCorporate.UseVisualStyleBackColor = true;
            this.btnAddNewCorporate.Click += new System.EventHandler(this.btnAddNewCorporate_Click);
            // 
            // frmGridCorporateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.dataGridViewCorporateClient);
            this.Controls.Add(this.btnAddNewCorporate);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGridCorporateClient";
            this.Text = "Corporate Client Data List Management";
            this.Load += new System.EventHandler(this.frmGridCorporateClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorporateClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporateClientInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorporateName;
        private System.Windows.Forms.ComboBox cmbShowRows;
        private System.Windows.Forms.Label lblShowRows;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNewCorporate;
        private System.Windows.Forms.BindingSource corporateClientInfoBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridView dataGridViewCorporateClient;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorporateClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDContactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDContactPersonMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn clmContract;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}