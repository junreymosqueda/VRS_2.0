using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VRS_2._0
{
    public partial class UC_record : UserControl
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public UC_record()
        {
            InitializeComponent();
            dgvrecord.RowTemplate.Height = 50;
            dgvrecord.Font = new Font("Arial", 13);
            GetUsers();
        }
        void GetUsers()
        {
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
            string query = "SELECT * FROM record WHERE IsDeleted = 0";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvrecord.DataSource = dt;
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
            dgvrecord.Columns["IsDeleted"].Visible = false;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetUsers();
            dgvrecord.Columns["IsDeleted"].Visible = false;
            dgvrecord.SelectionChanged += Dgvrecord_SelectionChanged;
            //cbstatus.Items.Clear();
            //cbstatus.Items.Add("Done");
            //cbstatus.Items.Add("Pending");
            //cbstatus.Items.Add("Undone");
            //cbstatus.Refresh();
            //cbstatus.Visible = true;
            //cbstatus.BringToFront();
            //cbstatus.Focus();
        }

        private void Dgvrecord_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            btnadd.Enabled = true;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnedit.Enabled = false ;
            btndelete.Enabled = false;
            btnreset.Enabled = false;    
            btnsave.Show();
            btnupdate.Hide();
            panelrecord.Show();
            panelrecord.BringToFront();
            panelrecord.Visible = true;
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
        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnreset.Enabled = false;
            DialogResult result = MessageBox.Show("Are you sure you want to Delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(tbstudentID.Text))
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                string query = "UPDATE record SET IsDeleted = 1 WHERE StudentID = ?";

                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", tbstudentID.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record successfully deleted!");
                    btnadd.Enabled = true;
                    btnedit.Enabled = true;
                    btndelete.Enabled = true;
                    btnreset.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    GetUsers();
                }
            }
            else
            {
                btnadd.Enabled = true;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnreset.Enabled = true;
                return;
            }
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
        

        private void btnedit_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnreset.Enabled = false;
            panelrecord.Show();
            btnsave.Hide();
            btnupdate.Show();
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
                        btnadd.Enabled = true;  
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
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to CANCEL?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panelrecord.Hide();
                btnadd.Enabled = true;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnreset.Enabled = true;
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM record WHERE StudentID LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbsearch.Text + "%");

            dt = new DataTable();
            conn.Open(); 
            adapter.Fill(dt);
            conn.Close(); 

            // Bind the DataTable to the DataGridView
            dgvrecord.DataSource = dt;

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnreset.Enabled = false;
            DialogResult result = MessageBox.Show("This action will delete all records and create a backup file. Do you want to proceed?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                    saveFileDialog.Title = "Save Backup File";
                    saveFileDialog.FileName = "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string backupFilePath = saveFileDialog.FileName;
                        ExportDataToCSV(backupFilePath);

                        string query = "UPDATE record SET IsDeleted = 1";

                        conn.Open();
                        cmd = new OleDbCommand(query, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{rowsAffected} records have been deleted and backed up successfully!", "Success");
                            GetUsers();
                            btnadd.Enabled = true;
                            btnedit.Enabled = true;
                            btndelete.Enabled = true;
                            btnreset.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No records were deleted. Check if the database is empty or locked.", "Information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Backup operation was Canceled.", "Information");
                        btnadd.Enabled = true;
                        btnedit.Enabled = true;
                        btndelete.Enabled = true;
                        btnreset.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                btnadd.Enabled = true;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnreset.Enabled = true;
            }
        }
        private void ExportDataToCSV(string filePath)
        {
            try
            {
                if (dgvrecord.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to save.", "Information");
                    return;
                }

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    var columnNames = dgvrecord.Columns.Cast<DataGridViewColumn>()
                                          .Where(column => column.Name != "IsDeleted")
                                          .Select(column => column.HeaderText)
                                          .ToArray();
                    sw.WriteLine(string.Join(",", columnNames));

                    foreach (DataGridViewRow row in dgvrecord.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["IsDeleted"].Value?.ToString() != "1")
                        {
                            var fields = row.Cells.Cast<DataGridViewCell>()
                                          .Where(cell => cell.OwningColumn.Name != "IsDeleted")
                                          .Select(cell => cell.Value?.ToString().Replace(",", " ") ?? "")
                                          .ToArray();
                            sw.WriteLine(string.Join(",", fields));
                        }
                    }
                }

                MessageBox.Show("Backup file created successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting data: " + ex.Message, "Error");
            }
        }

        private void dgvrecord_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvrecord.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvrecord.SelectedRows[0]; 
                if (selectedRow.Cells[0].Value != null && !string.IsNullOrWhiteSpace(selectedRow.Cells[0].Value.ToString()))
                {
                    btnedit.Enabled = true;
                    btndelete.Enabled = true;
                    btnreset.Enabled = true;
                    return;
                }
            }
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnreset.Enabled = false;

        }

        private void UC_record_Load(object sender, EventArgs e)
        {
           
        }

        private void UC_record_Click(object sender, EventArgs e)
        {
            dgvrecord.ClearSelection();
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}