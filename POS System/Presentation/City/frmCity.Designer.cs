namespace BDJBatch18.POS.Presentation
{
    partial class frmCity
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
            this.dgvCity = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(152, 20);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(175, 13);
            this.btnSearch.Size = new System.Drawing.Size(73, 31);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(469, 13);
            this.btnNew.Size = new System.Drawing.Size(73, 31);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(546, 13);
            this.btnEdit.Size = new System.Drawing.Size(73, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(623, 13);
            this.btnDelete.Size = new System.Drawing.Size(73, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(700, 13);
            this.btnPrint.Size = new System.Drawing.Size(73, 31);
            this.btnPrint.TabIndex = 5;
            // 
            // dgvCity
            // 
            this.dgvCity.AllowUserToAddRows = false;
            this.dgvCity.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dgvCity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCity.BackgroundColor = System.Drawing.Color.White;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName});
            this.dgvCity.Location = new System.Drawing.Point(9, 63);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.ReadOnly = true;
            this.dgvCity.RowTemplate.Height = 28;
            this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCity.Size = new System.Drawing.Size(761, 412);
            this.dgvCity.TabIndex = 6;
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
            // frmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 487);
            this.Controls.Add(this.dgvCity);
            this.Name = "frmCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City";
            this.Load += new System.EventHandler(this.frmCity_Load);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvCity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.MyGrid dgvCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}
