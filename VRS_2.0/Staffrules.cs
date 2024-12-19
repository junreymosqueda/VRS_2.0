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
    public partial class Staffrules : UserControl
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        public Staffrules()
        {
            InitializeComponent();
            cbselection.Items.Add("Rules");
            cbselection.Items.Add("Violation Minor Offenses");
            cbselection.Items.Add("Violation Major Offenses");
            cbselection.Items.Add("Punishment");
            dgvall.RowTemplate.Height = 50;
            dgvall.Font = new Font("Arial", 13);
        }
        private void ConfigureDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.CellClick += (s, e) =>
            {
            };
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            string selectedform = cbselection.SelectedItem.ToString();

            if (selectedform == "Rules")
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM rules WHERE Rules", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvall.DataSource = dt;
                conn.Close();
                if (dgvall.Columns.Contains("Rules"))
                {
                    dgvall.Columns["Rules"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                ConfigureDataGridView(dgvall);

            }
            else if (selectedform == "Violation Minor Offenses")
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM minor WHERE Minor", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvall.DataSource = dt;
                conn.Close();
                dgvall.Columns["Minor"].Width = 600;
                dgvall.Columns["Minor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["1st"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["2nd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["3rd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["4th"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["5th"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["1st"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["2nd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["3rd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["4th"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["5th"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (dgvall.Columns.Contains("Minor"))
                {
                    dgvall.Columns["Minor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                ConfigureDataGridView(dgvall);
            }
            else if (selectedform == "Violation Major Offenses")
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM major WHERE Major", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvall.DataSource = dt;
                conn.Close();
                dgvall.Columns["Major"].Width = 600;
                dgvall.Columns["Major"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["1st"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["2nd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["3rd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["4th"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["5th"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["1st"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["2nd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["3rd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["4th"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvall.Columns["5th"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (dgvall.Columns.Contains("Major"))
                {
                    dgvall.Columns["Major"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                ConfigureDataGridView(dgvall);
            }
            else if (selectedform == "Punishment")
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM punishment WHERE Punishment", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvall.DataSource = dt;
                conn.Close();
                if (dgvall.Columns.Contains("Punishment"))
                {
                    dgvall.Columns["Punishment"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                ConfigureDataGridView(dgvall);
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }

        }
    }
}
