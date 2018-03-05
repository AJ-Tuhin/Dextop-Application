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
    public partial class frmBrandEdit : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        Brand brand = new Brand();
        public frmBrandEdit(int _id)
        {
            InitializeComponent();

            brand.Id = _id;

            if (brand.SelectById())
            {
                txtName.Text = brand.Name;
                txtOrigin.Text = brand.Origin;
            }

            else
            {
                MessageBox.Show(brand.Error);
                Close();
            }

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

            
            brand.Name = txtName.Text;
            brand.Origin = txtOrigin.Text;
            
            if (brand.Update())
            {
                MessageBox.Show(@"Brand Updated");
            }
            else
                MessageBox.Show(brand.Error);
        }

        private void frmBrandEdit_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }
    }
}
