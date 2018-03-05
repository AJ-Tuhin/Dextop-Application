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
    public partial class frmProductPriceNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmProductPriceNew()
        {
            InitializeComponent();
        }

        private void frmProductPriceNew_Load(object sender, EventArgs e)
        {
            Unit unit = new Unit();
            cmbUnit.DataSource = unit.Select().Tables[0];
            cmbUnit.DisplayMember = "name";
            cmbUnit.ValueMember = "id";
            cmbUnit.SelectedValue = -1;

            Product product = new Product();
            cmbProduct.DataSource = product.Select().Tables[0];
            cmbProduct.DisplayMember = "name";
            cmbProduct.ValueMember = "id";
            cmbProduct.SelectedValue = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();
            
            if (cmbProduct.SelectedValue == null || cmbProduct.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbProduct, "Product Required");
            }

            if (cmbUnit.SelectedValue == null || cmbUnit.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbUnit, "Unit Required");
            }

            if (txtPrice.Text == "")
            {
                er++;
                ep.SetError(txtPrice, "Price Required");
            }

            if (er > 0)
                return;

            ProductPrice productPrice = new ProductPrice();
            productPrice.ProductId = Convert.ToInt32(cmbProduct.SelectedValue);
            productPrice.UnitId = Convert.ToInt32(cmbUnit.SelectedValue);
            productPrice.Price = Convert.ToDouble(txtPrice.Text);

            if (productPrice.Insert())
            {
                MessageBox.Show(@"Product Price Saved");
                cmbProduct.SelectedValue = -1;
                cmbUnit.SelectedValue = -1;
                txtPrice.Text = "";
                txtPrice.Focus();
            }
            else
                MessageBox.Show(productPrice.Error);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }
}
