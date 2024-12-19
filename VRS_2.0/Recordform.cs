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

namespace VRS_2._0
{
    public partial class Recordform : UserControl
    {
        private DataGridView dgvrecord;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Recordform(DataGridView dgv)
        {
            InitializeComponent();
            this.dgvrecord = dgv;
        }
        public void LoadSelectedRecord()
        {
            if (dgvrecord.CurrentRow == null) return;

            tbstudentID.Text = dgvrecord.CurrentRow.Cells[0].Value.ToString();
            tblastname.Text = dgvrecord.CurrentRow.Cells[1].Value.ToString();
            tbfirstname.Text = dgvrecord.CurrentRow.Cells[2].Value.ToString();
            tbmiddlename.Text = dgvrecord.CurrentRow.Cells[3].Value.ToString();
            tbcontact.Text = dgvrecord.CurrentRow.Cells[4].Value.ToString();
            cbcourse.Text = dgvrecord.CurrentRow.Cells[5].Value.ToString();
            cbyearsection.Text = dgvrecord.CurrentRow.Cells[6].Value.ToString();
            cbviolation.SelectedItem = dgvrecord.CurrentRow.Cells[7].Value.ToString();
            tboffence.Text = dgvrecord.CurrentRow.Cells[8].Value.ToString();
            dtpdate.Text = dgvrecord.CurrentRow.Cells[9].Value.ToString();
            tbpunishment.Text = dgvrecord.CurrentRow.Cells[10].Value.ToString();
            dtpdeadline.Text = dgvrecord.CurrentRow.Cells[11].Value.ToString();
            cbstatus.SelectedItem = dgvrecord.CurrentRow.Cells[12].Value.ToString();
            cbsemester.SelectedItem = dgvrecord.CurrentRow.Cells[13].Value.ToString();

        }
        public DataGridView DgvRecord
        {
            get { return dgvrecord; }
        }
        public void GetUsers()
        {
            try
            {
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT * FROM record", conn);
                conn.Open();
                adapter.Fill(dt);

                if (dgvrecord != null)
                {
                    dgvrecord.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Error: DataGridView is null!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn?.Close();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {          
            if (string.IsNullOrWhiteSpace(tblastname.Text) ||
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
             dtpdate.Value == null ||
             dtpdeadline.Value == null)

            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string query = @"INSERT INTO record (StudentID, Lastname, Firstname, Middlename, Contact, Course, YearSection, Violation, Offence, [Date], Punishment, Deadline, Status, Semester) VALUES " + "(@Sid,@Ln,@Fn,@Mn,@Cn,@C,@Ys,@VL,@O,@D,@P,@Dl,@Sts,@S)";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=useracc.accdb";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to save this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@Sid", tbstudentID.Text);
                        cmd.Parameters.AddWithValue("@Ln", tblastname.Text);
                        cmd.Parameters.AddWithValue("@Fn", tbfirstname.Text);
                        cmd.Parameters.AddWithValue("@Mn", tbmiddlename.Text);
                        cmd.Parameters.AddWithValue("@Cn", tbcontact.Text);
                        cmd.Parameters.AddWithValue("@C", cbcourse.Text);
                        cmd.Parameters.AddWithValue("@Ys", cbyearsection.Text);
                        cmd.Parameters.AddWithValue("@VL", cbviolation.Text);
                        cmd.Parameters.AddWithValue("@O", tboffence.Text);
                        cmd.Parameters.AddWithValue("@D", dtpdate.Value);
                        cmd.Parameters.AddWithValue("@P", tbpunishment.Text);
                        cmd.Parameters.AddWithValue("@Dl", dtpdeadline.Value);
                        cmd.Parameters.AddWithValue("@Sts", cbstatus.Text);
                        cmd.Parameters.AddWithValue("@S", cbsemester.Text);


                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully");

                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show("Database Error" + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                        this.Hide();
                        tbstudentID.Clear();
                        tblastname.Clear();
                        tbfirstname.Clear();
                        tbmiddlename.Clear();
                        tbcontact.Clear();
                        cbcourse.Items.Clear();
                        cbyearsection.Items.Clear();
                        cbviolation.Items.Clear();
                        tboffence.Clear();
                        dtpdate.Value = DateTime.Now;
                        tbpunishment.Clear();
                        dtpdeadline.Value = DateTime.Now;
                        cbstatus.Items.Clear();
                        cbsemester.Items.Clear();

                    }
                    else
                    {
                        return;
                    }
                    
                }
            }
            GetUsers();
        }

        private void Recordform_Load(object sender, EventArgs e)
        {

        }
        //  private void dgvrecords_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    tbstudentID.Text = dgvrecord.CurrentRow.Cells[0].Value.ToString();
        //   tblastname.Text = dgvrecord.CurrentRow.Cells[1].Value.ToString();
        //  tbfirstname.Text = dgvrecord.CurrentRow.Cells[2].Value.ToString();
        //  tbmiddlename.Text = dgvrecord.CurrentRow.Cells[3].Value.ToString();
        //  tbcontact.Text = dgvrecord.CurrentRow.Cells[4].Value.ToString();
        // cbcourse.Text = dgvrecord.CurrentRow.Cells[5].Value.ToString();
        //  cbyearsection.Text = dgvrecord.CurrentRow.Cells[6].Value.ToString();
        //   cbviolation.SelectedItem = dgvrecord.CurrentRow.Cells[7].Value.ToString();
        //    tboffence.Text = dgvrecord.CurrentRow.Cells[8].Value.ToString();
        //    dtpdate.Text = dgvrecord.CurrentRow.Cells[9].Value.ToString();
        //    tbpunishment.Text = dgvrecord.CurrentRow.Cells[10].Value.ToString();
        // dtpdeadline.Text = dgvrecord.CurrentRow.Cells[11].Value.ToString();
        //    cbstatus.SelectedItem = dgvrecord.CurrentRow.Cells[12].Value.ToString();
        //    cbsemester.SelectedItem = dgvrecord.CurrentRow.Cells[13].Value.ToString();
        //  }


    }

}
