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
    public partial class frmLedger : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        Ledger ledger = new Ledger();
        public frmLedger()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmLedgerNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLedger.DataSource = ledger.Select().Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLedger.SelectedRows.Count <= 0)
                return;

            new frmLedgerEdit(Convert.ToInt32(dgvLedger.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLedger.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show(@"Confirmation", @"Are you sure", MessageBoxButtons.YesNoCancel);
            if (dr != DialogResult.Yes)
                return;

            ledger.Id = Convert.ToInt32(dgvLedger.SelectedRows[0].Cells["colId"].Value);

            if (ledger.Delete())
            {
                MessageBox.Show(@"Ledger Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(ledger.Error);
            }

        }
    }
}
