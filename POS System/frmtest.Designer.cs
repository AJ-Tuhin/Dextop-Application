namespace BDJBatch18.POS
{
    partial class frmtest
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
            this.myGrid1 = new BDJBatch18.POS.Presentation.MyControls.MyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGrid1
            // 
            this.myGrid1.AllowUserToAddRows = false;
            this.myGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.myGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.myGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myGrid1.BackgroundColor = System.Drawing.Color.White;
            this.myGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid1.Location = new System.Drawing.Point(3, 12);
            this.myGrid1.Name = "myGrid1";
            this.myGrid1.ReadOnly = true;
            this.myGrid1.RowTemplate.Height = 28;
            this.myGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myGrid1.Size = new System.Drawing.Size(527, 265);
            this.myGrid1.TabIndex = 3;
            // 
            // frmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 377);
            this.Controls.Add(this.myGrid1);
            this.Name = "frmtest";
            this.Text = "frmtest";
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Presentation.MyControls.MyGrid myGrid1;
    }
}