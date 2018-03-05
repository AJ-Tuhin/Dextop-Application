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
    public partial class frmEmployeeNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmEmployeeNew()
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

            if (txtContact.Text == "")
            {
                er++;
                ep.SetError(txtContact, "Contact Required");
            }

            if (txtEmail.Text == "")
            {
                er++;
                ep.SetError(txtEmail, "Email Required");
            }

            if (txtPassword.Text == "")
            {
                er++;
                ep.SetError(txtPassword, "Password Required");
            }

            //if (cmbEmployeeType.SelectedValue == null || cmbEmployeeType.SelectedValue.ToString() == "")
            //{
            //    er++;
            //    ep.SetError(cmbEmployeeType, "Employee Type Required");
            //}

            if (cmbEmployeeType.Text == "")
            {
                er++;
                ep.SetError(cmbEmployeeType, "Employee Type Required");
            }

            if (er > 0)
                return;

            Employee employee = new Employee();
            employee.Name = txtName.Text;
            employee.Contact = txtContact.Text;
            employee.Email = txtEmail.Text;
            employee.Password = txtPassword.Text;
            employee.Type = cmbEmployeeType.Text;

            if (employee.Insert())
            {
                MessageBox.Show(@"Employee Saved");
                txtName.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                //cmbEmployeeType.Text = string.Empty;
                txtName.Focus();
            }
            else
                MessageBox.Show(employee.Error);
        }
    }
}
