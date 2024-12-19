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
using System.IO;
using System.Drawing.Imaging;
namespace VRS_2._0
{
    public partial class UC_staffprofile : UserControl
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        private string loggedInEmail;
        private string profilePicturePath;
        public UC_staffprofile(string email, string picturePath)
        {
            InitializeComponent();
            loggedInEmail = email;
            profilePicturePath = picturePath;
            LoadUserData(loggedInEmail, profilePicturePath);
        }
        private void LoadUserData(string email, string picturePath)
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                string query = "SELECT FirstName, LastName, Email, Password, Photo FROM [user] WHERE Email = @Email";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate the TextBox fields with the data from the database.
                    tbfirst.Text = reader["FirstName"].ToString();
                    tblast.Text = reader["LastName"].ToString();
                    tbstaffemail.Text = reader["Email"].ToString();
                    tbstaffpassword.Text = reader["Password"].ToString();
                    byte[] photoData = reader["Photo"] as byte[];
                    if (photoData != null)
                    {
                        // Convert the byte array into an image and set it to the picture box
                        using (MemoryStream ms = new MemoryStream(photoData))
                        {
                            pbstaff.Image = Image.FromStream(ms);
                        }
                    }
                    // Disable fields initially.
                    tbfirst.Enabled = false;
                    tblast.Enabled = false;
                    tbstaffemail.Enabled = false;
                    tbstaffpassword.Enabled = false;
                }
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
        private void btnstaffedit_Click(object sender, EventArgs e)
        {
            btnstaffcancel.Visible = true;
            btnstaffupdate.Visible = true;
            btnstaffupload.Visible = true;
            tbfirst.Enabled = true;
            tblast.Enabled = true;
            tbstaffemail.Enabled = true;
            tbstaffpassword.Enabled = true;
            btnstaffedit.Visible = false;   
        }

        private void btnstaffcancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                btnstaffcancel.Visible = false;
                btnstaffupdate.Visible = false;
                btnstaffupload.Visible = false;
                tbfirst.Enabled = false;
                tblast.Enabled = false;
                tbstaffemail.Enabled = false;
                tbstaffpassword.Enabled = false;
                btnstaffedit.Visible = true;
                tblast.Clear();
                tbstaffemail.Clear();
                tbstaffpassword.Clear();
            }
            else
            {
                return;
            }
        }

        private void btnstaffupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update your profile?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Debug email
                    MessageBox.Show("Updating record for email: " + tbstaffemail.Text);

                    // Get the updated data from the text boxes
                    string firstName = tbfirst.Text;
                    string lastName = tblast.Text;
                    string email = tbstaffemail.Text;
                    string password = tbstaffpassword.Text;

                    // Optionally handle profile picture update
                    byte[] photoData = null;
                    if (pbstaff.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Image clonedImage = (Image)pbstaff.Image.Clone();
                            clonedImage.Save(ms, pbstaff.Image.RawFormat);
                            photoData = ms.ToArray();
                        }
                    }

                    // Debug values to be updated
                    MessageBox.Show($"Updating profile: {firstName}, {lastName}, {email}, {password}, Photo: {(photoData != null ? "Updated" : "No change")}");

                    // Update the user data in the database
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
                    string query = "UPDATE [user] SET FirstName = @FirstName, LastName = @LastName, [Password] = @Password, Photo = @Photo WHERE Email = @Email";
                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    if (photoData != null)
                    {
                        cmd.Parameters.AddWithValue("@Photo", photoData);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value); // Set photo to NULL if no change
                    }

                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update query

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.");
                        btnstaffupdate.Visible = false;
                        btnstaffupload.Visible = false;
                        btnstaffcancel.Visible = false;
                        tbfirst.Enabled = false;
                        tblast.Enabled = false;
                        tbstaffemail.Enabled = false;
                        tbstaffpassword.Enabled = false;
                        btnstaffedit.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No changes were made. Please modify at least one field.");
                    }
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

        private void btnstaffupload_Click(object sender, EventArgs e)
        {
            //lagay mo yung code dito para sa staff Upload button.|
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Specify accepted image formats
            openFileDialog.Title = "Select a Profile Picture";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    string selectedFilePath = openFileDialog.FileName;
                    pbstaff.Image = Image.FromFile(selectedFilePath);

                    // Optionally, you can store the image path or byte array
                    // In this case, we'll store the path for now
                    profilePicturePath = selectedFilePath;

                    // Optionally, update the status (for example, display the selected image file name)
                    pbstaff.Text = "Selected: " + Path.GetFileName(selectedFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
