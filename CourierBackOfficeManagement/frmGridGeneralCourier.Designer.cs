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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCourierNumber = new System.Windows.Forms.Label();
            this.cmbShowRows = new System.Windows.Forms.ComboBox();
            this.lblShowRows = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewGeneralCourier = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmGeneralCourierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourierNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSenderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.generalCourierInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReferesh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNewCourier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralCourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalCourierInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnReferesh);
            this.groupBox1.Controls.Add(this.lblCourierNumber);
            this.groupBox1.Controls.Add(this.cmbShowRows);
            this.groupBox1.Controls.Add(this.lblShowRows);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(89, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblCourierNumber
            // 
            this.lblCourierNumber.AutoSize = true;
            this.lblCourierNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourierNumber.Location = new System.Drawing.Point(15, 19);
            this.lblCourierNumber.Name = "lblCourierNumber";
            this.lblCourierNumber.Size = new System.Drawing.Size(121, 20);
            this.lblCourierNumber.TabIndex = 8;
            this.lblCourierNumber.Text = "Courier Number";
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(142, 16);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 28);
            this.txtSearch.TabIndex = 4;
            // 
            // dataGridViewGeneralCourier
            // 
            this.dataGridViewGeneralCourier.AllowUserToAddRows = false;
            this.dataGridViewGeneralCourier.AllowUserToDeleteRows = false;
            this.dataGridViewGeneralCourier.AllowUserToResizeColumns = false;
            this.dataGridViewGeneralCourier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewGeneralCourier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGeneralCourier.AutoGenerateColumns = false;
            this.dataGridViewGeneralCourier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGeneralCourier.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneralCourier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGeneralCourier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneralCourier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmGeneralCourierID,
            this.clmCourierNumer,
            this.clmReceiverAddress,
            this.clmSenderAddress,
            this.clmSender,
            this.clmReceiver,
            this.clmEdit,
            this.clmDelete});
            this.dataGridViewGeneralCourier.DataSource = this.generalCourierInfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGeneralCourier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGeneralCourier.Location = new System.Drawing.Point(89, 169);
            this.dataGridViewGeneralCourier.Name = "dataGridViewGeneralCourier";
            this.dataGridViewGeneralCourier.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneralCourier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGeneralCourier.RowHeadersWidth = 50;
            this.dataGridViewGeneralCourier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewGeneralCourier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGeneralCourier.Size = new System.Drawing.Size(1200, 450);
            this.dataGridViewGeneralCourier.TabIndex = 4;
            this.dataGridViewGeneralCourier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGeneralCourier_CellContentClick);
            this.dataGridViewGeneralCourier.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewGeneralCourier_DataBindingComplete);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CourierBackOfficeManagement.Properties.Resources.btn_edit6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 574;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CourierBackOfficeManagement.Properties.Resources.delete6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 574;
            // 
            // clmGeneralCourierID
            // 
            this.clmGeneralCourierID.DataPropertyName = "GeneralCourierID";
            this.clmGeneralCourierID.HeaderText = "GeneralCourierID";
            this.clmGeneralCourierID.Name = "clmGeneralCourierID";
            this.clmGeneralCourierID.ReadOnly = true;
            this.clmGeneralCourierID.Visible = false;
            // 
            // clmCourierNumer
            // 
            this.clmCourierNumer.DataPropertyName = "CourierNumber";
            this.clmCourierNumer.HeaderText = "Courier Number";
            this.clmCourierNumer.Name = "clmCourierNumer";
            this.clmCourierNumer.ReadOnly = true;
            // 
            // clmReceiverAddress
            // 
            this.clmReceiverAddress.DataPropertyName = "ReceiverAddress";
            this.clmReceiverAddress.HeaderText = "Receiver Address";
            this.clmReceiverAddress.Name = "clmReceiverAddress";
            this.clmReceiverAddress.ReadOnly = true;
            // 
            // clmSenderAddress
            // 
            this.clmSenderAddress.DataPropertyName = "SenderAddress";
            this.clmSenderAddress.HeaderText = "Sender Address";
            this.clmSenderAddress.Name = "clmSenderAddress";
            this.clmSenderAddress.ReadOnly = true;
            // 
            // clmSender
            // 
            this.clmSender.DataPropertyName = "SenderFullName";
            this.clmSender.HeaderText = "Sender";
            this.clmSender.Name = "clmSender";
            this.clmSender.ReadOnly = true;
            // 
            // clmReceiver
            // 
            this.clmReceiver.DataPropertyName = "ReceiverFullName";
            this.clmReceiver.HeaderText = "Receiver";
            this.clmReceiver.Name = "clmReceiver";
            this.clmReceiver.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Image = global::CourierBackOfficeManagement.Properties.Resources.btn_edit6;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::CourierBackOfficeManagement.Properties.Resources.delete6;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // generalCourierInfoBindingSource
            // 
            this.generalCourierInfoBindingSource.DataSource = typeof(CourierBackOfficeManagement.GeneralCourier.GeneralCourierInfo);
            // 
            // btnReferesh
            // 
            this.btnReferesh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferesh.Image = global::CourierBackOfficeManagement.Properties.Resources.refresh5;
            this.btnReferesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferesh.Location = new System.Drawing.Point(462, 15);
            this.btnReferesh.Name = "btnReferesh";
            this.btnReferesh.Size = new System.Drawing.Size(96, 30);
            this.btnReferesh.TabIndex = 9;
            this.btnReferesh.Text = "Refresh";
            this.btnReferesh.UseVisualStyleBackColor = true;
            this.btnReferesh.Click += new System.EventHandler(this.btnReferesh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::CourierBackOfficeManagement.Properties.Resources.search5;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(348, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewCourier
            // 
            this.btnAddNewCourier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourier.Image = global::CourierBackOfficeManagement.Properties.Resources.add6;
            this.btnAddNewCourier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCourier.Location = new System.Drawing.Point(89, 54);
            this.btnAddNewCourier.Name = "btnAddNewCourier";
            this.btnAddNewCourier.Size = new System.Drawing.Size(123, 30);
            this.btnAddNewCourier.TabIndex = 2;
            this.btnAddNewCourier.Text = "     New Courier";
            this.btnAddNewCourier.UseVisualStyleBackColor = true;
            this.btnAddNewCourier.Click += new System.EventHandler(this.btnAddNewCourier_Click);
            // 
            // frmGridGeneralCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.dataGridViewGeneralCourier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddNewCourier);
            this.Name = "frmGridGeneralCourier";
            this.Text = "General Courier Data List Management";
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
        private System.Windows.Forms.BindingSource generalCourierInfoBindingSource;
        private System.Windows.Forms.Label lblShowRows;
        private System.Windows.Forms.ComboBox cmbShowRows;
        private System.Windows.Forms.Label lblCourierNumber;
        private System.Windows.Forms.Button btnReferesh;
        public System.Windows.Forms.DataGridView dataGridViewGeneralCourier;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGeneralCourierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourierNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSenderAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiver;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}