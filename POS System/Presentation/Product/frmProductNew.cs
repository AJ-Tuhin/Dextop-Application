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
    public partial class frmProductNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmProductNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();

            if (txtName.Text == "")
            {
                er++;
                ep.SetError(txtName, "Name Required");
            }

            if (txtCode.Text == "")
            {
                er++;
                ep.SetError(txtName, "Code Required");
            }

            if (txtDescription.Text == "")
            {
                er++;
                ep.SetError(txtName, "Description Required");
            }

            if (cmbBrand.SelectedValue == null || cmbBrand.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbBrand, "Brand Required");
            }

            if (cmbCategory.SelectedValue == null || cmbCategory.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbCategory, "Category Required");
            }

            if (er > 0)
                return;

            Product product = new Product();
            product.Name = txtName.Text;
            product.Code = txtCode.Text;
            product.Description = txtDescription.Text;
            product.BrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            if (product.Insert())
            {
                MessageBox.Show(@"Product Saved");
                txtName.Text = "";
                txtCode.Text = "";
                txtDescription.Text = "";
                cmbBrand.SelectedValue = -1;
                cmbCategory.SelectedValue = -1;
                txtName.Focus();
            }
            else
                MessageBox.Show(product.Error);
        }

        private void frmProductNew_Load(object sender, EventArgs e)
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
    }
}
