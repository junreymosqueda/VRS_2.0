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
    public partial class Archive : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        public Archive()
        {
            InitializeComponent();
            dgvarchive.RowTemplate.Height = 50;
            dgvarchive.Font = new Font("Arial", 13);
            cbtable.Items.Add("record");
            cbtable.Items.Add("user");
            Getuser();



        }
        void Getuser()
        {
          
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            string selectedform = cbtable.SelectedItem.ToString();

            if (selectedform == "record")
            {
                if (dgvarchive.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to retrive.");
                    return;
                }

                string id = dgvarchive.SelectedRows[0].Cells["StudentID"].Value.ToString();
                string query = "UPDATE record SET IsDeleted = 0 WHERE StudentID = @id";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Retrived");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    Getuser();
                }

            }
            else if (selectedform == "user")
            {
                if (dgvarchive.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to retrive.");
                    return;
                }

                string first = dgvarchive.SelectedRows[0].Cells["Firstname"].Value.ToString();
                string query = "UPDATE [user] SET IsDeleted = 0 WHERE Firstname = @f";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@f", first);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Retrived");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    Getuser();
                }
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string selectedform = cbtable.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to Delete this permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (selectedform == "record")
                {
                    string id = dgvarchive.SelectedRows[0].Cells["StudentID"].Value.ToString();
                    // Create a new OleDbCommand for the permanent delete query
                    cmd = new OleDbCommand("DELETE FROM record WHERE StudentID = @i", conn);
                    cmd.Parameters.AddWithValue("@i", id);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record successfully deleted from the database!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        Getuser();
                        btnok_Click(sender, e);
                    }


                }
                else if (selectedform == "user")
                {
                    string first = dgvarchive.SelectedRows[0].Cells["Firstname"].Value.ToString();
                    // Create a new OleDbCommand for the permanent delete query
                    cmd = new OleDbCommand("DELETE FROM [user] WHERE Firstname = @F", conn);
                    cmd.Parameters.AddWithValue("@F", first);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record successfully deleted from the database!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        Getuser();
                        btnok_Click(sender, e);
                    }

                }
            }

            else
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string selectedform = cbtable.SelectedItem.ToString();

            if (selectedform == "record")
            {
                // table Clearance connetion
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM record WHERE IsDeleted = 1", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvarchive.DataSource = dt;
                conn.Close();

                dgvarchive.Columns["StudentID"].Width = 150;
                dgvarchive.Columns["Lastname"].Width = 150;
                dgvarchive.Columns["StudentID"].Width = 150;
                dgvarchive.Columns["Firstname"].Width = 150;
                dgvarchive.Columns["Middlename"].Width = 150;
                dgvarchive.Columns["Contact"].Width = 150;
                dgvarchive.Columns["YearSection"].Width = 150;
                dgvarchive.Columns["Course"].Width = 150;
                dgvarchive.Columns["Violation"].Width = 150;
                dgvarchive.Columns["Witness"].Width = 150;
                dgvarchive.Columns["Date"].Width = 150;
                dgvarchive.Columns["Punishment"].Width = 150;
                dgvarchive.Columns["Deadline"].Width = 150;
                dgvarchive.Columns["Status"].Width = 150;
                dgvarchive.Columns["Semester"].Width = 150;
                dgvarchive.Columns["Offence"].Width = 150;

            }
            else if (selectedform == "user")
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM [user] WHERE IsDeleted = 1", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvarchive.DataSource = dt;
                dgvarchive.Columns["IsDeleted"].Visible = false;
                conn.Close();

                dgvarchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
           
        }

    }
}
