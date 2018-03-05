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
    public partial class frmUnitEdit : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        Unit unit = new Unit();
        public frmUnitEdit(int _id)
        {
            InitializeComponent();
            unit.Id = _id;

            if (unit.SelectById())
            {
                txtName.Text = unit.Name;
                txtDescription.Text = unit.Description;
                txtPrimaryQty.Text = unit.PrimaryQty.ToString();
            }
            else
            {
                MessageBox.Show(unit.Error);
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
                ep.SetError(txtName,"Name Required");
            }

            if (txtDescription.Text == "")
            {
                er++;
                ep.SetError(txtDescription, "Description Required");
            }

            if (txtPrimaryQty.Text == "")
            {
                er++;
                ep.SetError(txtPrimaryQty, "Description Required");
            }

            if (er > 0)
                return;
            
            unit.Name = txtName.Text;
            unit.Description = txtDescription.Text;
            unit.PrimaryQty = Convert.ToInt32(txtPrimaryQty.Text);

            if (unit.Update())
            {
                MessageBox.Show(@"Unit Updated");
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

        private void frmUnitEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
