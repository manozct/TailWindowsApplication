namespace CourierBackOfficeManagement
{
    partial class frmGridCountry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.cmbShowRows = new System.Windows.Forms.ComboBox();
            this.lblShowRows = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewCountry = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddNewCountry = new System.Windows.Forms.Button();
            this.clmCountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.countryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.countryInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblCountryName);
            this.groupBox1.Controls.Add(this.cmbShowRows);
            this.groupBox1.Controls.Add(this.lblShowRows);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(25, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.Location = new System.Drawing.Point(15, 19);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(110, 20);
            this.lblCountryName.TabIndex = 8;
            this.lblCountryName.Text = "Country Name";
            // 
            // cmbShowRows
            // 
            this.cmbShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShowRows.FormattingEnabled = true;
            this.cmbShowRows.Location = new System.Drawing.Point(715, 17);
            this.cmbShowRows.Name = "cmbShowRows";
            this.cmbShowRows.Size = new System.Drawing.Size(100, 24);
            this.cmbShowRows.TabIndex = 7;
            this.cmbShowRows.SelectedValueChanged += new System.EventHandler(this.cmbShowRows_SelectedValueChanged);
            // 
            // lblShowRows
            // 
            this.lblShowRows.AutoSize = true;
            this.lblShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRows.Location = new System.Drawing.Point(620, 21);
            this.lblShowRows.Name = "lblShowRows";
            this.lblShowRows.Size = new System.Drawing.Size(89, 18);
            this.lblShowRows.TabIndex = 6;
            this.lblShowRows.Text = "Show Rows";
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
            // dataGridViewCountry
            // 
            this.dataGridViewCountry.AllowUserToAddRows = false;
            this.dataGridViewCountry.AllowUserToDeleteRows = false;
            this.dataGridViewCountry.AllowUserToResizeColumns = false;
            this.dataGridViewCountry.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewCountry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCountry.AutoGenerateColumns = false;
            this.dataGridViewCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCountry.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCountry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCountryID,
            this.countryNameDataGridViewTextBoxColumn,
            this.clmEdit,
            this.clmDelete});
            this.dataGridViewCountry.DataSource = this.countryInfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCountry.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCountry.Location = new System.Drawing.Point(25, 134);
            this.dataGridViewCountry.Name = "dataGridViewCountry";
            this.dataGridViewCountry.ReadOnly = true;
            this.dataGridViewCountry.RowHeadersWidth = 50;
            this.dataGridViewCountry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountry.Size = new System.Drawing.Size(850, 550);
            this.dataGridViewCountry.TabIndex = 8;
            this.dataGridViewCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountry_CellContentClick);
            this.dataGridViewCountry.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCountry_DataBindingComplete);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CourierBackOfficeManagement.Properties.Resources.btn_edit4;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 399;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CourierBackOfficeManagement.Properties.Resources.delete4;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 399;
            // 
            // btnAddNewCountry
            // 
            this.btnAddNewCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCountry.Image = global::CourierBackOfficeManagement.Properties.Resources.add4;
            this.btnAddNewCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCountry.Location = new System.Drawing.Point(25, 31);
            this.btnAddNewCountry.Name = "btnAddNewCountry";
            this.btnAddNewCountry.Size = new System.Drawing.Size(125, 30);
            this.btnAddNewCountry.TabIndex = 9;
            this.btnAddNewCountry.Text = "     New Country";
            this.btnAddNewCountry.UseVisualStyleBackColor = true;
            this.btnAddNewCountry.Click += new System.EventHandler(this.btnAddNewCountry_Click);
            // 
            // clmCountryID
            // 
            this.clmCountryID.DataPropertyName = "CountryID";
            this.clmCountryID.HeaderText = "Country ID";
            this.clmCountryID.Name = "clmCountryID";
            this.clmCountryID.ReadOnly = true;
            this.clmCountryID.Visible = false;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Country Name";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Image = global::CourierBackOfficeManagement.Properties.Resources.btn_edit4;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::CourierBackOfficeManagement.Properties.Resources.delete4;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // countryInfoBindingSource
            // 
            this.countryInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.Country.CountryInfo);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::CourierBackOfficeManagement.Properties.Resources.refresh3;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(470, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::CourierBackOfficeManagement.Properties.Resources.search3;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(358, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // countryInfoBindingSource1
            // 
            this.countryInfoBindingSource1.DataSource = typeof(CourierBackOfficeManagement.Country.CountryInfo);
            // 
            // frmGridCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.btnAddNewCountry);
            this.Controls.Add(this.dataGridViewCountry);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmGridCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country List Management";
            this.Load += new System.EventHandler(this.frmGridCountry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource countryInfoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.ComboBox cmbShowRows;
        private System.Windows.Forms.Label lblShowRows;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewCountry;
        private System.Windows.Forms.BindingSource countryInfoBindingSource1;
        private System.Windows.Forms.Button btnAddNewCountry;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}