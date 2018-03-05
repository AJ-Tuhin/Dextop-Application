namespace BDJBatch18.POS.Presentation
{
    partial class frmPurchaseNew
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbLedger = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dgvPurchaseNew = new System.Windows.Forms.DataGridView();
            this.colproduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseNew)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 445);
            this.btnSave.Size = new System.Drawing.Size(141, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(328, 445);
            this.btnExit.Size = new System.Drawing.Size(104, 24);
            this.btnExit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ledger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Discount";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 22);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(189, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(236, 22);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(189, 20);
            this.dtpDateTime.TabIndex = 1;
            // 
            // cmbLedger
            // 
            this.cmbLedger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLedger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLedger.FormattingEnabled = true;
            this.cmbLedger.Location = new System.Drawing.Point(12, 61);
            this.cmbLedger.Name = "cmbLedger";
            this.cmbLedger.Size = new System.Drawing.Size(189, 21);
            this.cmbLedger.TabIndex = 2;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(236, 61);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(189, 21);
            this.cmbEmployee.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(236, 297);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(189, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // txtVat
            // 
            this.txtVat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BDJBatch18.POS.Properties.Settings.Default, "VAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVat.Location = new System.Drawing.Point(236, 335);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(189, 20);
            this.txtVat.TabIndex = 5;
            this.txtVat.Text = global::BDJBatch18.POS.Properties.Settings.Default.VAT;
            // 
            // txtDiscount
            // 
            this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BDJBatch18.POS.Properties.Settings.Default, "Discount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDiscount.Location = new System.Drawing.Point(236, 374);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(189, 20);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.Text = global::BDJBatch18.POS.Properties.Settings.Default.Discount;
            // 
            // dgvPurchaseNew
            // 
            this.dgvPurchaseNew.AllowUserToDeleteRows = false;
            this.dgvPurchaseNew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseNew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colproduct,
            this.colQty,
            this.colRate,
            this.colSubTotal});
            this.dgvPurchaseNew.Location = new System.Drawing.Point(12, 94);
            this.dgvPurchaseNew.Name = "dgvPurchaseNew";
            this.dgvPurchaseNew.Size = new System.Drawing.Size(413, 184);
            this.dgvPurchaseNew.TabIndex = 4;
            this.dgvPurchaseNew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPurchaseNew.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseNew_CellValueChanged);
            // 
            // colproduct
            // 
            this.colproduct.HeaderText = "Product";
            this.colproduct.Name = "colproduct";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            // 
            // colRate
            // 
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(236, 401);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(189, 20);
            this.txtGrandTotal.TabIndex = 10;
            // 
            // frmPurchaseNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(468, 480);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.dgvPurchaseNew);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbLedger);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPurchaseNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase New";
            this.Load += new System.EventHandler(this.frmPurchaseNew_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.dtpDateTime, 0);
            this.Controls.SetChildIndex(this.cmbLedger, 0);
            this.Controls.SetChildIndex(this.cmbEmployee, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.txtVat, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.dgvPurchaseNew, 0);
            this.Controls.SetChildIndex(this.txtGrandTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ComboBox cmbLedger;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DataGridView dgvPurchaseNew;
        private System.Windows.Forms.DataGridViewComboBoxColumn colproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
    }
}
