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
            this.components = new System.ComponentModel.Container();
            this.txtCourierNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.txtReceiverPhone = new System.Windows.Forms.TextBox();
            this.txtReceiverMobile = new System.Windows.Forms.TextBox();
            this.txtReceiverLastName = new System.Windows.Forms.TextBox();
            this.txtReceiverMiddleName = new System.Windows.Forms.TextBox();
            this.txtReceiverFirstName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.txtSenderPhone = new System.Windows.Forms.TextBox();
            this.txtSenderMobile = new System.Windows.Forms.TextBox();
            this.txtSenderLastName = new System.Windows.Forms.TextBox();
            this.txtSenderMiddleName = new System.Windows.Forms.TextBox();
            this.txtSenderFirstName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCourierCharge = new System.Windows.Forms.Label();
            this.txtCourierCharge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfPackage = new System.Windows.Forms.TextBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.cmbWeightUnit = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblGeneralCourierId = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbDocument = new System.Windows.Forms.RadioButton();
            this.rbGoods = new System.Windows.Forms.RadioButton();
            this.rchtxtPackageDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCourierNumber
            // 
            this.txtCourierNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourierNumber.Location = new System.Drawing.Point(15, 24);
            this.txtCourierNumber.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtCourierNumber.Multiline = true;
            this.txtCourierNumber.Name = "txtCourierNumber";
            this.txtCourierNumber.ReadOnly = true;
            this.txtCourierNumber.Size = new System.Drawing.Size(200, 28);
            this.txtCourierNumber.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCourierNumber);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courier Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblPhoneNumber);
            this.groupBox2.Controls.Add(this.lblMobileNumber);
            this.groupBox2.Controls.Add(this.lblLastName);
            this.groupBox2.Controls.Add(this.lblMiddleName);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Controls.Add(this.txtReceiverAddress);
            this.groupBox2.Controls.Add(this.txtReceiverPhone);
            this.groupBox2.Controls.Add(this.txtReceiverMobile);
            this.groupBox2.Controls.Add(this.txtReceiverLastName);
            this.groupBox2.Controls.Add(this.txtReceiverMiddleName);
            this.groupBox2.Controls.Add(this.txtReceiverFirstName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(9, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiver";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.Location = new System.Drawing.Point(451, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 17);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address*";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(236, 85);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(159, 17);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone Number(optional)";
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMobileNumber.Location = new System.Drawing.Point(18, 85);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(109, 17);
            this.lblMobileNumber.TabIndex = 11;
            this.lblMobileNumber.Text = "Mobile Number*";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(450, 30);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 17);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name*";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(236, 30);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(147, 17);
            this.lblMiddleName.TabIndex = 9;
            this.lblMiddleName.Text = "Middle Name(optional)";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(18, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name*";
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverAddress.Location = new System.Drawing.Point(453, 105);
            this.txtReceiverAddress.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverAddress.Multiline = true;
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverAddress.TabIndex = 7;
            this.txtReceiverAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverAddress_Validating);
            // 
            // txtReceiverPhone
            // 
            this.txtReceiverPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverPhone.Location = new System.Drawing.Point(236, 105);
            this.txtReceiverPhone.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverPhone.Multiline = true;
            this.txtReceiverPhone.Name = "txtReceiverPhone";
            this.txtReceiverPhone.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverPhone.TabIndex = 6;
            this.txtReceiverPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverPhone_Validating);
            // 
            // txtReceiverMobile
            // 
            this.txtReceiverMobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverMobile.Location = new System.Drawing.Point(18, 105);
            this.txtReceiverMobile.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverMobile.Multiline = true;
            this.txtReceiverMobile.Name = "txtReceiverMobile";
            this.txtReceiverMobile.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverMobile.TabIndex = 5;
            this.txtReceiverMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverMobile_Validating);
            // 
            // txtReceiverLastName
            // 
            this.txtReceiverLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverLastName.Location = new System.Drawing.Point(453, 50);
            this.txtReceiverLastName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverLastName.Multiline = true;
            this.txtReceiverLastName.Name = "txtReceiverLastName";
            this.txtReceiverLastName.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverLastName.TabIndex = 4;
            this.txtReceiverLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverLastName_Validating);
            // 
            // txtReceiverMiddleName
            // 
            this.txtReceiverMiddleName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverMiddleName.Location = new System.Drawing.Point(237, 50);
            this.txtReceiverMiddleName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverMiddleName.Multiline = true;
            this.txtReceiverMiddleName.Name = "txtReceiverMiddleName";
            this.txtReceiverMiddleName.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverMiddleName.TabIndex = 3;
            this.txtReceiverMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverMiddleName_Validating);
            // 
            // txtReceiverFirstName
            // 
            this.txtReceiverFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverFirstName.Location = new System.Drawing.Point(18, 50);
            this.txtReceiverFirstName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtReceiverFirstName.Multiline = true;
            this.txtReceiverFirstName.Name = "txtReceiverFirstName";
            this.txtReceiverFirstName.Size = new System.Drawing.Size(200, 28);
            this.txtReceiverFirstName.TabIndex = 2;
            this.txtReceiverFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverFirstName_Validating);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtSenderAddress);
            this.groupBox4.Controls.Add(this.txtSenderPhone);
            this.groupBox4.Controls.Add(this.txtSenderMobile);
            this.groupBox4.Controls.Add(this.txtSenderLastName);
            this.groupBox4.Controls.Add(this.txtSenderMiddleName);
            this.groupBox4.Controls.Add(this.txtSenderFirstName);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(689, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 163);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(449, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Address*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(233, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Phone Number(optional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mobile Number*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(449, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Last Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(233, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Middle Name(optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name*";
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderAddress.Location = new System.Drawing.Point(452, 105);
            this.txtSenderAddress.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderAddress.Multiline = true;
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(200, 28);
            this.txtSenderAddress.TabIndex = 17;
            this.txtSenderAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderAddress_Validating);
            // 
            // txtSenderPhone
            // 
            this.txtSenderPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderPhone.Location = new System.Drawing.Point(236, 105);
            this.txtSenderPhone.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderPhone.Multiline = true;
            this.txtSenderPhone.Name = "txtSenderPhone";
            this.txtSenderPhone.Size = new System.Drawing.Size(200, 28);
            this.txtSenderPhone.TabIndex = 16;
            this.txtSenderPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderPhone_Validating);
            // 
            // txtSenderMobile
            // 
            this.txtSenderMobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderMobile.Location = new System.Drawing.Point(18, 105);
            this.txtSenderMobile.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderMobile.Multiline = true;
            this.txtSenderMobile.Name = "txtSenderMobile";
            this.txtSenderMobile.Size = new System.Drawing.Size(200, 28);
            this.txtSenderMobile.TabIndex = 15;
            this.txtSenderMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderMobile_Validating);
            // 
            // txtSenderLastName
            // 
            this.txtSenderLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderLastName.Location = new System.Drawing.Point(452, 50);
            this.txtSenderLastName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderLastName.Multiline = true;
            this.txtSenderLastName.Name = "txtSenderLastName";
            this.txtSenderLastName.Size = new System.Drawing.Size(200, 28);
            this.txtSenderLastName.TabIndex = 14;
            this.txtSenderLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderLastName_Validating);
            // 
            // txtSenderMiddleName
            // 
            this.txtSenderMiddleName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderMiddleName.Location = new System.Drawing.Point(236, 50);
            this.txtSenderMiddleName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderMiddleName.Multiline = true;
            this.txtSenderMiddleName.Name = "txtSenderMiddleName";
            this.txtSenderMiddleName.Size = new System.Drawing.Size(200, 28);
            this.txtSenderMiddleName.TabIndex = 13;
            this.txtSenderMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderMiddleName_Validating);
            // 
            // txtSenderFirstName
            // 
            this.txtSenderFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderFirstName.Location = new System.Drawing.Point(18, 50);
            this.txtSenderFirstName.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtSenderFirstName.Multiline = true;
            this.txtSenderFirstName.Name = "txtSenderFirstName";
            this.txtSenderFirstName.Size = new System.Drawing.Size(200, 28);
            this.txtSenderFirstName.TabIndex = 12;
            this.txtSenderFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderFirstName_Validating);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCourierCharge);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtCourierCharge);
            this.groupBox5.Controls.Add(this.cmbServiceType);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.rchtxtPackageDescription);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtNumberOfPackage);
            this.groupBox5.Controls.Add(this.cmbWeightUnit);
            this.groupBox5.Controls.Add(this.txtWeight);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(9, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(674, 272);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Package Details";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lblCourierCharge
            // 
            this.lblCourierCharge.AutoSize = true;
            this.lblCourierCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourierCharge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCourierCharge.Location = new System.Drawing.Point(18, 205);
            this.lblCourierCharge.Name = "lblCourierCharge";
            this.lblCourierCharge.Size = new System.Drawing.Size(140, 17);
            this.lblCourierCharge.TabIndex = 19;
            this.lblCourierCharge.Text = "Courier Charge(NRs.)*";
            // 
            // txtCourierCharge
            // 
            this.txtCourierCharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourierCharge.Location = new System.Drawing.Point(21, 225);
            this.txtCourierCharge.MinimumSize = new System.Drawing.Size(50, 28);
            this.txtCourierCharge.Multiline = true;
            this.txtCourierCharge.Name = "txtCourierCharge";
            this.txtCourierCharge.Size = new System.Drawing.Size(200, 28);
            this.txtCourierCharge.TabIndex = 18;
            this.txtCourierCharge.Validating += new System.ComponentModel.CancelEventHandler(this.txtCourierCharge_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(552, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Service Type*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(459, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Weight Unit*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(353, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Weight*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number Of Package*";
            // 
            // txtNumberOfPackage
            // 
            this.txtNumberOfPackage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPackage.Location = new System.Drawing.Point(214, 45);
            this.txtNumberOfPackage.MinimumSize = new System.Drawing.Size(50, 28);
            this.txtNumberOfPackage.Multiline = true;
            this.txtNumberOfPackage.Name = "txtNumberOfPackage";
            this.txtNumberOfPackage.Size = new System.Drawing.Size(133, 28);
            this.txtNumberOfPackage.TabIndex = 8;
            this.txtNumberOfPackage.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberOfPackage_Validating);
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Location = new System.Drawing.Point(555, 47);
            this.cmbServiceType.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(98, 24);
            this.cmbServiceType.TabIndex = 11;
            this.cmbServiceType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbServiceType_Validating);
            // 
            // cmbWeightUnit
            // 
            this.cmbWeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeightUnit.FormattingEnabled = true;
            this.cmbWeightUnit.Location = new System.Drawing.Point(462, 47);
            this.cmbWeightUnit.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbWeightUnit.Name = "cmbWeightUnit";
            this.cmbWeightUnit.Size = new System.Drawing.Size(84, 24);
            this.cmbWeightUnit.TabIndex = 10;
            this.cmbWeightUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cmbWeightUnit_Validating);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(356, 45);
            this.txtWeight.MinimumSize = new System.Drawing.Size(50, 28);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(83, 28);
            this.txtWeight.TabIndex = 9;
            this.txtWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeight_Validating);
            // 
            // lblGeneralCourierId
            // 
            this.lblGeneralCourierId.AutoSize = true;
            this.lblGeneralCourierId.Location = new System.Drawing.Point(321, 654);
            this.lblGeneralCourierId.Name = "lblGeneralCourierId";
            this.lblGeneralCourierId.Size = new System.Drawing.Size(0, 13);
            this.lblGeneralCourierId.TabIndex = 20;
            this.lblGeneralCourierId.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::CourierBackOfficeManagement.Properties.Resources.button_cancel4;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(157, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CourierBackOfficeManagement.Properties.Resources.save5;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(47, 593);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbDocument);
            this.groupBox6.Controls.Add(this.rbGoods);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(18, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 49);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Package Type*";
            // 
            // rbDocument
            // 
            this.rbDocument.AutoSize = true;
            this.rbDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocument.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDocument.Location = new System.Drawing.Point(90, 23);
            this.rbDocument.Name = "rbDocument";
            this.rbDocument.Size = new System.Drawing.Size(85, 21);
            this.rbDocument.TabIndex = 17;
            this.rbDocument.Text = "Document";
            this.rbDocument.UseVisualStyleBackColor = true;
            // 
            // rbGoods
            // 
            this.rbGoods.AutoSize = true;
            this.rbGoods.Checked = true;
            this.rbGoods.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGoods.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbGoods.Location = new System.Drawing.Point(19, 23);
            this.rbGoods.Name = "rbGoods";
            this.rbGoods.Size = new System.Drawing.Size(65, 21);
            this.rbGoods.TabIndex = 16;
            this.rbGoods.TabStop = true;
            this.rbGoods.Text = "Goods";
            this.rbGoods.UseVisualStyleBackColor = true;
            // 
            // rchtxtPackageDescription
            // 
            this.rchtxtPackageDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtPackageDescription.Location = new System.Drawing.Point(15, 114);
            this.rchtxtPackageDescription.Name = "rchtxtPackageDescription";
            this.rchtxtPackageDescription.Size = new System.Drawing.Size(638, 74);
            this.rchtxtPackageDescription.TabIndex = 19;
            this.rchtxtPackageDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(18, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Package Description*";
            // 
            // frmGeneralCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lblGeneralCourierId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmGeneralCourier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Courier Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label lblGeneralCourierId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.TextBox txtReceiverPhone;
        private System.Windows.Forms.TextBox txtReceiverMobile;
        private System.Windows.Forms.TextBox txtReceiverLastName;
        private System.Windows.Forms.TextBox txtReceiverMiddleName;
        private System.Windows.Forms.TextBox txtReceiverFirstName;
        private System.Windows.Forms.TextBox txtSenderAddress;
        private System.Windows.Forms.TextBox txtSenderPhone;
        private System.Windows.Forms.TextBox txtSenderMobile;
        private System.Windows.Forms.TextBox txtSenderLastName;
        private System.Windows.Forms.TextBox txtSenderMiddleName;
        private System.Windows.Forms.TextBox txtSenderFirstName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.ComboBox cmbWeightUnit;
        private System.Windows.Forms.TextBox txtNumberOfPackage;
        public System.Windows.Forms.TextBox txtCourierNumber;
        private System.Windows.Forms.Label lblCourierCharge;
        private System.Windows.Forms.TextBox txtCourierCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchtxtPackageDescription;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbDocument;
        private System.Windows.Forms.RadioButton rbGoods;
    }
}