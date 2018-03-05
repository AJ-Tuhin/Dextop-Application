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
    public partial class frmLedgerEdit : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        Ledger ledger = new Ledger();
        public frmLedgerEdit(int id)
        {
            InitializeComponent();
            City city = new City();
            cmbCity.DataSource = city.Select().Tables[0];
            cmbCity.DisplayMember = "name";
            cmbCity.ValueMember = "id";
            //cmbCity.SelectedValue = -1;

            ledger.Id = id;

            if (ledger.SelectById())
            {
                txtName.Text = ledger.Name;
                txtContact.Text = ledger.Contact;
                txtEmail.Text = ledger.Email;
                txtPassword.Text = ledger.Password;
                cmbGender.Text = ledger.Gender;
                txtAddress.Text = ledger.Address;
                cmbCity.SelectedValue = ledger.CityId;
                //dtpDateOfBirth = ledger.DateOfBirth;
                cmbType.Text = ledger.Type;
                pbImage.Image = FileImage.ImageFromByte(ledger.Image);
            }
        }

        private void frmLedgerNew_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Size;
            this.MinimumSize = Size;
            
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


            if (ledger.Update())
            {
                if (cmbType.Text == @"Customer")
                {
                    MessageBox.Show(@"Customer Updated");
                    
                }
                else
                {
                    MessageBox.Show(@"Supplier Updated");
                }
                Close();
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
