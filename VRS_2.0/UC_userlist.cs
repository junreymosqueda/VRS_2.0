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
using System.Drawing.Imaging;

namespace VRS_2._0
{
    public partial class UC_userlist : UserControl
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        private bool isImageUploaded = false;
     
        private bool isCreatingNewUser = true;
        public UC_userlist()
        {
            InitializeComponent();
            dgvuser.RowTemplate.Height = 50;
            dgvuser.Font = new Font("Arial", 13);
            
            GetUsers();

        }
        void GetUsers()
        {
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM [user] WHERE IsDeleted = 0", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvuser.DataSource = dt;
            conn.Close();
            dgvuser.Columns["IsDeleted"].Visible = false;
            dgvuser.Columns["Type"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetUsers();
            dgvuser.Columns["Photo"].Visible = false;
        }
        private void btncreat_Click(object sender, EventArgs e)
        {
            panel1.Show();
            btncreate.Show();
            tbfirst.Clear();
            tblast.Clear();
            tbemail.Clear();
            tbpass.Clear();
            update.Hide();
            pb.Image = null;
            if (panel1.Visible)
            {
                btncreat.Enabled = false;
                btndelete.Enabled = false;
                guna2Button2.Enabled = false;
            }
            else
            {
               
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbfirst.Text) ||
        string.IsNullOrWhiteSpace(tblast.Text) ||
        string.IsNullOrWhiteSpace(tbemail.Text) ||
        string.IsNullOrWhiteSpace(tbpass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (isCreatingNewUser)
            {
                string insertQuery = "INSERT INTO [user] ([Firstname], Lastname, Email, [Password], Photo, Type) VALUES " +
                                     "(@fn, @ln, @u, @p, @i, 'Staff')";
                cmd = new OleDbCommand(insertQuery, conn);

                DialogResult result = MessageBox.Show("Are you sure you want to Create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@fn", tbfirst.Text);
                    cmd.Parameters.AddWithValue("@ln", tblast.Text);
                    cmd.Parameters.AddWithValue("@u", tbemail.Text);
                    cmd.Parameters.AddWithValue("@p", tbpass.Text);

                    if (isImageUploaded && pb.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pb.Image.Save(ms, pb.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@pb", ms.ToArray());
                        }
                    }


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Inserted Successfully");
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

            GetUsers();
            panel1.Hide();
            tbfirst.Clear();
            tblast.Clear();
            tbemail.Clear();
            tbpass.Clear();
            pb.Image = null;
            btncreat.Enabled = true;
            btndelete.Enabled = true;
            guna2Button2.Enabled = true;
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Image Files|*.jpg;*.jfif;*.jpeg;*.png;*.bmp";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pb.Image = new Bitmap(openFileDialog.FileName);


                isImageUploaded = true;

            }
        }

        private void tbncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panel1.Hide();
                panel1.Hide();
                tbfirst.Clear();
                tblast.Clear();
                tbemail.Clear();
                tbpass.Clear();
                pb.Image = null;
            }
            else
            {
                return;
            }
            btncreat.Enabled = true;
            btndelete.Enabled = true;
            guna2Button2.Enabled = true;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Delete this Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(tbfirst.Text))
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                string query = "UPDATE [user] SET IsDeleted = 1 WHERE Firstname = @d";

                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@d", tbfirst.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record successfully deleted!");
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
                return;
            }
        }

        private void dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvuser.Rows[e.RowIndex];
                tbfirst.Text = row.Cells["Firstname"].Value?.ToString();
                tblast.Text = row.Cells["Lastname"].Value?.ToString();
                tbemail.Text = row.Cells["Email"].Value?.ToString();
                tbpass.Text = row.Cells["Password"].Value?.ToString();

                if (row.Cells["Photo"].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])row.Cells["Photo"].Value;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        pb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb.Image = null;
                }
            }
        }

        private void btnarchive_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            update.Show();
            btncreate.Hide();
            if (panel1.Visible)
            {
                btncreat.Enabled = false;
                btndelete.Enabled = false;
                guna2Button2.Enabled = false;
            }
            else
            {

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbfirst.Text) ||
    string.IsNullOrWhiteSpace(tblast.Text) ||
    string.IsNullOrWhiteSpace(tbemail.Text) ||
    string.IsNullOrWhiteSpace(tbpass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string[] userTypes = { "Staff", "Admin" }; // List of types
            string placeholders = string.Join(", ", userTypes.Select((_, i) => $"@t{i}")); // Create @t0, @t1, etc.

            string query = isImageUploaded
                ? $"UPDATE [user] SET Firstname=@fn, Lastname=@ln, Email=@u, [Password]=@p, Photo=@i WHERE Type IN ({placeholders}) AND Firstname=@fn"
                : $"UPDATE [user] SET Firstname=@fn, Lastname=@ln, Email=@u, [Password]=@p WHERE Type IN ({placeholders}) AND Firstname=@fn";

            try
            {
                conn.Open(); // Open the connection here

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // Add parameters for query
                    cmd.Parameters.AddWithValue("@fn", tbfirst.Text.Trim());
                    cmd.Parameters.AddWithValue("@ln", tblast.Text.Trim());
                    cmd.Parameters.AddWithValue("@u", tbemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", tbpass.Text.Trim());

                    // Add image parameter if needed
                    if (isImageUploaded && pb.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            using (var clone = new Bitmap(pb.Image))
                            {
                                clone.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Use a standard image format
                                cmd.Parameters.AddWithValue("@i", ms.ToArray());
                            }
                        }
                    }
                    else if (isImageUploaded)
                    {
                        MessageBox.Show("Please upload a valid image.");
                        return;
                    }

                    // Add user type parameters dynamically
                    for (int i = 0; i < userTypes.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@t{i}", userTypes[i]);
                    }

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Show success or failure message
                    MessageBox.Show(rowsAffected > 0 ? "User updated successfully!" : "No user found with the specified criteria.");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Ensure the connection is always closed
            }

            panel1.Hide();
            tbfirst.Clear();
            tblast.Clear();
            tbemail.Clear();
            tbpass.Clear();
            pb.Image = null;
            GetUsers();
            panel1.Hide();
            btncreat.Enabled = true;
            btndelete.Enabled = true;
            guna2Button2.Enabled = true;

        }

    }
}



  