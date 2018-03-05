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
    public partial class frmProduct : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        Product product = new Product();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmProductNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            product.Search = txtSearch.Text;
            product.BrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            dgvProduct.DataSource = product.Select().Tables[0];
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            cmbBrand.DataSource = brand.Select().Tables[0];
            cmbBrand.DisplayMember = "name";
            cmbBrand.ValueMember = "id";
            cmbBrand.SelectedValue = -1;

            Category category = new Category();
            cmbCategory.DataSource = category.Select().Tables[0];
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
            cmbCategory.SelectedValue = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count <= 0)
                return;
            new frmProductEdit(Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show(@"Confirmation", @"Are you sure", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;
            product.Id = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["colId"].Value);

            if (product.Delete())
            {
                MessageBox.Show(@"Product Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(product.Error);
            }
        }
    }
}
