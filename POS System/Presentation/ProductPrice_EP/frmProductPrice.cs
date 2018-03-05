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
    public partial class frmProductPrice : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        public frmProductPrice()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmProductPriceNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProductPrice productPrice = new ProductPrice();
            //productPrice.Search = txtSearch.Text;
            productPrice.ProductId = Convert.ToInt32(cmbProduct.SelectedValue);
            productPrice.UnitId = Convert.ToInt32(cmbUnit.SelectedValue);
            dgvProductPrice.DataSource = productPrice.Select().Tables[0];
        }

        private void frmProductPrice_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            cmbProduct.DataSource = product.Select().Tables[0];
            cmbProduct.DisplayMember = "name";
            cmbProduct.ValueMember = "id";
            cmbProduct.SelectedValue = -1;

            Unit unit = new Unit();
            cmbUnit.DataSource = unit.Select().Tables[0];
            cmbUnit.DisplayMember = "name";
            cmbUnit.ValueMember = "id";
            cmbUnit.SelectedValue = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProductPrice.SelectedRows.Count <= 0)
                return;

            int productId = Convert.ToInt32(dgvProductPrice.SelectedRows[0].Cells["colProduct"].Value);
            //int unitId = Convert.ToInt32(dgvProductPrice.SelectedRows[0].Cells["colUnit"].Value);
            //new frmProductPriceEdit(unitId).ShowDialog();
            new frmProductPriceEdit(productId).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
