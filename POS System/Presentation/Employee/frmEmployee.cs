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
    public partial class frmEmployee : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmEmployeeNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Search = txtSearch.Text;
            dgvEmployee.DataSource = employee.Select().Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are you sure?", "Confermation", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;

            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["colId"].Value);

            string ids = "";
            for(int i = 0; i < dgvEmployee.SelectedRows.Count; i++)
            {
                ids += dgvEmployee.SelectedRows[i].Cells["colId"].Value + ", ";
            }
            ids = ids.Substring(0, ids.Length - 2);

            if (employee.Delete(ids))
            {
                MessageBox.Show("Employee Deleted");
                btnSearch.PerformClick();
            }

            else
            {
                MessageBox.Show(employee.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count <= 0)
                return;

            new frmEmployeeEdit(Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
