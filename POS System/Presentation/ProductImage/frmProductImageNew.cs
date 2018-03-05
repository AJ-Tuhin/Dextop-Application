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
    public partial class frmProductImageNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmProductImageNew()
        {
            InitializeComponent();
        }

        private void llClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = null;
        }

        private void llBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"JPG|*.jpg|PNG|*.png|GIF|*.gif";

            ofd.ShowDialog();

            if (ofd.FileName == null || ofd.FileName.ToString() == "")
                return;
            pbImage.Image = Image.FromFile(ofd.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();

            if (cmbProduct.SelectedValue == null || cmbProduct.SelectedValue == null)
            {
                er++;
                ep.SetError(cmbProduct, "Product Required");
            }

            if (txtTitle.Text == "")
            {
                er++;
                ep.SetError(txtTitle, "Title Required");
            }

            if (pbImage.Image == null)
            {
                er++;
                ep.SetError(pbImage, "Image Required");
            }

            if (er > 0)
                return;

            ProductImage productImage = new ProductImage();
            productImage.ProductId = Convert.ToInt32(cmbProduct.SelectedValue);
            productImage.Title = txtTitle.Text;
            productImage.Image = FileImage.ImageToByte(pbImage.Image);

            if (productImage.Insert())
            {
                MessageBox.Show(@"Image Saved");
                cmbProduct.SelectedValue = -1;
                txtTitle.Text = "";
                pbImage.Image = null;
                cmbProduct.Focus();
            }

            else
                MessageBox.Show(productImage.Error);
        }

        private void frmProductImageNew_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            cmbProduct.DataSource = product.Select().Tables[0];
            cmbProduct.DisplayMember = "name";
            cmbProduct.ValueMember = "id";
            cmbProduct.SelectedValue = -1;
        }
    }
}
