namespace CourierBackOfficeManagement
{
    partial class frmContract
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbByLand = new System.Windows.Forms.RadioButton();
            this.rbOnAir = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPerGm = new System.Windows.Forms.RadioButton();
            this.rbPerKg = new System.Windows.Forms.RadioButton();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.rchtxtContractDescription = new System.Windows.Forms.RichTextBox();
            this.txtContractDate = new System.Windows.Forms.TextBox();
            this.txtContractExpireDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select City--",
            "Kathmandu"});
            this.comboBox1.Location = new System.Drawing.Point(16, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(326, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbByLand);
            this.groupBox3.Controls.Add(this.rbOnAir);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Type:";
            // 
            // rbByLand
            // 
            this.rbByLand.AutoSize = true;
            this.rbByLand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByLand.Location = new System.Drawing.Point(153, 24);
            this.rbByLand.Name = "rbByLand";
            this.rbByLand.Size = new System.Drawing.Size(71, 21);
            this.rbByLand.TabIndex = 3;
            this.rbByLand.Text = "By Land";
            this.rbByLand.UseVisualStyleBackColor = true;
            // 
            // rbOnAir
            // 
            this.rbOnAir.AutoSize = true;
            this.rbOnAir.Checked = true;
            this.rbOnAir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnAir.Location = new System.Drawing.Point(16, 24);
            this.rbOnAir.Name = "rbOnAir";
            this.rbOnAir.Size = new System.Drawing.Size(63, 21);
            this.rbOnAir.TabIndex = 2;
            this.rbOnAir.TabStop = true;
            this.rbOnAir.Text = "On Air";
            this.rbOnAir.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbPerGm);
            this.groupBox4.Controls.Add(this.rbPerKg);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(326, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 65);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Weight Unit Type:";
            // 
            // rbPerGm
            // 
            this.rbPerGm.AutoSize = true;
            this.rbPerGm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerGm.Location = new System.Drawing.Point(153, 24);
            this.rbPerGm.Name = "rbPerGm";
            this.rbPerGm.Size = new System.Drawing.Size(69, 21);
            this.rbPerGm.TabIndex = 5;
            this.rbPerGm.Text = "Per Gm";
            this.rbPerGm.UseVisualStyleBackColor = true;
            // 
            // rbPerKg
            // 
            this.rbPerKg.AutoSize = true;
            this.rbPerKg.Checked = true;
            this.rbPerKg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerKg.Location = new System.Drawing.Point(16, 24);
            this.rbPerKg.Name = "rbPerKg";
            this.rbPerKg.Size = new System.Drawing.Size(65, 21);
            this.rbPerKg.TabIndex = 4;
            this.rbPerKg.TabStop = true;
            this.rbPerKg.Text = "Per Kg";
            this.rbPerKg.UseVisualStyleBackColor = true;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(28, 197);
            this.txtCharge.Multiline = true;
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(200, 28);
            this.txtCharge.TabIndex = 6;
            this.txtCharge.TextChanged += new System.EventHandler(this.txtCharge_TextChanged);
            this.txtCharge.Enter += new System.EventHandler(this.txtCharge_Enter);
            this.txtCharge.Leave += new System.EventHandler(this.txtCharge_Leave);
            // 
            // rchtxtContractDescription
            // 
            this.rchtxtContractDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtContractDescription.Location = new System.Drawing.Point(28, 244);
            this.rchtxtContractDescription.Name = "rchtxtContractDescription";
            this.rchtxtContractDescription.Size = new System.Drawing.Size(514, 110);
            this.rchtxtContractDescription.TabIndex = 7;
            this.rchtxtContractDescription.Text = "";
            this.rchtxtContractDescription.Enter += new System.EventHandler(this.rchtxtContractDescription_Enter);
            this.rchtxtContractDescription.Leave += new System.EventHandler(this.rchtxtContractDescription_Leave);
            // 
            // txtContractDate
            // 
            this.txtContractDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractDate.Location = new System.Drawing.Point(28, 377);
            this.txtContractDate.Multiline = true;
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.Size = new System.Drawing.Size(200, 28);
            this.txtContractDate.TabIndex = 8;
            this.txtContractDate.TextChanged += new System.EventHandler(this.txtContractDate_TextChanged);
            this.txtContractDate.Enter += new System.EventHandler(this.txtContractDate_Enter);
            this.txtContractDate.Leave += new System.EventHandler(this.txtContractDate_Leave);
            // 
            // txtContractExpireDate
            // 
            this.txtContractExpireDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractExpireDate.Location = new System.Drawing.Point(342, 377);
            this.txtContractExpireDate.Multiline = true;
            this.txtContractExpireDate.Name = "txtContractExpireDate";
            this.txtContractExpireDate.Size = new System.Drawing.Size(200, 28);
            this.txtContractExpireDate.TabIndex = 9;
            this.txtContractExpireDate.TextChanged += new System.EventHandler(this.txtContractExpireDate_TextChanged);
            this.txtContractExpireDate.Enter += new System.EventHandler(this.txtContractExpireDate_Enter);
            this.txtContractExpireDate.Leave += new System.EventHandler(this.txtContractExpireDate_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(28, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(132, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 471);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContractExpireDate);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.rchtxtContractDescription);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.frmContract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbByLand;
        private System.Windows.Forms.RadioButton rbOnAir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbPerGm;
        private System.Windows.Forms.RadioButton rbPerKg;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.RichTextBox rchtxtContractDescription;
        private System.Windows.Forms.TextBox txtContractDate;
        private System.Windows.Forms.TextBox txtContractExpireDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}