namespace CourierBackOfficeManagement
{
    partial class frmGridLocation
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
            this.btnAddNewState = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.cmbShowRows = new System.Windows.Forms.ComboBox();
            this.lblShowRows = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchByLocationName = new System.Windows.Forms.TextBox();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.clmLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.locationInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNewLocation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewState
            // 
            this.btnAddNewState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewState.Location = new System.Drawing.Point(-252, 154);
            this.btnAddNewState.Name = "btnAddNewState";
            this.btnAddNewState.Size = new System.Drawing.Size(136, 30);
            this.btnAddNewState.TabIndex = 13;
            this.btnAddNewState.Text = "Add New State";
            this.btnAddNewState.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblLocationName);
            this.groupBox1.Controls.Add(this.cmbShowRows);
            this.groupBox1.Controls.Add(this.lblShowRows);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchByLocationName);
            this.groupBox1.Location = new System.Drawing.Point(34, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::CourierBackOfficeManagement.Properties.Resources.refresh7;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(432, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(6, 20);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(112, 20);
            this.lblLocationName.TabIndex = 8;
            this.lblLocationName.Text = "Location Name";
            // 
            // cmbShowRows
            // 
            this.cmbShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShowRows.FormattingEnabled = true;
            this.cmbShowRows.Location = new System.Drawing.Point(655, 19);
            this.cmbShowRows.Name = "cmbShowRows";
            this.cmbShowRows.Size = new System.Drawing.Size(100, 24);
            this.cmbShowRows.TabIndex = 7;
            this.cmbShowRows.SelectedValueChanged += new System.EventHandler(this.cmbShowRows_SelectedValueChanged);
            // 
            // lblShowRows
            // 
            this.lblShowRows.AutoSize = true;
            this.lblShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRows.Location = new System.Drawing.Point(560, 22);
            this.lblShowRows.Name = "lblShowRows";
            this.lblShowRows.Size = new System.Drawing.Size(89, 18);
            this.lblShowRows.TabIndex = 6;
            this.lblShowRows.Text = "Show Rows";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::CourierBackOfficeManagement.Properties.Resources.search7;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(330, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchByLocationName
            // 
            this.txtSearchByLocationName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByLocationName.Location = new System.Drawing.Point(124, 16);
            this.txtSearchByLocationName.Multiline = true;
            this.txtSearchByLocationName.Name = "txtSearchByLocationName";
            this.txtSearchByLocationName.Size = new System.Drawing.Size(200, 28);
            this.txtSearchByLocationName.TabIndex = 4;
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.AllowUserToAddRows = false;
            this.dataGridViewLocation.AllowUserToDeleteRows = false;
            this.dataGridViewLocation.AllowUserToResizeColumns = false;
            this.dataGridViewLocation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewLocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLocation.AutoGenerateColumns = false;
            this.dataGridViewLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLocation.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLocationID,
            this.locationNameDataGridViewTextBoxColumn,
            this.clmEdit,
            this.clmDelete});
            this.dataGridViewLocation.DataSource = this.locationInfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLocation.Location = new System.Drawing.Point(34, 126);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.RowHeadersWidth = 50;
            this.dataGridViewLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocation.Size = new System.Drawing.Size(774, 600);
            this.dataGridViewLocation.TabIndex = 15;
            this.dataGridViewLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocation_CellContentClick);
            this.dataGridViewLocation.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewLocation_DataBindingComplete);
            // 
            // clmLocationID
            // 
            this.clmLocationID.DataPropertyName = "LocationID";
            this.clmLocationID.HeaderText = "LocationID";
            this.clmLocationID.Name = "clmLocationID";
            this.clmLocationID.ReadOnly = true;
            this.clmLocationID.Visible = false;
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "Location Name";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Image = global::CourierBackOfficeManagement.Properties.Resources.btn_edit8;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::CourierBackOfficeManagement.Properties.Resources.delete9;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // locationInfoBindingSource
            // 
            this.locationInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.Location.LocationInfo);
            // 
            // btnAddNewLocation
            // 
            this.btnAddNewLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLocation.Image = global::CourierBackOfficeManagement.Properties.Resources.add9;
            this.btnAddNewLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewLocation.Location = new System.Drawing.Point(34, 23);
            this.btnAddNewLocation.Name = "btnAddNewLocation";
            this.btnAddNewLocation.Size = new System.Drawing.Size(136, 30);
            this.btnAddNewLocation.TabIndex = 14;
            this.btnAddNewLocation.Text = "New Location";
            this.btnAddNewLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewLocation.UseVisualStyleBackColor = true;
            this.btnAddNewLocation.Click += new System.EventHandler(this.btnAddNewLocation_Click);
            // 
            // frmGridLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.dataGridViewLocation);
            this.Controls.Add(this.btnAddNewLocation);
            this.Controls.Add(this.btnAddNewState);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmGridLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location List";
            this.Load += new System.EventHandler(this.frmGridLocation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.ComboBox cmbShowRows;
        private System.Windows.Forms.Label lblShowRows;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchByLocationName;
        private System.Windows.Forms.Button btnAddNewLocation;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.BindingSource locationInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}