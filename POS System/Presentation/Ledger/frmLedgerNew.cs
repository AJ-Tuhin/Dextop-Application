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
    public partial class frmLedgerNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmLedgerNew()
        {
            InitializeComponent();
        }

        private void frmLedgerNew_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Size;
            this.MinimumSize = Size;

            City city = new City();
            cmbCity.DataSource = city.Select().Tables[0];
            cmbCity.DisplayMember = "name";
            cmbCity.ValueMember = "id";
            cmbCity.SelectedValue = -1;
            
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

            if (cmbGender.Text.ToString() == "")
            {
                er++;
                ep.SetError(cmbGender, "Gender Required");
            }

            if (txtAddress.Text == "")
            {
                er++;
                ep.SetError(txtAddress, "Address Required");
            }

            if (cmbCity.SelectedValue == null || cmbCity.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbCity, "City Required");
            }

            if (dtpDateOfBirth.Text == "")
            {
                er++;
                ep.SetError(dtpDateOfBirth, "DOB Required");
            }

            if (cmbType.Text.ToString() == "")
            {
                er++;
                ep.SetError(cmbType, "City Required");
            }

            if (pbImage.Image == null)
            {
                er++;
                ep.SetError(pbImage, "Image Required");
            }

            if (er > 0)
                return;

            Ledger ledger = new Ledger();
            ledger.Name = txtName.Text;
            ledger.Contact = txtContact.Text;
            ledger.Email = txtEmail.Text;
            ledger.Password = txtPassword.Text;
            ledger.Gender = cmbGender.Text;
            ledger.Address = txtAddress.Text;
            ledger.CityId = Convert.ToInt32(cmbCity.SelectedValue);
            ledger.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
            ledger.Type = cmbType.Text;
            ledger.Image = FileImage.ImageToByte(pbImage.Image);


            if (ledger.Insert())
            {
                if (cmbType.Text == @"Customer")
                {
                    MessageBox.Show(@"Customer Saved");
                }
                else
                {
                    MessageBox.Show(@"Supplier Saved");
                }
                
                txtName.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                cmbGender.Text = "";
                txtAddress.Text = "";
                cmbCity.SelectedValue = -1;
                dtpDateOfBirth = null;
                cmbType.Text = "";
                pbImage.Image = null;
                txtName.Focus();
            }

            else
                MessageBox.Show(ledger.Error);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
