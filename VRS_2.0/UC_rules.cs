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
    public partial class UC_rules : UserControl
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        public UC_rules()
        {
            InitializeComponent();
            cbselection.Items.Add("Rules");
            cbselection.Items.Add("Violation Minor Offenses");
            cbselection.Items.Add("Violation Major Offenses");
            cbselection.Items.Add("Punishment");
            dgvall.RowTemplate.Height = 50;
            dgvall.Font = new Font("Arial", 13);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tball.Clear();
                panel5.Hide();
            }
            else
            {
                return;
            }
        }

        private void btnruleadd_Click(object sender, EventArgs e)
        {
            string selectedform = cbselection.SelectedItem.ToString();
            if (selectedform == "Violation Minor Offenses")
            {
                panel5.Hide();
                panelvio.Show();
                btneedit.Hide();
                tbnvio.Show();
            }
            else if (selectedform == "Rules")
            {
                panel5.Show();
                panel5.BringToFront();
                panelvio.Hide();
                btnedit.Hide();
            }
            else if (selectedform == "Violation Major Offenses")
            {
                btneedit.Hide();
                panel5.Hide();
                panelvio.Show();
                tbnvio.Show();
            }
            else if (selectedform == "Punishment")
            {
                panel5.Show();
                panel5.BringToFront();
                panelvio.Hide();
                btnedit.Hide();
                btnrulesave.Show();
            }
        }

        private void btnrulesave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string selectedform = cbselection.SelectedItem.ToString();
                if (selectedform == "Rules")
                {
                    // Ensure the connection is properly initialized
                    conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                    try
                    {
                        conn.Open();

                        // Insert the new rule into the database
                        string insertQuery = "INSERT INTO rules (Rules) VALUES (?)";
                        cmd = new OleDbCommand(insertQuery, conn);

                        // Add the parameter for the rule description
                        cmd.Parameters.AddWithValue("?", tball.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Rule added successfully!");

                        // Refresh the DataGridView
                        string selectQuery = "SELECT * FROM rules";
                        adapter = new OleDbDataAdapter(selectQuery, conn);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dgvall.DataSource = dt;
                        dgvall.Refresh();

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
                else if (selectedform == "Punishment")
                {

                    conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                    try
                    {
                        conn.Open();

                        // Insert the new violation into the database
                        string insertQuery = "INSERT INTO punishment (Punishment) VALUES (?)";
                        cmd = new OleDbCommand(insertQuery, conn);

                        // Add the parameter for the violation description
                        cmd.Parameters.AddWithValue("?", tball.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Violation added successfully!");

                        // Refresh the DataGridView
                        string selectQuery = "SELECT * FROM punishment";
                        adapter = new OleDbDataAdapter(selectQuery, conn);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dgvall.DataSource = dt;
                        dgvall.Refresh();
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
                else
                {
                    MessageBox.Show("Please select a valid form type (Rules or Violation).");
                }

                // Clear the input field and hide the panel after saving
                tball.Clear();
                panel5.Hide();
            }
            else
            {
                return;
            }

        }

        private void btnruleedit_Click(object sender, EventArgs e)
        {
            if (dgvall.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            DataGridViewRow selectedRow = dgvall.SelectedRows[0];
            string selectedform = cbselection.SelectedItem?.ToString();

            if (selectedform == "Rules")
            {
                tball.Text = selectedRow.Cells["Rules"].Value?.ToString();
                panel5.Show();
                btnrulesave.Hide();
                btnedit.Show();
                panel5.BringToFront();
            }
            else if (selectedform == "Punishment")
            {
                tball.Text = selectedRow.Cells["Punishment"].Value?.ToString();
                panel5.Show();
                btnrulesave.Hide();
                btnedit.Show();
                panel5.BringToFront();
            }
            else if (selectedform == "Violation Minor Offenses")
            {
                txball.Text = selectedRow.Cells["Minor"].Value?.ToString();
                tb1st.Text = selectedRow.Cells["1st"].Value?.ToString();
                tb2nd.Text = selectedRow.Cells["2nd"].Value?.ToString();
                tb3rd.Text = selectedRow.Cells["3rd"].Value?.ToString();
                tb4th.Text = selectedRow.Cells["4th"].Value?.ToString();
                tb5th.Text = selectedRow.Cells["5th"].Value?.ToString();
                panelvio.Show();
                panel5.Hide();
                btneedit.Show();
                tbnvio.Hide();
            }
            else if (selectedform == "Violation Major Offenses")
            {
                txball.Text = selectedRow.Cells["Major"].Value?.ToString();
                tb1st.Text = selectedRow.Cells["1st"].Value?.ToString();
                tb2nd.Text = selectedRow.Cells["2nd"].Value?.ToString();
                tb3rd.Text = selectedRow.Cells["3rd"].Value?.ToString();
                tb4th.Text = selectedRow.Cells["4th"].Value?.ToString();
                tb5th.Text = selectedRow.Cells["5th"].Value?.ToString();
                panelvio.Show();
                panel5.Hide();
                btneedit.Show();
                tbnvio.Hide();
            }
            else
            {
                MessageBox.Show("Please select a valid form type to edit.");
            }

            btnrulesave.Hide();
            btnedit.Show();

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
                dgvall.Columns["Rules"].Width = 150;
                dgvall.Columns["Rules"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                panel5.Hide();
                tball.Clear();
                dgvall.Columns["Punishment"].Width = 150;
                dgvall.Columns["Punishment"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ConfigureDataGridView(dgvall);

            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void tbnvio_Click(object sender, EventArgs e)
        {
            string selectedform = cbselection.SelectedItem.ToString();
            if (selectedform == "Violation Minor Offenses")
            {

                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO minor (Minor, [1st], [2nd], [3rd], [4th], [5th]) VALUES (?, ?, ?, ?, ?, ?)";
                    cmd = new OleDbCommand(insertQuery, conn);

                    cmd.Parameters.AddWithValue("?", txball.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb1st.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb2nd.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb3rd.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb4th.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb5th.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Violation added successfully!");

                    string selectQuery = "SELECT * FROM minor";
                    adapter = new OleDbDataAdapter(selectQuery, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvall.DataSource = dt;
                    dgvall.Refresh();
                    panelvio.Hide();
                    txball.Clear();
                    tb1st.Clear();
                    tb2nd.Clear();
                    tb3rd.Clear();
                    tb4th.Clear();
                    tb5th.Clear();
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
            else if (selectedform == "Violation Major Offenses")
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO major (Major, [1st], [2nd], [3rd], [4th], [5th]) VALUES (?, ?, ?, ?, ?, ?)";
                    cmd = new OleDbCommand(insertQuery, conn);

                    cmd.Parameters.AddWithValue("?", txball.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb1st.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb2nd.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb3rd.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb4th.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb5th.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Violation added successfully!");

                    string selectQuery = "SELECT * FROM Major";
                    adapter = new OleDbDataAdapter(selectQuery, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvall.DataSource = dt;
                    dgvall.Refresh();
                    panelvio.Hide();
                    txball.Clear();
                    tb1st.Clear();
                    tb2nd.Clear();
                    tb3rd.Clear();
                    tb4th.Clear();
                    tb5th.Clear();
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
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txball.Clear();
                tb1st.Clear();
                tb2nd.Clear();
                tb3rd.Clear();
                tb4th.Clear();
                tb5th.Clear();
                panelvio.Hide();
            }
            else
            {
                return;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvall.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvall.SelectedRows[0];
                string selectedform = cbselection.SelectedItem?.ToString();

                if (selectedform == null)
                {
                    MessageBox.Show("Please select a form type.");
                    return;
                }

                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                try
                {
                    conn.Open();

                    string updateQuery = "";
                    string primaryKey1 = "Rules";
                    string primaryKey2 = "Punishment";

                    // Identify the form and set the query
                    if (selectedform == "Rules")
                    {
                        // Assuming "RuleID" and "Category" are the two primary keys
                        primaryKey1 = selectedRow.Cells["Rules"].Value?.ToString();  // First primary key
                        primaryKey2 = selectedRow.Cells["Rules"].Value?.ToString();  // Second primary key

                        if (string.IsNullOrEmpty(primaryKey1) || string.IsNullOrEmpty(primaryKey2))
                        {
                            MessageBox.Show("No valid record selected.");
                            return;
                        }

                        updateQuery = "UPDATE rules SET Rules = ? WHERE Rules = ? AND Rules = ?";

                    }
                    else if (selectedform == "Punishment")
                    {
                        primaryKey1 = selectedRow.Cells["Punishment"].Value?.ToString();
                        primaryKey2 = selectedRow.Cells["Punishment"].Value?.ToString();

                        if (string.IsNullOrEmpty(primaryKey1) || string.IsNullOrEmpty(primaryKey2))
                        {
                            MessageBox.Show("No valid record selected.");
                            return;
                        }

                        updateQuery = "UPDATE punishment SET Punishment = ? WHERE Punishment = ? AND Punishment = ?";
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid form type.");
                        return;
                    }

                    // Initialize the command and set parameters
                    cmd = new OleDbCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("?", tball.Text.Trim()); // New value to update
                    cmd.Parameters.AddWithValue("?", primaryKey1);  // First primary key
                    cmd.Parameters.AddWithValue("?", primaryKey2);  // Second primary key

                    // Execute the update query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record updated successfully!");

                    // Refresh the DataGridView
                    string tableName = selectedform.ToLower(); // Adjust table naming logic if needed
                    string selectQuery = $"SELECT * FROM {tableName}";
                    adapter = new OleDbDataAdapter(selectQuery, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvall.DataSource = dt;
                    dgvall.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    panel5.Hide();
                    tball.Clear();
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
            else
            {
                MessageBox.Show("Please select a record to edit.");
            }

        }

        private void btneedit_Click(object sender, EventArgs e)
        {
            if (dgvall.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvall.SelectedRows[0];
                string selectedform = cbselection.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedform))
                {
                    MessageBox.Show("Please select a form type.");
                    return;
                }

                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                try
                {
                    conn.Open();

                    string updateQuery = "";
                    string primaryKey1 = "Minor";
                    string primaryKey2 = "Major";

                    if (selectedform == "Minor")
                    {
                        primaryKey1 = selectedRow.Cells["Minor"].Value?.ToString();

                        if (string.IsNullOrEmpty(primaryKey1))
                        {
                            MessageBox.Show("No valid record selected.");
                            return;
                        }

                        updateQuery = "UPDATE minor SET Minor = ?, [1st] = ?, [2nd] = ?, [3rd] = ?, [4th] = ?, [5th] = ?  WHERE Minor = ? AND Minor = ?";
                        
                    }
                    else if (selectedform == "Major")
                    {
                        primaryKey2 = selectedRow.Cells["Major"].Value?.ToString();

                        if (string.IsNullOrEmpty(primaryKey2))
                        {
                            MessageBox.Show("No valid record selected.");
                            return;
                        }

                        updateQuery = "UPDATE major SET Major = ?, [1st] = ?, [2nd] = ?, [3rd] = ?, [4th] = ?, [5th] = ? WHERE Major = ? AND Major = ?";
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid form type.");
                        return;
                    }

                    cmd = new OleDbCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("?", txball.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb1st.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb2nd.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb3rd.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb4th.Text.Trim());
                    cmd.Parameters.AddWithValue("?", tb5th.Text.Trim());
                    cmd.Parameters.AddWithValue("?", primaryKey1);
                    cmd.Parameters.AddWithValue("?", primaryKey2);  

            
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record updated successfully!");

                    string tableName = selectedform.ToLower();
                    string selectQuery = $"SELECT * FROM {tableName}";
                    adapter = new OleDbDataAdapter(selectQuery, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvall.DataSource = dt;
                    dgvall.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    foreach (DataGridViewColumn column in dgvall.Columns)
                    {
                        column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                    panelvio.Hide();
                    txball.Clear();
                    tb1st.Clear();
                    tb2nd.Clear();
                    tb3rd.Clear();
                    tb4th.Clear();
                    tb5th.Clear();
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
            else
            {
                MessageBox.Show("Please select a record to edit.");
            }

        }

        private void btnruledelete_Click(object sender, EventArgs e)
        {
           
        }
        private void ConfigureDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbselection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnruledelete_Click_1(object sender, EventArgs e)
        {
            if (dgvall.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            // Confirm with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Get the selected row and form type
                DataGridViewRow selectedRow = dgvall.SelectedRows[0];
                string selectedform = cbselection.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedform))
                {
                    MessageBox.Show("Please select a form type.");
                    return;
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");

                try
                {
                    conn.Open();

                    string deleteQuery = "";
                    string primaryKey = null;

                    if (selectedform == "Rules")
                    {
                        primaryKey = selectedRow.Cells["Rules"].Value?.ToString();
                        deleteQuery = "DELETE FROM rules WHERE Rules = ?";
                    }
                    else if (selectedform == "Punishment")
                    {
                        primaryKey = selectedRow.Cells["Punishment"].Value?.ToString();
                        deleteQuery = "DELETE FROM punishment WHERE Punishment = ?";
                    }
                    else if (selectedform == "Violation Minor Offenses")
                    {
                        primaryKey = selectedRow.Cells["Minor"].Value?.ToString();
                        deleteQuery = "DELETE FROM minor WHERE Minor = ?";
                        dgvall.Refresh();
                    }
                    else if (selectedform == "Major")
                    {
                        primaryKey = selectedRow.Cells["Violation Major Offenses"].Value?.ToString();
                        deleteQuery = "DELETE FROM major WHERE Major = ?";
                        dgvall.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection.");
                        return;
                    }
                    if (string.IsNullOrEmpty(primaryKey))
                    {
                        MessageBox.Show("No valid record selected.");
                        return;
                    }


                    cmd = new OleDbCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("?", primaryKey);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record deleted successfully!");

                    string tableName = selectedform;
                    string selectQuery = $"SELECT * FROM {tableName}";
                    adapter = new OleDbDataAdapter(selectQuery, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvall.DataSource = dt;
                    dgvall.Refresh();
                }
                catch (Exception ex)
                {
                   
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
