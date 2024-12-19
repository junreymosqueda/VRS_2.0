using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VRS_2._0
{
    public partial class Archive_user : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        public Archive_user()
        {
            InitializeComponent();
            LoadDeletedRecords();
            userarchive.Columns["IsDeleted"].Visible = false;
        }
        void LoadDeletedRecords()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM record WHERE IsDeleted = 1", conn);

            try
            {
                conn.Open();
                adapter.Fill(dt);
                userarchive.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();


            }
        }

        private void userarchive_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userarchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
