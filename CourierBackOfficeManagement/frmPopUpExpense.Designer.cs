namespace CourierBackOfficeManagement
{
    partial class frmPopUpExpense
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
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.lblExpenseTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenseTitle.Location = new System.Drawing.Point(12, 37);
            this.txtExpenseTitle.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtExpenseTitle.Multiline = true;
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.Size = new System.Drawing.Size(200, 28);
            this.txtExpenseTitle.TabIndex = 0;
            this.txtExpenseTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtExpenseTitle_Validating);
            // 
            // lblExpenseTitle
            // 
            this.lblExpenseTitle.AutoSize = true;
            this.lblExpenseTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblExpenseTitle.Location = new System.Drawing.Point(9, 17);
            this.lblExpenseTitle.Name = "lblExpenseTitle";
            this.lblExpenseTitle.Size = new System.Drawing.Size(93, 17);
            this.lblExpenseTitle.TabIndex = 17;
            this.lblExpenseTitle.Text = "Expense Title*";
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
            this.btnSave.Location = new System.Drawing.Point(234, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPopUpExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 89);
            this.Controls.Add(this.lblExpenseTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExpenseTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopUpExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expense Title";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblExpenseTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}