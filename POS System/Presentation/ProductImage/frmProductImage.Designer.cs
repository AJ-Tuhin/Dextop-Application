namespace BDJBatch18.POS.Presentation
{
    partial class frmProductImage
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
            this.dgvProductImage = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Margin = new System.Windows.Forms.Padding(1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(148, 11);
            this.btnSearch.Size = new System.Drawing.Size(64, 33);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(506, 13);
            this.btnNew.Size = new System.Drawing.Size(64, 31);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(574, 13);
            this.btnEdit.Size = new System.Drawing.Size(64, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(642, 13);
            this.btnDelete.Size = new System.Drawing.Size(64, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(710, 13);
            this.btnPrint.Size = new System.Drawing.Size(64, 31);
            this.btnPrint.TabIndex = 5;
            // 
            // dgvProductImage
            // 
            this.dgvProductImage.AllowUserToAddRows = false;
            this.dgvProductImage.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dgvProductImage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductImage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductImage.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colProduct,
            this.colTitle,
            this.colImage});
            this.dgvProductImage.Location = new System.Drawing.Point(5, 64);
            this.dgvProductImage.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductImage.Name = "dgvProductImage";
            this.dgvProductImage.ReadOnly = true;
            this.dgvProductImage.RowTemplate.Height = 150;
            this.dgvProductImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductImage.Size = new System.Drawing.Size(765, 412);
            this.dgvProductImage.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "product";
            this.colProduct.FillWeight = 35.7868F;
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "title";
            this.colTitle.FillWeight = 35.7868F;
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colImage
            // 
            this.colImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colImage.DataPropertyName = "image";
            this.colImage.FillWeight = 150F;
            this.colImage.HeaderText = "Image";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colImage.Width = 150;
            // 
            // frmProductImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 487);
            this.Controls.Add(this.dgvProductImage);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmProductImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Image";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvProductImage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.MyGrid dgvProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
    }
}
