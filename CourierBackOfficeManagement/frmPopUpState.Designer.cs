namespace CourierBackOfficeManagement
{
    partial class frmPopUpState
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
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.lblStateName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStateName
            // 
            this.txtStateName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateName.Location = new System.Drawing.Point(25, 34);
            this.txtStateName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtStateName.Multiline = true;
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(200, 28);
            this.txtStateName.TabIndex = 0;
            this.txtStateName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStateName_Validating);
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.Location = new System.Drawing.Point(138, 14);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.Size = new System.Drawing.Size(54, 13);
            this.lblCountryID.TabIndex = 2;
            this.lblCountryID.Text = "CountryID";
            this.lblCountryID.Visible = false;
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblStateName.Location = new System.Drawing.Point(22, 14);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(85, 17);
            this.lblStateName.TabIndex = 9;
            this.lblStateName.Text = "State Name*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CourierBackOfficeManagement.Properties.Resources.save10;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(243, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPopUpState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 88);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.lblCountryID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStateName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopUpState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add State";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStateName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCountryID;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}