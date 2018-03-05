namespace BDJBatch18.POS.Presentation
{
    partial class frmLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLedger = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(161, 20);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(174, 13);
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(462, 13);
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(541, 13);
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(620, 13);
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(699, 13);
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 5;
            // 
            // dgvLedger
            // 
            this.dgvLedger.AllowUserToAddRows = false;
            this.dgvLedger.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            this.dgvLedger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colContact,
            this.colEmail,
            this.colPassword,
            this.colGender,
            this.colDateOfBirth,
            this.colAddress,
            this.colCity,
            this.colCreateDate,
            this.colImage,
            this.colType});
            this.dgvLedger.Location = new System.Drawing.Point(9, 60);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.ReadOnly = true;
            this.dgvLedger.RowTemplate.Height = 80;
            this.dgvLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedger.Size = new System.Drawing.Size(764, 415);
            this.dgvLedger.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "contact";
            this.colContact.HeaderText = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "password";
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Visible = false;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.DataPropertyName = "dateOfBirth";
            this.colDateOfBirth.HeaderText = "DOB";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "city";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DataPropertyName = "createDate";
            this.colCreateDate.HeaderText = "Create Date";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "image";
            this.colImage.HeaderText = "Image";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // frmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 487);
            this.Controls.Add(this.dgvLedger);
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvLedger, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.MyGrid dgvLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    }
}
