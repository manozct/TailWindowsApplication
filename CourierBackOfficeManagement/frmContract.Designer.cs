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
            this.components = new System.ComponentModel.Container();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.rbByLand = new System.Windows.Forms.RadioButton();
            this.rbOnAir = new System.Windows.Forms.RadioButton();
            this.rbPerGm = new System.Windows.Forms.RadioButton();
            this.rbPerKg = new System.Windows.Forms.RadioButton();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.rchtxtContractDescription = new System.Windows.Forms.RichTextBox();
            this.txtContractDate = new System.Windows.Forms.TextBox();
            this.txtContractExpireDate = new System.Windows.Forms.TextBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblContractDescription = new System.Windows.Forms.Label();
            this.lblContractDate = new System.Windows.Forms.Label();
            this.lblContractExpireDate = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBoxServiceType = new System.Windows.Forms.GroupBox();
            this.groupBoxWeightUnit = new System.Windows.Forms.GroupBox();
            this.lblCorporateClient = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCorporateClientLocationId = new System.Windows.Forms.Label();
            this.lblCorporateClientID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxServiceType.SuspendLayout();
            this.groupBoxWeightUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFrom
            // 
            this.cmbFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "--Select City--",
            "Kathmandu"});
            this.cmbFrom.Location = new System.Drawing.Point(29, 42);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(200, 25);
            this.cmbFrom.TabIndex = 0;
            this.cmbFrom.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFrom_Validating);
            // 
            // cmbTo
            // 
            this.cmbTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(321, 42);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(200, 25);
            this.cmbTo.TabIndex = 1;
            this.cmbTo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTo_Validating);
            // 
            // rbByLand
            // 
            this.rbByLand.AutoSize = true;
            this.rbByLand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByLand.Location = new System.Drawing.Point(123, 19);
            this.rbByLand.Name = "rbByLand";
            this.rbByLand.Size = new System.Drawing.Size(71, 21);
            this.rbByLand.TabIndex = 4;
            this.rbByLand.Text = "By Land";
            this.rbByLand.UseVisualStyleBackColor = true;
            // 
            // rbOnAir
            // 
            this.rbOnAir.AutoSize = true;
            this.rbOnAir.Checked = true;
            this.rbOnAir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnAir.Location = new System.Drawing.Point(6, 19);
            this.rbOnAir.Name = "rbOnAir";
            this.rbOnAir.Size = new System.Drawing.Size(63, 21);
            this.rbOnAir.TabIndex = 3;
            this.rbOnAir.TabStop = true;
            this.rbOnAir.Text = "On Air";
            this.rbOnAir.UseVisualStyleBackColor = true;
            // 
            // rbPerGm
            // 
            this.rbPerGm.AutoSize = true;
            this.rbPerGm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerGm.Location = new System.Drawing.Point(125, 19);
            this.rbPerGm.Name = "rbPerGm";
            this.rbPerGm.Size = new System.Drawing.Size(69, 21);
            this.rbPerGm.TabIndex = 7;
            this.rbPerGm.Text = "Per Gm";
            this.rbPerGm.UseVisualStyleBackColor = true;
            // 
            // rbPerKg
            // 
            this.rbPerKg.AutoSize = true;
            this.rbPerKg.Checked = true;
            this.rbPerKg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerKg.Location = new System.Drawing.Point(6, 19);
            this.rbPerKg.Name = "rbPerKg";
            this.rbPerKg.Size = new System.Drawing.Size(65, 21);
            this.rbPerKg.TabIndex = 6;
            this.rbPerKg.TabStop = true;
            this.rbPerKg.Text = "Per Kg";
            this.rbPerKg.UseVisualStyleBackColor = true;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(29, 166);
            this.txtCharge.Multiline = true;
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(200, 28);
            this.txtCharge.TabIndex = 8;
            this.txtCharge.Validating += new System.ComponentModel.CancelEventHandler(this.txtCharge_Validating);
            // 
            // rchtxtContractDescription
            // 
            this.rchtxtContractDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtContractDescription.Location = new System.Drawing.Point(29, 225);
            this.rchtxtContractDescription.Name = "rchtxtContractDescription";
            this.rchtxtContractDescription.Size = new System.Drawing.Size(492, 111);
            this.rchtxtContractDescription.TabIndex = 9;
            this.rchtxtContractDescription.Text = "";
            this.rchtxtContractDescription.Validating += new System.ComponentModel.CancelEventHandler(this.rchtxtContractDescription_Validating);
            // 
            // txtContractDate
            // 
            this.txtContractDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractDate.Location = new System.Drawing.Point(29, 370);
            this.txtContractDate.Multiline = true;
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.Size = new System.Drawing.Size(200, 28);
            this.txtContractDate.TabIndex = 11;
            this.txtContractDate.Enter += new System.EventHandler(this.txtContractDate_Enter);
            this.txtContractDate.Leave += new System.EventHandler(this.txtContractDate_Leave);
            this.txtContractDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtContractDate_Validating);
            // 
            // txtContractExpireDate
            // 
            this.txtContractExpireDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractExpireDate.Location = new System.Drawing.Point(327, 370);
            this.txtContractExpireDate.Multiline = true;
            this.txtContractExpireDate.Name = "txtContractExpireDate";
            this.txtContractExpireDate.Size = new System.Drawing.Size(200, 28);
            this.txtContractExpireDate.TabIndex = 13;
            this.txtContractExpireDate.Enter += new System.EventHandler(this.txtContractExpireDate_Enter);
            this.txtContractExpireDate.Leave += new System.EventHandler(this.txtContractExpireDate_Leave);
            this.txtContractExpireDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtContractExpireDate_Validating);
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCharge.Location = new System.Drawing.Point(27, 146);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(86, 17);
            this.lblCharge.TabIndex = 21;
            this.lblCharge.Text = "Charge(NRs.)";
            // 
            // lblContractDescription
            // 
            this.lblContractDescription.AutoSize = true;
            this.lblContractDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblContractDescription.Location = new System.Drawing.Point(27, 205);
            this.lblContractDescription.Name = "lblContractDescription";
            this.lblContractDescription.Size = new System.Drawing.Size(312, 17);
            this.lblContractDescription.TabIndex = 22;
            this.lblContractDescription.Text = "Contract Description (Not more than 1500 words)*";
            // 
            // lblContractDate
            // 
            this.lblContractDate.AutoSize = true;
            this.lblContractDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblContractDate.Location = new System.Drawing.Point(26, 350);
            this.lblContractDate.Name = "lblContractDate";
            this.lblContractDate.Size = new System.Drawing.Size(182, 17);
            this.lblContractDate.TabIndex = 23;
            this.lblContractDate.Text = "Contract Date (dd/mm/yyyy)";
            // 
            // lblContractExpireDate
            // 
            this.lblContractExpireDate.AutoSize = true;
            this.lblContractExpireDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractExpireDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblContractExpireDate.Location = new System.Drawing.Point(304, 350);
            this.lblContractExpireDate.Name = "lblContractExpireDate";
            this.lblContractExpireDate.Size = new System.Drawing.Size(223, 17);
            this.lblContractExpireDate.TabIndex = 24;
            this.lblContractExpireDate.Text = "Contract Expire Date (dd/mm/yyyy)";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFrom.Location = new System.Drawing.Point(28, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 17);
            this.lblFrom.TabIndex = 25;
            this.lblFrom.Text = "From*";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTo.Location = new System.Drawing.Point(323, 22);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 17);
            this.lblTo.TabIndex = 26;
            this.lblTo.Text = "To*";
            // 
            // groupBoxServiceType
            // 
            this.groupBoxServiceType.Controls.Add(this.rbOnAir);
            this.groupBoxServiceType.Controls.Add(this.rbByLand);
            this.groupBoxServiceType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServiceType.Location = new System.Drawing.Point(29, 81);
            this.groupBoxServiceType.Name = "groupBoxServiceType";
            this.groupBoxServiceType.Size = new System.Drawing.Size(200, 49);
            this.groupBoxServiceType.TabIndex = 2;
            this.groupBoxServiceType.TabStop = false;
            this.groupBoxServiceType.Text = "Service Type";
            // 
            // groupBoxWeightUnit
            // 
            this.groupBoxWeightUnit.Controls.Add(this.rbPerGm);
            this.groupBoxWeightUnit.Controls.Add(this.rbPerKg);
            this.groupBoxWeightUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWeightUnit.Location = new System.Drawing.Point(321, 81);
            this.groupBoxWeightUnit.Name = "groupBoxWeightUnit";
            this.groupBoxWeightUnit.Size = new System.Drawing.Size(200, 49);
            this.groupBoxWeightUnit.TabIndex = 5;
            this.groupBoxWeightUnit.TabStop = false;
            this.groupBoxWeightUnit.Text = "Weight Unit Type";
            // 
            // lblCorporateClient
            // 
            this.lblCorporateClient.Location = new System.Drawing.Point(0, 0);
            this.lblCorporateClient.Name = "lblCorporateClient";
            this.lblCorporateClient.Size = new System.Drawing.Size(100, 23);
            this.lblCorporateClient.TabIndex = 36;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 179);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(300, 179);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 12;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            this.monthCalendar2.Leave += new System.EventHandler(this.monthCalendar2_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCorporateClientLocationId
            // 
            this.lblCorporateClientLocationId.AutoSize = true;
            this.lblCorporateClientLocationId.Location = new System.Drawing.Point(399, 426);
            this.lblCorporateClientLocationId.Name = "lblCorporateClientLocationId";
            this.lblCorporateClientLocationId.Size = new System.Drawing.Size(131, 13);
            this.lblCorporateClientLocationId.TabIndex = 34;
            this.lblCorporateClientLocationId.Text = "CorporateClientLocationID";
            this.lblCorporateClientLocationId.Visible = false;
            // 
            // lblCorporateClientID
            // 
            this.lblCorporateClientID.AutoSize = true;
            this.lblCorporateClientID.Location = new System.Drawing.Point(306, 428);
            this.lblCorporateClientID.Name = "lblCorporateClientID";
            this.lblCorporateClientID.Size = new System.Drawing.Size(87, 13);
            this.lblCorporateClientID.TabIndex = 35;
            this.lblCorporateClientID.Text = "CoporateClientID";
            this.lblCorporateClientID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::CourierBackOfficeManagement.Properties.Resources.button_cancel1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(153, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CourierBackOfficeManagement.Properties.Resources.save2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(31, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 473);
            this.Controls.Add(this.lblCorporateClientID);
            this.Controls.Add(this.lblCorporateClientLocationId);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblCorporateClient);
            this.Controls.Add(this.groupBoxWeightUnit);
            this.Controls.Add(this.groupBoxServiceType);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.lblContractExpireDate);
            this.Controls.Add(this.lblContractDate);
            this.Controls.Add(this.lblContractDescription);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContractExpireDate);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.rchtxtContractDescription);
            this.Controls.Add(this.txtCharge);
            this.MaximizeBox = false;
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.frmContract_Load);
            this.groupBoxServiceType.ResumeLayout(false);
            this.groupBoxServiceType.PerformLayout();
            this.groupBoxWeightUnit.ResumeLayout(false);
            this.groupBoxWeightUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.RadioButton rbByLand;
        private System.Windows.Forms.RadioButton rbOnAir;
        private System.Windows.Forms.RadioButton rbPerGm;
        private System.Windows.Forms.RadioButton rbPerKg;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.RichTextBox rchtxtContractDescription;
        private System.Windows.Forms.TextBox txtContractDate;
        private System.Windows.Forms.TextBox txtContractExpireDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblContractDescription;
        private System.Windows.Forms.Label lblContractDate;
        private System.Windows.Forms.Label lblContractExpireDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox groupBoxServiceType;
        private System.Windows.Forms.GroupBox groupBoxWeightUnit;
        private System.Windows.Forms.Label lblCorporateClient;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCorporateClientLocationId;
        private System.Windows.Forms.Label lblCorporateClientID;
    }
}