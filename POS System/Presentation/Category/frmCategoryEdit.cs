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
    public partial class frmCategoryEdit : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        Category category = new Category();
        public frmCategoryEdit(int id)
        {
            InitializeComponent();
            LoadCategory();

            category.Id = id;

            if (category.SelectById())
            {
                txtName.Text = category.Name;
                txtDescription.Text = category.Description;
                cmbCategory.SelectedValue = category.CategoryId;

            }

            else
            {
                MessageBox.Show(category.Error);
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
            if (txtDescription.Text == "")
            {
                er++;
                ep.SetError(txtDescription, "Description Required");
            }

            if (er > 0)
                return;
            
            category.Name = txtName.Text;
            category.Description = txtDescription.Text;
            category.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            if (category.Update())
            {
                MessageBox.Show(@"Category Updated");
                Close();
            }

            else
                MessageBox.Show(category.Error);
        }

        private void frmCategoryNew_Load(object sender, EventArgs e)
        {
            //LoadCategory();
        }

        private void LoadCategory()
        {
            if (category.CategoryId > 0)
            {
                cmbCategory.DataSource = category.Select().Tables[0];
                cmbCategory.DisplayMember = "name";
                cmbCategory.ValueMember = "id";
                //cmbCategory.SelectedValue = -1;
            }
            else
                cmbCategory.Text = "";
        }
    }
}
