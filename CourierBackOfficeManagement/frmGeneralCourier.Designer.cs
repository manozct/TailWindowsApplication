namespace CourierBackOfficeManagement
{
    partial class frmGeneralCourier
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
            this.txtCourierNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.txtReceiverPhone = new System.Windows.Forms.TextBox();
            this.txtReceiverMobile = new System.Windows.Forms.TextBox();
            this.txtReceiverLastName = new System.Windows.Forms.TextBox();
            this.txtReceiverMiddleName = new System.Windows.Forms.TextBox();
            this.txtReceiverFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.txtSenderPhone = new System.Windows.Forms.TextBox();
            this.txtSenderMobile = new System.Windows.Forms.TextBox();
            this.txtSenderLastName = new System.Windows.Forms.TextBox();
            this.txtSenderMiddleName = new System.Windows.Forms.TextBox();
            this.txtSenderFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNumberOfPackage = new System.Windows.Forms.TextBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.cmbWeightUnit = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCourierNumber
            // 
            this.txtCourierNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourierNumber.Location = new System.Drawing.Point(6, 34);
            this.txtCourierNumber.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtCourierNumber.Multiline = true;
            this.txtCourierNumber.Name = "txtCourierNumber";
            this.txtCourierNumber.Size = new System.Drawing.Size(200, 28);
            this.txtCourierNumber.TabIndex = 1;
            this.txtCourierNumber.TextChanged += new System.EventHandler(this.txtCourierNumber_TextChanged);
            this.txtCourierNumber.Enter += new System.EventHandler(this.txtCourierNumber_Enter);
            this.txtCourierNumber.Leave += new System.EventHandler(this.txtCourierNumber_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCourierNumber);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courier Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceiverAddress);
            this.groupBox2.Controls.Add(this.txtReceiverPhone);
            this.groupBox2.Controls.Add(this.txtReceiverMobile);
            this.groupBox2.Controls.Add(this.txtReceiverLastName);
            this.groupBox2.Controls.Add(this.txtReceiverMiddleName);
            this.groupBox2.Controls.Add(this.txtReceiverFirstName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiver";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverAddress.Location = new System.Drawing.Point(21, 141);
            this.txtReceiverAddress.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverAddress.Multiline = true;
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverAddress.TabIndex = 7;
            this.txtReceiverAddress.Enter += new System.EventHandler(this.txtReceiverAddress_Enter);
            this.txtReceiverAddress.Leave += new System.EventHandler(this.txtReceiverAddress_Leave);
            // 
            // txtReceiverPhone
            // 
            this.txtReceiverPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverPhone.Location = new System.Drawing.Point(275, 88);
            this.txtReceiverPhone.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverPhone.Multiline = true;
            this.txtReceiverPhone.Name = "txtReceiverPhone";
            this.txtReceiverPhone.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverPhone.TabIndex = 6;
            this.txtReceiverPhone.Enter += new System.EventHandler(this.txtReceiverPhone_Enter);
            this.txtReceiverPhone.Leave += new System.EventHandler(this.txtReceiverPhone_Leave);
            // 
            // txtReceiverMobile
            // 
            this.txtReceiverMobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverMobile.Location = new System.Drawing.Point(21, 88);
            this.txtReceiverMobile.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverMobile.Multiline = true;
            this.txtReceiverMobile.Name = "txtReceiverMobile";
            this.txtReceiverMobile.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverMobile.TabIndex = 5;
            this.txtReceiverMobile.Enter += new System.EventHandler(this.txtReceiverMobile_Enter);
            this.txtReceiverMobile.Leave += new System.EventHandler(this.txtReceiverMobile_Leave);
            // 
            // txtReceiverLastName
            // 
            this.txtReceiverLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverLastName.Location = new System.Drawing.Point(521, 37);
            this.txtReceiverLastName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverLastName.Multiline = true;
            this.txtReceiverLastName.Name = "txtReceiverLastName";
            this.txtReceiverLastName.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverLastName.TabIndex = 4;
            this.txtReceiverLastName.Enter += new System.EventHandler(this.txtReceiverLastName_Enter);
            this.txtReceiverLastName.Leave += new System.EventHandler(this.txtReceiverLastName_Leave);
            // 
            // txtReceiverMiddleName
            // 
            this.txtReceiverMiddleName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverMiddleName.Location = new System.Drawing.Point(275, 37);
            this.txtReceiverMiddleName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverMiddleName.Multiline = true;
            this.txtReceiverMiddleName.Name = "txtReceiverMiddleName";
            this.txtReceiverMiddleName.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverMiddleName.TabIndex = 3;
            this.txtReceiverMiddleName.Enter += new System.EventHandler(this.txtReceiverMiddleName_Enter);
            this.txtReceiverMiddleName.Leave += new System.EventHandler(this.txtReceiverMiddleName_Leave);
            // 
            // txtReceiverFirstName
            // 
            this.txtReceiverFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverFirstName.Location = new System.Drawing.Point(21, 37);
            this.txtReceiverFirstName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverFirstName.Multiline = true;
            this.txtReceiverFirstName.Name = "txtReceiverFirstName";
            this.txtReceiverFirstName.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverFirstName.TabIndex = 2;
            this.txtReceiverFirstName.TextChanged += new System.EventHandler(this.txtReciverFirstName_TextChanged);
            this.txtReceiverFirstName.Enter += new System.EventHandler(this.txtReciverFirstName_Enter);
            this.txtReceiverFirstName.Leave += new System.EventHandler(this.txtReciverFirstName_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(49, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Package Details";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(521, 24);
            this.textBox10.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(200, 30);
            this.textBox10.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(275, 24);
            this.textBox9.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(200, 30);
            this.textBox9.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSenderAddress);
            this.groupBox4.Controls.Add(this.txtSenderPhone);
            this.groupBox4.Controls.Add(this.txtSenderMobile);
            this.groupBox4.Controls.Add(this.txtSenderLastName);
            this.groupBox4.Controls.Add(this.txtSenderMiddleName);
            this.groupBox4.Controls.Add(this.txtSenderFirstName);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(49, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(738, 171);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sender";
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderAddress.Location = new System.Drawing.Point(21, 135);
            this.txtSenderAddress.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderAddress.Multiline = true;
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(200, 28);
            this.txtSenderAddress.TabIndex = 17;
            this.txtSenderAddress.Enter += new System.EventHandler(this.txtSenderAddress_Enter);
            this.txtSenderAddress.Leave += new System.EventHandler(this.txtSenderAddress_Leave);
            // 
            // txtSenderPhone
            // 
            this.txtSenderPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderPhone.Location = new System.Drawing.Point(275, 80);
            this.txtSenderPhone.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderPhone.Multiline = true;
            this.txtSenderPhone.Name = "txtSenderPhone";
            this.txtSenderPhone.Size = new System.Drawing.Size(200, 28);
            this.txtSenderPhone.TabIndex = 16;
            this.txtSenderPhone.Enter += new System.EventHandler(this.txtSenderPhone_Enter);
            this.txtSenderPhone.Leave += new System.EventHandler(this.txtSenderPhone_Leave);
            // 
            // txtSenderMobile
            // 
            this.txtSenderMobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderMobile.Location = new System.Drawing.Point(21, 80);
            this.txtSenderMobile.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderMobile.Multiline = true;
            this.txtSenderMobile.Name = "txtSenderMobile";
            this.txtSenderMobile.Size = new System.Drawing.Size(200, 28);
            this.txtSenderMobile.TabIndex = 15;
            this.txtSenderMobile.Enter += new System.EventHandler(this.txtSenderMobile_Enter);
            this.txtSenderMobile.Leave += new System.EventHandler(this.txtSenderMobile_Leave);
            // 
            // txtSenderLastName
            // 
            this.txtSenderLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderLastName.Location = new System.Drawing.Point(521, 30);
            this.txtSenderLastName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderLastName.Multiline = true;
            this.txtSenderLastName.Name = "txtSenderLastName";
            this.txtSenderLastName.Size = new System.Drawing.Size(200, 28);
            this.txtSenderLastName.TabIndex = 14;
            this.txtSenderLastName.Enter += new System.EventHandler(this.txtSenderLastName_Enter);
            this.txtSenderLastName.Leave += new System.EventHandler(this.txtSenderLastName_Leave);
            // 
            // txtSenderMiddleName
            // 
            this.txtSenderMiddleName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderMiddleName.Location = new System.Drawing.Point(275, 30);
            this.txtSenderMiddleName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderMiddleName.Multiline = true;
            this.txtSenderMiddleName.Name = "txtSenderMiddleName";
            this.txtSenderMiddleName.Size = new System.Drawing.Size(200, 28);
            this.txtSenderMiddleName.TabIndex = 13;
            this.txtSenderMiddleName.Enter += new System.EventHandler(this.txtSenderMiddleName_Enter);
            this.txtSenderMiddleName.Leave += new System.EventHandler(this.txtSenderMiddleName_Leave);
            // 
            // txtSenderFirstName
            // 
            this.txtSenderFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderFirstName.Location = new System.Drawing.Point(21, 30);
            this.txtSenderFirstName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderFirstName.Multiline = true;
            this.txtSenderFirstName.Name = "txtSenderFirstName";
            this.txtSenderFirstName.Size = new System.Drawing.Size(200, 28);
            this.txtSenderFirstName.TabIndex = 12;
            this.txtSenderFirstName.Enter += new System.EventHandler(this.txtSenderFirstName_Enter);
            this.txtSenderFirstName.Leave += new System.EventHandler(this.txtSenderFirstName_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(49, 644);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(181, 644);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNumberOfPackage);
            this.groupBox5.Controls.Add(this.cmbServiceType);
            this.groupBox5.Controls.Add(this.cmbWeightUnit);
            this.groupBox5.Controls.Add(this.txtWeight);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(49, 347);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(738, 81);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Package Details";
            // 
            // txtNumberOfPackage
            // 
            this.txtNumberOfPackage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPackage.Location = new System.Drawing.Point(21, 35);
            this.txtNumberOfPackage.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtNumberOfPackage.Multiline = true;
            this.txtNumberOfPackage.Name = "txtNumberOfPackage";
            this.txtNumberOfPackage.Size = new System.Drawing.Size(200, 28);
            this.txtNumberOfPackage.TabIndex = 8;
            this.txtNumberOfPackage.Enter += new System.EventHandler(this.txtNumberOfPackage_Enter);
            this.txtNumberOfPackage.Leave += new System.EventHandler(this.txtNumberOfPackage_Leave);
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "On Air ",
            "By Land"});
            this.cmbServiceType.Location = new System.Drawing.Point(521, 35);
            this.cmbServiceType.MinimumSize = new System.Drawing.Size(200, 0);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(200, 28);
            this.cmbServiceType.TabIndex = 11;
            // 
            // cmbWeightUnit
            // 
            this.cmbWeightUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeightUnit.FormattingEnabled = true;
            this.cmbWeightUnit.Items.AddRange(new object[] {
            "Kg",
            "Gm"});
            this.cmbWeightUnit.Location = new System.Drawing.Point(371, 35);
            this.cmbWeightUnit.MinimumSize = new System.Drawing.Size(121, 0);
            this.cmbWeightUnit.Name = "cmbWeightUnit";
            this.cmbWeightUnit.Size = new System.Drawing.Size(121, 28);
            this.cmbWeightUnit.TabIndex = 10;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(275, 35);
            this.txtWeight.MinimumSize = new System.Drawing.Size(90, 28);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(90, 28);
            this.txtWeight.TabIndex = 9;
            this.txtWeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtWeight.Enter += new System.EventHandler(this.txtWeight_Enter);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // frmGeneralCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 726);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmGeneralCourier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Courier Management";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txtCourierNumber;
        public System.Windows.Forms.TextBox txtReceiverAddress;
        public System.Windows.Forms.TextBox txtReceiverPhone;
        public System.Windows.Forms.TextBox txtReceiverMobile;
        public System.Windows.Forms.TextBox txtReceiverLastName;
        public System.Windows.Forms.TextBox txtReceiverMiddleName;
        public System.Windows.Forms.TextBox txtReceiverFirstName;
        public System.Windows.Forms.TextBox txtSenderAddress;
        public System.Windows.Forms.TextBox txtSenderPhone;
        public System.Windows.Forms.TextBox txtSenderMobile;
        public System.Windows.Forms.TextBox txtSenderLastName;
        public System.Windows.Forms.TextBox txtSenderMiddleName;
        public System.Windows.Forms.TextBox txtSenderFirstName;
        public System.Windows.Forms.TextBox txtWeight;
        public System.Windows.Forms.ComboBox cmbServiceType;
        public System.Windows.Forms.ComboBox cmbWeightUnit;
        public System.Windows.Forms.TextBox txtNumberOfPackage;
    }
}