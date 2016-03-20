namespace CourierBackOfficeManagement
{
    partial class frmExpense
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
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.rchtxtNote = new System.Windows.Forms.RichTextBox();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblExpenseID = new System.Windows.Forms.Label();
            this.lblExpenseHeadID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Items.AddRange(new object[] {
            "--Select Expense Type--"});
            this.cmbExpenseType.Location = new System.Drawing.Point(33, 37);
            this.cmbExpenseType.MinimumSize = new System.Drawing.Size(200, 0);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(200, 25);
            this.cmbExpenseType.TabIndex = 0;
            this.cmbExpenseType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbExpenseType_Validating);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(33, 88);
            this.txtCost.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 28);
            this.txtCost.TabIndex = 1;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // rchtxtNote
            // 
            this.rchtxtNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtNote.Location = new System.Drawing.Point(33, 149);
            this.rchtxtNote.Name = "rchtxtNote";
            this.rchtxtNote.Size = new System.Drawing.Size(200, 109);
            this.rchtxtNote.TabIndex = 2;
            this.rchtxtNote.Text = "";
            this.rchtxtNote.Validating += new System.ComponentModel.CancelEventHandler(this.rchtxtNote_Validating);
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblExpenseType.Location = new System.Drawing.Point(30, 17);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(96, 17);
            this.lblExpenseType.TabIndex = 16;
            this.lblExpenseType.Text = "Expense Type*";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCost.Location = new System.Drawing.Point(33, 68);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(75, 17);
            this.lblCost.TabIndex = 17;
            this.lblCost.Text = "Cost(NPR)*";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNote.Location = new System.Drawing.Point(33, 129);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(44, 17);
            this.lblNote.TabIndex = 18;
            this.lblNote.Text = "Note*";
            // 
            // lblExpenseID
            // 
            this.lblExpenseID.AutoSize = true;
            this.lblExpenseID.Location = new System.Drawing.Point(291, 94);
            this.lblExpenseID.Name = "lblExpenseID";
            this.lblExpenseID.Size = new System.Drawing.Size(59, 13);
            this.lblExpenseID.TabIndex = 19;
            this.lblExpenseID.Text = "ExpenseID";
            this.lblExpenseID.Visible = false;
            // 
            // lblExpenseHeadID
            // 
            this.lblExpenseHeadID.AutoSize = true;
            this.lblExpenseHeadID.Location = new System.Drawing.Point(291, 133);
            this.lblExpenseHeadID.Name = "lblExpenseHeadID";
            this.lblExpenseHeadID.Size = new System.Drawing.Size(85, 13);
            this.lblExpenseHeadID.TabIndex = 20;
            this.lblExpenseHeadID.Text = "ExpenseHeadID";
            this.lblExpenseHeadID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Image = global::CourierBackOfficeManagement.Properties.Resources.add7;
            this.btnAddExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExpense.Location = new System.Drawing.Point(239, 35);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(129, 31);
            this.btnAddExpense.TabIndex = 5;
            this.btnAddExpense.Text = "    Expense Title";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::CourierBackOfficeManagement.Properties.Resources.button_cancel5;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(137, 270);
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
            this.btnSave.Image = global::CourierBackOfficeManagement.Properties.Resources.save6;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(33, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 313);
            this.Controls.Add(this.lblExpenseHeadID);
            this.Controls.Add(this.lblExpenseID);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblExpenseType);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rchtxtNote);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.cmbExpenseType);
            this.MaximizeBox = false;
            this.Name = "frmExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Management";
            this.Load += new System.EventHandler(this.frmExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.RichTextBox rchtxtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label lblExpenseType;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblExpenseID;
        private System.Windows.Forms.Label lblExpenseHeadID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}