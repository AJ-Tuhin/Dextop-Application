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
    public partial class frmUnitNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        ErrorProvider error = new ErrorProvider();
        public frmUnitNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            error.Clear();

            if (txtName.Text == "")
            {
                er++;
                error.SetError(txtName,"Name Required");
            }

            if (txtDescription.Text == "")
            {
                er++;
                error.SetError(txtDescription, "Description Required");
            }

            if (txtPrimaryQty.Text == "")
            {
                er++;
                error.SetError(txtPrimaryQty, "Description Required");
            }

            if (er > 0)
                return;

            Unit unit = new Unit();
            unit.Name = txtName.Text;
            unit.Description = txtDescription.Text;
            unit.PrimaryQty = Convert.ToInt32(txtPrimaryQty.Text);

            if (unit.Insert())
            {
                MessageBox.Show(@"Unit saved");
                txtName.Text = "";
                txtDescription.Text = "";
                txtPrimaryQty.Text = "";
                txtName.Focus();
            }

            else
                MessageBox.Show(unit.Error);
        }

        private void txtPrimaryQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
