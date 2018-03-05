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
    public partial class frmCategory : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        Category category = new Category();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmCategoryNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            category.Search = txtSearch.Text;
            category.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            dgvCategory.DataSource = category.Select().Tables[0];
            cmbCategory.SelectedValue = -1;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = category.Select().Tables[0];
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
            cmbCategory.SelectedValue = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count <= 0)
                return;
            //if (category.CategoryId >= 0)
            //{
            //    new frmCategoryEdit(Convert.ToInt32(dgvCategory.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            //}
            new frmCategoryEdit(Convert.ToInt32(dgvCategory.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show(@"Confirmation", @"Are you sure", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;

            category.Id = Convert.ToInt32(dgvCategory.SelectedRows[0].Cells["colId"].Value);

            if (category.Delete())
            {
                MessageBox.Show(@"Category Deleted");
                btnSearch.PerformClick();
            }

            else
                MessageBox.Show(category.Error);
        }
    }
}
