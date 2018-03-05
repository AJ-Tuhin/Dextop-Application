namespace BDJBatch18.POS.Presentation
{
    partial class frmUnit
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
            this.dgvUnit = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimaryQuentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 19);
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(204, 13);
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(468, 10);
            this.btnNew.Size = new System.Drawing.Size(74, 30);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(546, 10);
            this.btnEdit.Size = new System.Drawing.Size(74, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(624, 10);
            this.btnDelete.Size = new System.Drawing.Size(74, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(702, 10);
            this.btnPrint.Size = new System.Drawing.Size(74, 30);
            this.btnPrint.TabIndex = 5;
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dgvUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnit.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colDescription,
            this.colPrimaryQuentity});
            this.dgvUnit.Location = new System.Drawing.Point(11, 59);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.RowTemplate.Height = 28;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(762, 416);
            this.dgvUnit.TabIndex = 6;
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
            // colDescription
            // 
            this.colDescription.DataPropertyName = "description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colPrimaryQuentity
            // 
            this.colPrimaryQuentity.DataPropertyName = "primaryQty";
            this.colPrimaryQuentity.HeaderText = "Primary Quentity";
            this.colPrimaryQuentity.Name = "colPrimaryQuentity";
            this.colPrimaryQuentity.ReadOnly = true;
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 487);
            this.Controls.Add(this.dgvUnit);
            this.Name = "frmUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvUnit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.MyGrid dgvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimaryQuentity;
    }
}
