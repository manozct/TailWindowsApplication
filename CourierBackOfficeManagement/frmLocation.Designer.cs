namespace CourierBackOfficeManagement
{
    partial class frmLocation
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
            this.cmbCountryName = new System.Windows.Forms.ComboBox();
            this.cmbStateName = new System.Windows.Forms.ComboBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.lblStateID = new System.Windows.Forms.Label();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblStateName = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.btnAddState = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCountryName
            // 
            this.cmbCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountryName.FormattingEnabled = true;
            this.cmbCountryName.Location = new System.Drawing.Point(28, 32);
            this.cmbCountryName.Name = "cmbCountryName";
            this.cmbCountryName.Size = new System.Drawing.Size(200, 24);
            this.cmbCountryName.TabIndex = 11;
            this.cmbCountryName.SelectedValueChanged += new System.EventHandler(this.cmbCountryName_SelectedValueChanged);
            this.cmbCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCountryName_Validating);
            // 
            // cmbStateName
            // 
            this.cmbStateName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStateName.FormattingEnabled = true;
            this.cmbStateName.Location = new System.Drawing.Point(28, 83);
            this.cmbStateName.Name = "cmbStateName";
            this.cmbStateName.Size = new System.Drawing.Size(200, 25);
            this.cmbStateName.TabIndex = 11;
            this.cmbStateName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStateName_Validating);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.Location = new System.Drawing.Point(28, 139);
            this.txtLocationName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtLocationName.Multiline = true;
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(200, 28);
            this.txtLocationName.TabIndex = 2;
            this.txtLocationName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLocationName_Validating);
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.Location = new System.Drawing.Point(155, 12);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.Size = new System.Drawing.Size(54, 13);
            this.lblCountryID.TabIndex = 12;
            this.lblCountryID.Text = "CountryID";
            this.lblCountryID.Visible = false;
            // 
            // lblStateID
            // 
            this.lblStateID.AutoSize = true;
            this.lblStateID.Location = new System.Drawing.Point(155, 67);
            this.lblStateID.Name = "lblStateID";
            this.lblStateID.Size = new System.Drawing.Size(43, 13);
            this.lblStateID.TabIndex = 13;
            this.lblStateID.Text = "StateID";
            this.lblStateID.Visible = false;
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(155, 123);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(59, 13);
            this.lblLocationID.TabIndex = 14;
            this.lblLocationID.Text = "LocationID";
            this.lblLocationID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCountryName.Location = new System.Drawing.Point(25, 12);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(104, 17);
            this.lblCountryName.TabIndex = 15;
            this.lblCountryName.Text = "Country Name*";
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblStateName.Location = new System.Drawing.Point(25, 64);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(85, 17);
            this.lblStateName.TabIndex = 16;
            this.lblStateName.Text = "State Name*";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLocationName.Location = new System.Drawing.Point(25, 120);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(105, 17);
            this.lblLocationName.TabIndex = 17;
            this.lblLocationName.Text = "Location Name*";
            // 
            // btnAddState
            // 
            this.btnAddState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddState.Image = global::CourierBackOfficeManagement.Properties.Resources.add10;
            this.btnAddState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddState.Location = new System.Drawing.Point(249, 80);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(101, 31);
            this.btnAddState.TabIndex = 5;
            this.btnAddState.Text = "Add State";
            this.btnAddState.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::CourierBackOfficeManagement.Properties.Resources.button_cancel8;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(132, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CourierBackOfficeManagement.Properties.Resources.save9;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(28, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 248);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblLocationID);
            this.Controls.Add(this.lblStateID);
            this.Controls.Add(this.lblCountryID);
            this.Controls.Add(this.btnAddState);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.cmbStateName);
            this.Controls.Add(this.cmbCountryName);
            this.MaximizeBox = false;
            this.Name = "frmLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Location";
            this.Load += new System.EventHandler(this.frmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStateName;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.Label lblCountryID;
        private System.Windows.Forms.Label lblStateID;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblStateName;
        public System.Windows.Forms.ComboBox cmbCountryName;
    }
}