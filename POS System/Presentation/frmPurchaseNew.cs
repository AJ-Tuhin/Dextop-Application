using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace BDJBatch18.POS.Presentation
{
    public partial class frmPurchaseNew : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        public frmPurchaseNew()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPurchaseNew_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            Ledger ledger = new Ledger();
            cmbLedger.DataSource = ledger.Select().Tables[0];
            cmbLedger.DisplayMember = "name";
            cmbLedger.ValueMember = "id";
            cmbLedger.SelectedValue = -1;

            Employee employee = new Employee();
            cmbEmployee.DataSource = employee.Select().Tables[0];
            cmbEmployee.DisplayMember = "name";
            cmbEmployee.ValueMember = "id";
            cmbEmployee.SelectedValue = -1;

            Product product = new Product();
            colproduct.DataSource = product.Select().Tables[0];
            colproduct.DisplayMember = "name";
            colproduct.ValueMember = "id";

        }

        public void LoadTotal()
        {
            double total = 0;

            for (int i = 0; i < dgvPurchaseNew.Rows.Count - 1; i++)
            {
                try
                {
                    total += Convert.ToDouble(dgvPurchaseNew.Rows[i].Cells["colSubTotal"].Value);
                }
                catch (Exception)
                {
                }

                txtTotal.Text = total.ToString();
                txtGrandTotal.Text = (total + total*Convert.ToDouble(txtVat.Text)/100 - total*Convert.ToDouble(txtDiscount.Text)/100).ToString();
            }
        }
        private void dgvPurchaseNew_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Product product = new Product();

                product.Id = Convert.ToInt32(dgvPurchaseNew.Rows[e.RowIndex].Cells["colProduct"].Value);
                product.SelectById();
                dgvPurchaseNew.Rows[e.RowIndex].Cells["colQty"].Value = 1;
                dgvPurchaseNew.Rows[e.RowIndex].Cells["colRate"].Value = product.Price;
                dgvPurchaseNew.Rows[e.RowIndex].Cells["colSubTotal"].Value = 1*product.Price;
            }

            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex >= 0)
            {
                double qty = Convert.ToDouble(dgvPurchaseNew.Rows[e.RowIndex].Cells["colQty"].Value);
                double rate = Convert.ToDouble(dgvPurchaseNew.Rows[e.RowIndex].Cells["colRate"].Value);
                dgvPurchaseNew.Rows[e.RowIndex].Cells["colSubTotal"].Value = qty*rate;
            }

            LoadTotal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();

            if (txtNumber.Text == "")
            {
                er++;
                ep.SetError(txtNumber, " Number Required");
            }

            if (cmbLedger.SelectedValue == null || cmbLedger.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbLedger, " Ledger Required");
            }

            if (cmbEmployee.SelectedValue == null || cmbEmployee.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbEmployee, " Employee Required");
            }

            if (dtpDateTime.Text == "")
            {
                er++;
                ep.SetError(dtpDateTime, " Date Required");
            }

            if (er > 0)
                return;

            Purchase purchase = new Purchase();
            purchase.Number = txtNumber.Text;
            purchase.DateTime = Convert.ToDateTime(dtpDateTime.Value);
            purchase.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
            purchase.LedgerId = Convert.ToInt32(cmbLedger.SelectedValue);
            purchase.Total = Convert.ToDouble(txtTotal.Text);
            purchase.Vat = Convert.ToDouble(txtVat.Text);
            purchase.Discount = Convert.ToDouble(txtDiscount.Text);

            if (purchase.Insert())
            {
                for (int i = 0; i < dgvPurchaseNew.Rows.Count - 1; i++)
                {
                    PurchaseDetails purchaseDetails = new PurchaseDetails();
                    purchaseDetails.PurchaseId = purchase.LastId;

                    purchaseDetails.ProductId = Convert.ToInt32(dgvPurchaseNew.Rows[i].Cells["colProduct"].Value);
                    purchaseDetails.Qty = Convert.ToInt32(dgvPurchaseNew.Rows[i].Cells["colQty"].Value);
                    purchaseDetails.Rate = Convert.ToDouble(dgvPurchaseNew.Rows[i].Cells["colRate"].Value);
                    purchaseDetails.Insert();
                }

                MessageBox.Show(@"Purchase Saved");
                dgvPurchaseNew.Rows.Clear();
            }

            else
                MessageBox.Show(purchase.Error);

        }
    }
}
