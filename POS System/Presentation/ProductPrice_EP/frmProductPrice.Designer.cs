namespace BDJBatch18.POS.Presentation
{
    partial class frmProductPrice
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
            this.dgvProductPrice = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(147, 20);
            this.txtSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(507, 14);
            this.btnSearch.Size = new System.Drawing.Size(58, 28);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(584, 14);
            this.btnNew.Size = new System.Drawing.Size(58, 28);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(646, 14);
            this.btnEdit.Size = new System.Drawing.Size(58, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(708, 14);
            this.btnDelete.Size = new System.Drawing.Size(58, 28);
            this.btnDelete.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(770, 14);
            this.btnPrint.Size = new System.Drawing.Size(58, 28);
            this.btnPrint.TabIndex = 5;
            // 
            // dgvProductPrice
            // 
            this.dgvProductPrice.AllowUserToAddRows = false;
            this.dgvProductPrice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dgvProductPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductPrice.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colUnit,
            this.colPrice});
            this.dgvProductPrice.Location = new System.Drawing.Point(9, 73);
            this.dgvProductPrice.Name = "dgvProductPrice";
            this.dgvProductPrice.ReadOnly = true;
            this.dgvProductPrice.RowTemplate.Height = 28;
            this.dgvProductPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductPrice.Size = new System.Drawing.Size(823, 402);
            this.dgvProductPrice.TabIndex = 6;
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(9, 19);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(149, 21);
            this.cmbProduct.TabIndex = 7;
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(164, 19);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(139, 21);
            this.cmbUnit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Unit";
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "product";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "unit";
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // frmProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.dgvProductPrice);
            this.Name = "frmProductPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Price";
            this.Load += new System.EventHandler(this.frmProductPrice_Load);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvProductPrice, 0);
            this.Controls.SetChildIndex(this.cmbProduct, 0);
            this.Controls.SetChildIndex(this.cmbUnit, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.MyGrid dgvProductPrice;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}
