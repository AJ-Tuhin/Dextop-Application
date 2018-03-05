namespace BDJBatch18.POS.Presentation
{
    partial class frmPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPurchase = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colledger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(183, 14);
            this.btnSearch.Size = new System.Drawing.Size(68, 29);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(487, 14);
            this.btnNew.Size = new System.Drawing.Size(68, 29);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(562, 14);
            this.btnEdit.Size = new System.Drawing.Size(68, 29);
            this.btnEdit.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(634, 14);
            this.btnDelete.Size = new System.Drawing.Size(68, 29);
            this.btnDelete.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(706, 14);
            this.btnPrint.Size = new System.Drawing.Size(68, 29);
            this.btnPrint.TabIndex = 5;
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dgvPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNumber,
            this.colDateTime,
            this.colledger,
            this.colEmployee,
            this.colTotal,
            this.colVat,
            this.colDiscount});
            this.dgvPurchase.Location = new System.Drawing.Point(9, 59);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.ReadOnly = true;
            this.dgvPurchase.RowTemplate.Height = 28;
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchase.Size = new System.Drawing.Size(765, 416);
            this.dgvPurchase.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "number";
            this.colNumber.HeaderText = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "dateTime";
            this.colDateTime.HeaderText = "Date";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            // 
            // colledger
            // 
            this.colledger.DataPropertyName = "ledger";
            this.colledger.HeaderText = "Ledger";
            this.colledger.Name = "colledger";
            this.colledger.ReadOnly = true;
            // 
            // colEmployee
            // 
            this.colEmployee.DataPropertyName = "employee";
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "total";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colVat
            // 
            this.colVat.DataPropertyName = "vat";
            this.colVat.HeaderText = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 487);
            this.Controls.Add(this.dgvPurchase);
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvPurchase, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.MyGrid dgvPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colledger;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
    }
}
