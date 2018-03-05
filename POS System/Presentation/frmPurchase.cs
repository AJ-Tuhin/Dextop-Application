using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDJBatch18.POS.Presentation
{
    public partial class frmPurchase : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmPurchaseNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.Purchase purchase = new DAL.Purchase();
            dgvPurchase.DataSource = purchase.Select().Tables[0];
        }
    }
}
