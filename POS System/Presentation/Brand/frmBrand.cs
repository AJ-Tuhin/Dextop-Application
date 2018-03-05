using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace BDJBatch18.POS.Presentation
{
    public partial class frmBrand : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        Brand brand = new Brand();
        public frmBrand()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            brand.Search = txtSearch.Text;
            dgvBrand.DataSource = brand.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmBrandNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBrand.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show(@"Are you Sure", @"Confirmation", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;
            brand.Id = Convert.ToInt32(dgvBrand.SelectedRows[0].Cells["colId"].Value);

            if (brand.Delete())
            {
                MessageBox.Show(@"Brand Deleted");
                btnSearch.PerformClick();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBrand.SelectedRows.Count <= 0)
                return;
            new frmBrandEdit(Convert.ToInt32(dgvBrand.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
