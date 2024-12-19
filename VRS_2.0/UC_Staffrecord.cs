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
    public partial class UC_Staffrecord : UserControl
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public UC_Staffrecord()
        {
            InitializeComponent();
            GetUsers();
        }
        void GetUsers()
        {
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
            string query = "SELECT * FROM record WHERE IsDeleted = 0";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvrecord.RowTemplate.Height = 50;
            dgvrecord.Font = new Font("Arial", 13);
            dgvrecord.DataSource = dt;
            dgvrecord.Columns["IsDeleted"].Visible = false;
            conn.Close();

            dgvrecord.Columns["StudentID"].Width = 150;
            dgvrecord.Columns["Lastname"].Width = 150;
            dgvrecord.Columns["StudentID"].Width = 150;
            dgvrecord.Columns["Firstname"].Width = 150;
            dgvrecord.Columns["Middlename"].Width = 150;
            dgvrecord.Columns["Contact"].Width = 150;
            dgvrecord.Columns["YearSection"].Width = 150;
            dgvrecord.Columns["Course"].Width = 150;
            dgvrecord.Columns["Violation"].Width = 150;
            dgvrecord.Columns["Witness"].Width = 150;
            dgvrecord.Columns["Date"].Width = 150;
            dgvrecord.Columns["Punishment"].Width = 150;
            dgvrecord.Columns["Deadline"].Width = 150;
            dgvrecord.Columns["Status"].Width = 150;
            dgvrecord.Columns["Semester"].Width = 150;
            dgvrecord.Columns["Offence"].Width = 150;
        }
        private void btnstaffedit_Click(object sender, EventArgs e)
        {
            panelrecord.Show();
            btnsave.Hide();
            btnupdate.Show();
            if (panelrecord.Visible)
            {
                btnstaffadd.Enabled = false;
                btnstaffedit.Enabled = false;
            }
            else
            {

            }
        }

        private void btnstaffadd_Click(object sender, EventArgs e)
        {
            btnsave.Show();
            btnupdate.Hide();
            panelrecord.Show();
            tbstudentID.Clear();
            tblastname.Clear();
            tbfirstname.Clear();
            tbmiddlename.Clear();
            tbcontact.Clear();
            cbcourse.SelectedIndex = -1;
            cbcourse.Text = string.Empty;
            //cbyearsection.SelectedIndex = -1;
            cbyearsection.Text = string.Empty;
            cbviolation.SelectedIndex = -1;
            cbviolation.Text = string.Empty;
            tboffence.Clear();
            tbwitness.Clear();
            dtpdate.Value = DateTime.Now;
            tbpunishment.Clear();
            dtpdeadline.Value = DateTime.Now;
            cbstatus.SelectedIndex = -1;
            cbstatus.Text = string.Empty;
            cbsemester.SelectedIndex = -1;
            cbsemester.Text = string.Empty;
            if (panelrecord.Visible)
            {
                btnstaffadd.Enabled = false;
                btnstaffedit.Enabled = false;
            }
            else
            {

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbstudentID.Text) ||
                string.IsNullOrWhiteSpace(tblastname.Text) ||
                string.IsNullOrWhiteSpace(tbfirstname.Text) ||
                string.IsNullOrWhiteSpace(tbmiddlename.Text) ||
                string.IsNullOrWhiteSpace(tbcontact.Text) ||
                string.IsNullOrWhiteSpace(cbcourse.Text) ||
                string.IsNullOrWhiteSpace(cbyearsection.Text) ||
                string.IsNullOrWhiteSpace(cbviolation.Text) ||
                string.IsNullOrWhiteSpace(tboffence.Text) ||
                string.IsNullOrWhiteSpace(tbpunishment.Text) ||
                string.IsNullOrWhiteSpace(cbstatus.Text) ||
                string.IsNullOrWhiteSpace(cbsemester.Text) ||
                string.IsNullOrWhiteSpace(tbwitness.Text) ||

            dtpdate.Value == null ||
            dtpdeadline.Value == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string query = "INSERT INTO record (StudentID,Lastname, Firstname, Middlename, Contact, Course, YearSection, Violation, Offence, Witness, [Date], Punishment, Deadline, Status, Semester) VALUES " +
                "(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("?", tbstudentID.Text);
            cmd.Parameters.AddWithValue("?", tblastname.Text);
            cmd.Parameters.AddWithValue("?", tbfirstname.Text);
            cmd.Parameters.AddWithValue("?", tbmiddlename.Text);
            cmd.Parameters.AddWithValue("?", tbcontact.Text);
            cmd.Parameters.AddWithValue("?", cbcourse.Text);
            cmd.Parameters.AddWithValue("?", cbyearsection.Text);
            cmd.Parameters.AddWithValue("?", cbviolation.Text);
            cmd.Parameters.AddWithValue("?", tboffence.Text);
            cmd.Parameters.AddWithValue("?", tbwitness.Text);
            cmd.Parameters.AddWithValue("?", dtpdate.Value);
            cmd.Parameters.AddWithValue("?", tbpunishment.Text);
            cmd.Parameters.AddWithValue("?", dtpdeadline.Value);
            cmd.Parameters.AddWithValue("?", cbstatus.Text);
            cmd.Parameters.AddWithValue("?", cbsemester.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Inserted Successfully");
            conn.Close();
            GetUsers();
            panelrecord.Hide();
            btnstaffadd.Enabled = true;
            btnstaffedit.Enabled = true;
        }

        private void dgvrecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvrecord.Rows[e.RowIndex];
                tbstudentID.Text = row.Cells["StudentID"].Value?.ToString();
                tblastname.Text = row.Cells["Lastname"].Value?.ToString();
                tbfirstname.Text = row.Cells["Firstname"].Value?.ToString();
                tbmiddlename.Text = row.Cells["Middlename"].Value?.ToString();
                tbcontact.Text = row.Cells["Contact"].Value?.ToString();
                cbcourse.Text = row.Cells["Course"].Value?.ToString();
                cbyearsection.Text = row.Cells["YearSection"].Value?.ToString();
                cbviolation.Text = row.Cells["Violation"].Value?.ToString();
                tboffence.Text = row.Cells["Offence"].Value?.ToString();
                tbwitness.Text = row.Cells["Witness"].Value?.ToString();
                dtpdate.Text = row.Cells["Date"].Value?.ToString();
                tbpunishment.Text = row.Cells["Punishment"].Value?.ToString();
                dtpdeadline.Text = row.Cells["Deadline"].Value?.ToString();
                cbstatus.Text = row.Cells["Status"].Value?.ToString();
                cbsemester.Text = row.Cells["Semester"].Value?.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbstudentID.Text) ||
        string.IsNullOrWhiteSpace(tblastname.Text) ||
        string.IsNullOrWhiteSpace(tbfirstname.Text) ||
        string.IsNullOrWhiteSpace(tbmiddlename.Text) ||
        string.IsNullOrWhiteSpace(tbcontact.Text) ||
        string.IsNullOrWhiteSpace(cbcourse.Text) ||
        string.IsNullOrWhiteSpace(cbyearsection.Text) ||
        string.IsNullOrWhiteSpace(cbviolation.Text) ||
        string.IsNullOrWhiteSpace(tboffence.Text) ||
        string.IsNullOrWhiteSpace(tbpunishment.Text) ||
        string.IsNullOrWhiteSpace(cbstatus.Text) ||
        string.IsNullOrWhiteSpace(cbsemester.Text) ||
        string.IsNullOrWhiteSpace(tbwitness.Text) ||
        dtpdate.Value == null ||
        dtpdeadline.Value == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Prepare the update query
            string query = "UPDATE record SET Lastname = ?, Firstname = ?, Middlename = ?, Contact = ?, Course = ?, YearSection = ?, Violation = ?, Offence = ?, Witness = ?, [Date] = ?, Punishment = ?, Deadline = ?, Status = ?, Semester = ? WHERE StudentID = ?";

            // Ensure the connection is initialized
            cmd = new OleDbCommand(query, conn);

            // Add parameters for the query
            cmd.Parameters.AddWithValue("?", tblastname.Text);
            cmd.Parameters.AddWithValue("?", tbfirstname.Text);
            cmd.Parameters.AddWithValue("?", tbmiddlename.Text);
            cmd.Parameters.AddWithValue("?", tbcontact.Text);
            cmd.Parameters.AddWithValue("?", cbcourse.Text);
            cmd.Parameters.AddWithValue("?", cbyearsection.Text);
            cmd.Parameters.AddWithValue("?", cbviolation.Text);
            cmd.Parameters.AddWithValue("?", tboffence.Text);
            cmd.Parameters.AddWithValue("?", tbwitness.Text);
            cmd.Parameters.AddWithValue("?", dtpdate.Value);
            cmd.Parameters.AddWithValue("?", tbpunishment.Text);
            cmd.Parameters.AddWithValue("?", dtpdeadline.Value);
            cmd.Parameters.AddWithValue("?", cbstatus.Text);
            cmd.Parameters.AddWithValue("?", cbsemester.Text);
            cmd.Parameters.AddWithValue("?", tbstudentID.Text);
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                DialogResult result = MessageBox.Show("Are you sure you want to UPDATE THIS RECORD?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
                    }
                }
                if (result == DialogResult.No)
                {

                }
                GetUsers();
                panelrecord.Hide();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            btnstaffadd.Enabled = true;
            btnstaffedit.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to CANCEL?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panelrecord.Hide();
            }
            btnstaffadd.Enabled = true;
            btnstaffedit.Enabled = true;
        }

        private void tbstaffsearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM record WHERE StudentID LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbstaffsearch.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();

            // Bind the DataTable to the DataGridView
            dgvrecord.DataSource = dt;
        }

        private void UC_Staffrecord_Load(object sender, EventArgs e)
        {
            dgvrecord.ClearSelection();
        }
    }
}
