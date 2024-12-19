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
    
    public partial class Login : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        private int loginAttempts = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void tbemail_Enter(object sender, EventArgs e)
        {
            if (tbemail.Text == "Email")
            {
                tbemail.Text = "";
                tbemail.ForeColor = Color.Black;
            }
        }

        private void tbemail_Leave(object sender, EventArgs e)
        {
            if (tbemail.Text == "")
            {
                tbemail.Text = "Email";
                tbemail.ForeColor = Color.Silver;
            }
        }

        private void tbpass_Enter(object sender, EventArgs e)
        {
            if (tbpass.Text == "Password")
            {
                tbpass.Text = "";
                tbpass.ForeColor = Color.Black;
            }
        }

        private void tbpass_Leave(object sender, EventArgs e)
        {
            if (tbpass.Text == "")
            {
                tbpass.Text = "Password";
                tbpass.ForeColor = Color.Silver;
            }
        }
        private string loggedInEmail;
        private string profilePicturePath;
        private void btnlog_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=useracc.accdb");
            // Modify query to also get ProfilePicture path
            string query = "SELECT [FirstName], [LastName], [Photo], [Type] FROM [user] WHERE Email = @Email AND [Password] = @Password";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", tbemail.Text);
            cmd.Parameters.AddWithValue("@password", tbpass.Text);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Capture the logged-in email and profile picture path
                    loggedInEmail = tbemail.Text;
                    profilePicturePath = reader["Photo"].ToString(); // Assuming this column contains the profile picture path or filename
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    byte[] photoData = reader["Photo"] as byte[];

                    // Pass the user information to the main form
                    Form1 mainForm = new Form1(loggedInEmail, profilePicturePath, firstName, lastName, photoData);

                    string userType = reader["Type"].ToString();
                    this.Hide();

                    if (userType == "Admin")
                    {
                        string loggedInEmail = tbemail.Text;
                        string profilePicPath = "Photo";
                        Form1 form2 = new Form1(loggedInEmail, profilePicturePath, firstName, lastName, photoData);
                        form2.Show();
                    }
                    else if (userType == "Staff")
                    {
                        string loggedInEmail = tbemail.Text;
                        string profilePicPath = "Photo";
                        StaffInterface form3 = new StaffInterface(loggedInEmail, profilePicturePath, firstName, lastName, photoData);
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user type.");
                        this.Show();
                    }
                }
                else
                {
                    loginAttempts++;
                    MessageBox.Show("Invalid email or password.");

                    if (loginAttempts >= 3)
                    {
                        Application.Exit();
                    }
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

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            forgotpass forgotPasswordForm = new forgotpass();
            forgotPasswordForm.Show();
        }

        private void pbshow_Click(object sender, EventArgs e)
        {
            if (tbpass.PasswordChar == '*')
            {
                tbpass.PasswordChar = '\0';
            }
            pbshow.Hide();
            pbhide.Show();
        }

        private void pbhide_Click(object sender, EventArgs e)
        {
            if (tbpass.PasswordChar == '\0')
            {
                tbpass.PasswordChar = '*';
            }
            pbhide.Hide();
            pbshow.Show();
        }

        private void pbshow_Click_1(object sender, EventArgs e)
        {
            if (tbpass.PasswordChar == '*')
            {
                tbpass.PasswordChar = '\0';
            }
            pbshow.Hide();
            pbhide.Show();
        }
    }
}