using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDJBatch18.POS.Presentation
{
    public partial class frmProductImage : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        DAL.ProductImage pi = new DAL.ProductImage();
        public frmProductImage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProductImage.DataSource = pi.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmProductImageNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProductImage.SelectedRows.Count <=0 )
                return;

            new frmProductImageEdit(Convert.ToInt32(dgvProductImage.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductImage.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show(@"Confirmation", @"Are you sure", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;
            pi.Id = Convert.ToInt32(dgvProductImage.SelectedRows[0].Cells["colId"].Value);

            if (pi.Delete())
            {
                MessageBox.Show(@"Product Image Deleted");
                btnSearch.PerformClick();

            }
            else
            {
                MessageBox.Show(pi.Error);
            }

        }
    }
}
