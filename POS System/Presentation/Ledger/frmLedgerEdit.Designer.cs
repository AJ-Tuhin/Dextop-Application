namespace BDJBatch18.POS.Presentation
{
    partial class frmLedgerEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.llBrowse = new System.Windows.Forms.LinkLabel();
            this.llClear = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 362);
            this.btnSave.Size = new System.Drawing.Size(87, 24);
            this.btnSave.TabIndex = 11;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(440, 362);
            this.btnExit.Size = new System.Drawing.Size(100, 24);
            this.btnExit.TabIndex = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(9, 66);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(254, 20);
            this.txtContact.TabIndex = 1;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(9, 190);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(254, 21);
            this.cmbGender.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(313, 66);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(227, 20);
            this.dtpDateOfBirth.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(9, 237);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 103);
            this.txtAddress.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "City";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(313, 24);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(227, 21);
            this.cmbCity.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Image";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(313, 152);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(225, 188);
            this.pbImage.TabIndex = 21;
            this.pbImage.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.cmbType.Location = new System.Drawing.Point(313, 105);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(225, 21);
            this.cmbType.TabIndex = 9;
            // 
            // llBrowse
            // 
            this.llBrowse.AutoSize = true;
            this.llBrowse.Location = new System.Drawing.Point(411, 135);
            this.llBrowse.Name = "llBrowse";
            this.llBrowse.Size = new System.Drawing.Size(42, 13);
            this.llBrowse.TabIndex = 23;
            this.llBrowse.TabStop = true;
            this.llBrowse.Text = "Borwse";
            this.llBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBrowse_LinkClicked);
            // 
            // llClear
            // 
            this.llClear.AutoSize = true;
            this.llClear.Location = new System.Drawing.Point(485, 135);
            this.llClear.Name = "llClear";
            this.llClear.Size = new System.Drawing.Size(31, 13);
            this.llClear.TabIndex = 24;
            this.llClear.TabStop = true;
            this.llClear.Text = "Clear";
            this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
            // 
            // frmLedgerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(579, 397);
            this.Controls.Add(this.llClear);
            this.Controls.Add(this.llBrowse);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmLedgerNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger New";
            this.Load += new System.EventHandler(this.frmLedgerNew_Load);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtContact, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbGender, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dtpDateOfBirth, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbCity, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cmbType, 0);
            this.Controls.SetChildIndex(this.llBrowse, 0);
            this.Controls.SetChildIndex(this.llClear, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.LinkLabel llBrowse;
        private System.Windows.Forms.LinkLabel llClear;
    }
}
