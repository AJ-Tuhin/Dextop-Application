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
    public partial class frmEmployeeEdit : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        Employee employee = new Employee();
        public frmEmployeeEdit(int _id)
        {
            InitializeComponent();

            employee.Id = _id;

            if (employee.SelectById())
            {
                txtName.Text = employee.Name;
                txtContact.Text = employee.Contact;
                txtEmail.Text = employee.Email;
                txtPassword.Text = employee.Password;
            }
            else
            {
                MessageBox.Show(employee.Error);
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

            
            employee.Name = txtName.Text;
            employee.Contact = txtContact.Text;
            employee.Email = txtEmail.Text;
            employee.Password = txtPassword.Text;
            employee.Type = cmbEmployeeType.Text;

            if (employee.Update())
            {
                MessageBox.Show(@"Employee Updated");
                Close();
            }
            else
                MessageBox.Show(employee.Error);
        }

        private void frmEmployeeEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
