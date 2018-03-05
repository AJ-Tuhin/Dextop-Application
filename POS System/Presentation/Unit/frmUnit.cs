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
    public partial class frmUnit : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        Unit unit = new Unit();
        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmUnitNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            unit.Search = txtSearch.Text;
            dgvUnit.DataSource = unit.Select().Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count <= 0)
                return;

            new frmUnitEdit(Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count <= 0)
                return;
            DialogResult dr = MessageBox.Show(@"Are You sure", @"Confirmation", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;

            unit.Id = Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["colId"].Value);

            if (unit.Delete())
            {
                MessageBox.Show(@"Unit Deleted");
                btnSearch.PerformClick();
            }
            else
                MessageBox.Show(unit.Error);
        }
    }
}
