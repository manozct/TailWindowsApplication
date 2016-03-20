namespace CourierBackOfficeManagement
{
    partial class frmState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmState));
            this.cmbCountryName = new System.Windows.Forms.ComboBox();
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStateID = new System.Windows.Forms.Label();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCountryName
            // 
            this.cmbCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountryName.FormattingEnabled = true;
            this.cmbCountryName.Location = new System.Drawing.Point(36, 34);
            this.cmbCountryName.Name = "cmbCountryName";
            this.cmbCountryName.Size = new System.Drawing.Size(200, 24);
            this.cmbCountryName.TabIndex = 0;
            this.cmbCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCountryName_Validating);
            // 
            // txtStateName
            // 
            this.txtStateName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateName.Location = new System.Drawing.Point(35, 85);
            this.txtStateName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtStateName.Multiline = true;
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(200, 28);
            this.txtStateName.TabIndex = 1;
            this.txtStateName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStateName_Validating);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCountryName.Location = new System.Drawing.Point(33, 14);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(98, 17);
            this.lblCountryName.TabIndex = 20;
            this.lblCountryName.Text = "Country Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "State*";
            // 
            // lblStateID
            // 
            this.lblStateID.AutoSize = true;
            this.lblStateID.Location = new System.Drawing.Point(96, 69);
            this.lblStateID.Name = "lblStateID";
            this.lblStateID.Size = new System.Drawing.Size(43, 13);
            this.lblStateID.TabIndex = 22;
            this.lblStateID.Text = "StateID";
            this.lblStateID.Visible = false;
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.Location = new System.Drawing.Point(151, 17);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.Size = new System.Drawing.Size(54, 13);
            this.lblCountryID.TabIndex = 23;
            this.lblCountryID.Text = "CountryID";
            this.lblCountryID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(137, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(35, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 205);
            this.Controls.Add(this.lblCountryID);
            this.Controls.Add(this.lblStateID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.cmbCountryName);
            this.MaximizeBox = false;
            this.Name = "frmState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Add State";
            this.Load += new System.EventHandler(this.frmState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountryName;
        private System.Windows.Forms.TextBox txtStateName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStateID;
        private System.Windows.Forms.Label lblCountryID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
    }
}