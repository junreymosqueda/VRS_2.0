using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRS_2._0
{
    public partial class UC_staffrecordform : UserControl
    {
        public UC_staffrecordform()
        {
            InitializeComponent();
        }

        private void btnstaffcancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {               
                this.Hide();
            }
            else
            {
                return;
            }           
        }

        private void btnstaffsave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Save this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //lagay mo yung code dito para sa staff save button.
                this.Hide();              
            }
            else
            {
                return;
            }
        }
    }
}
