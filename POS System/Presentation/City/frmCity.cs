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
    public partial class frmCity : BDJBatch18.POS.Presentation.Templates.frmDisplay
    {
        public frmCity()
        {
            InitializeComponent();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmCityNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Search = txtSearch.Text;
            dgvCity.DataSource = city.Select().Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedRows.Count <= 0)
                return;
            new frmCityEdit(Convert.ToInt32(dgvCity.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show(@"Are you sure?", @" Confermation", MessageBoxButtons.YesNoCancel);

            if (dr != DialogResult.Yes)
                return;

            City city = new City();
            city.Id = Convert.ToInt32(dgvCity.SelectedRows[0].Cells["colId"].Value);
            //string ids = "";
            //for(int i = 0; i <= dgvCity.SelectedRows.Count - 1; i++)
            //{
            //    ids += dgvCity.SelectedRows[i].Cells["colId"].Value + ", ";
            //}
            //ids = ids.Substring(0, ids.Length - 2);

            if (city.Delete())
            {
                MessageBox.Show(@"City Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(city.Error);
            }
        }
    }
}
