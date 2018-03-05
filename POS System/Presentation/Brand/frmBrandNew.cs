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
    public partial class frmBrandNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmBrandNew()
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

            if (txtOrigin.Text == "")
            {
                er++;
                ep.SetError(txtOrigin, "Origin Required");
            }
            
            if (er > 0)
                return;

            Brand brand = new Brand();
            brand.Name = txtName.Text;
            brand.Origin = txtOrigin.Text;
            
            if (brand.Insert())
            {
                MessageBox.Show(@"Brand Saved");
                txtName.Text = "";
                txtOrigin.Text = "";
                txtName.Focus();
            }
            else
                MessageBox.Show(brand.Error);
        }
    }
}
