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
    public partial class frmCityEdit : BDJBatch18.POS.Presentation.Templates.frmNewEdit
    {
        City city = new City();
        public frmCityEdit(int _id)
        {
            InitializeComponent();

            city.Id = _id;

            if (city.SelectById())
            {
                txtName.Text = city.Name;
            }

            else
            {
                MessageBox.Show(city.Error);
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
                ep.SetError(txtName,"Name Required");
            }
            
            if (er > 0)
                return;
            
            city.Name = txtName.Text;

            if (city.Update())
            {
                MessageBox.Show(@"City Updated");
                Close();
            }
            else
                MessageBox.Show(city.Error);
        }

        private void frmCityNew_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
    }
}
