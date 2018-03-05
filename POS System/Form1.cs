using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDJBatch18.POS.Presentation;

namespace BDJBatch18.POS
{
    public partial class Form1 : Form
    {

        Presentation.frmProductImage productImage = new Presentation.frmProductImage();
        frmBrand brand = new frmBrand();
        frmCategory category = new frmCategory();
        frmCity city = new frmCity();
        frmLedger ledger = new frmLedger();
        frmProduct product = new frmProduct();
        frmProductPrice productPrice = new frmProductPrice();
        frmPurchase purchase = new frmPurchase();
        frmTransaction transaction = new frmTransaction();
        frmUnit unit = new frmUnit();
        frmEmployee employee = new frmEmployee();
        //frmPurchaseDetails purchaseDetails = new frmPurchaseDetails();
        public Form1()
        {
            InitializeComponent();
        }

        private void productImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productImage.IsDisposed)
                productImage = new Presentation.frmProductImage();
            productImage.MdiParent = this;
            productImage.Show();
            productImage.BringToFront();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brand.IsDisposed)
                brand = new frmBrand();
            brand.MdiParent = this;
            brand.Show();
            brand.BringToFront();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (category.IsDisposed)
                category = new frmCategory();
            category.MdiParent = this;
            category.Show();
            category.BringToFront();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (city.IsDisposed)
                city = new frmCity();
            city.MdiParent = this;
            city.Show();
            city.BringToFront();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ledger.IsDisposed)
                ledger = new frmLedger();
            ledger.MdiParent = this;
            ledger.Show();
            ledger.BringToFront();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (product.IsDisposed)
                product = new frmProduct();
            product.MdiParent = this;
            product.Show();
            product.BringToFront();
        }

        private void productPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productPrice.IsDisposed)
                productPrice = new frmProductPrice();
            productPrice.MdiParent = this;
            productPrice.Show();
            productPrice.BringToFront();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (purchase.IsDisposed)
                purchase = new frmPurchase();
            purchase.MdiParent = this;
            purchase.Show();
            purchase.BringToFront();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transaction.IsDisposed)
                transaction = new frmTransaction();
            transaction.MdiParent = this;
            transaction.Show();
            transaction.BringToFront();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.IsDisposed)
                unit = new frmUnit();
            unit.MdiParent = this;
            unit.Show();
            unit.BringToFront();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee.IsDisposed)
                employee = new frmEmployee();
            employee.MdiParent = this;
            employee.Show();
            employee.BringToFront();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
