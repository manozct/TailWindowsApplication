namespace CourierBackOfficeManagement
{
    partial class frmGeneralPrice
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOnAir = new System.Windows.Forms.RadioButton();
            this.rbByLand = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbDocument = new System.Windows.Forms.RadioButton();
            this.rbGood = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGeneralCourierPriceID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFrom
            // 
            this.cmbFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(45, 49);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(200, 25);
            this.cmbFrom.TabIndex = 0;
            this.cmbFrom.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFrom_Validating);
            // 
            // cmbTo
            // 
            this.cmbTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(330, 49);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(200, 25);
            this.cmbTo.TabIndex = 0;
            this.cmbTo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTo_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOnAir);
            this.groupBox3.Controls.Add(this.rbByLand);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 58);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Type";
            // 
            // rbOnAir
            // 
            this.rbOnAir.AutoSize = true;
            this.rbOnAir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnAir.Location = new System.Drawing.Point(120, 24);
            this.rbOnAir.Name = "rbOnAir";
            this.rbOnAir.Size = new System.Drawing.Size(63, 21);
            this.rbOnAir.TabIndex = 1;
            this.rbOnAir.TabStop = true;
            this.rbOnAir.Text = "On Air";
            this.rbOnAir.UseVisualStyleBackColor = true;
            // 
            // rbByLand
            // 
            this.rbByLand.AutoSize = true;
            this.rbByLand.Checked = true;
            this.rbByLand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByLand.Location = new System.Drawing.Point(7, 24);
            this.rbByLand.Name = "rbByLand";
            this.rbByLand.Size = new System.Drawing.Size(71, 21);
            this.rbByLand.TabIndex = 0;
            this.rbByLand.TabStop = true;
            this.rbByLand.Text = "By Land";
            this.rbByLand.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbDocument);
            this.groupBox4.Controls.Add(this.rbGood);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(330, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Package Type";
            // 
            // rbDocument
            // 
            this.rbDocument.AutoSize = true;
            this.rbDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocument.Location = new System.Drawing.Point(102, 24);
            this.rbDocument.Name = "rbDocument";
            this.rbDocument.Size = new System.Drawing.Size(85, 21);
            this.rbDocument.TabIndex = 1;
            this.rbDocument.TabStop = true;
            this.rbDocument.Text = "Document";
            this.rbDocument.UseVisualStyleBackColor = true;
            // 
            // rbGood
            // 
            this.rbGood.AutoSize = true;
            this.rbGood.Checked = true;
            this.rbGood.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGood.Location = new System.Drawing.Point(6, 24);
            this.rbGood.Name = "rbGood";
            this.rbGood.Size = new System.Drawing.Size(59, 21);
            this.rbGood.TabIndex = 0;
            this.rbGood.TabStop = true;
            this.rbGood.Text = "Good";
            this.rbGood.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(44, 186);
            this.txtPrice.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 28);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(41, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 17);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "From*";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(326, 26);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 17);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "To*";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(41, 166);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 17);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price(NRS.)*";
            // 
            // lblGeneralCourierPriceID
            // 
            this.lblGeneralCourierPriceID.AutoSize = true;
            this.lblGeneralCourierPriceID.Location = new System.Drawing.Point(333, 186);
            this.lblGeneralCourierPriceID.Name = "lblGeneralCourierPriceID";
            this.lblGeneralCourierPriceID.Size = new System.Drawing.Size(112, 13);
            this.lblGeneralCourierPriceID.TabIndex = 12;
            this.lblGeneralCourierPriceID.Text = "GeneralCourierPriceID";
            this.lblGeneralCourierPriceID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::CourierBackOfficeManagement.Properties.Resources.button_cancel7;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(149, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CourierBackOfficeManagement.Properties.Resources.save8;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(44, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGeneralPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 302);
            this.Controls.Add(this.lblGeneralCourierPriceID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frmGeneralPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Price Management";
            this.Load += new System.EventHandler(this.frmGeneralPrice_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOnAir;
        private System.Windows.Forms.RadioButton rbByLand;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbDocument;
        private System.Windows.Forms.RadioButton rbGood;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGeneralCourierPriceID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}