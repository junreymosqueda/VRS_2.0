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
    public partial class ressetpass : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        private string email;
        public ressetpass(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = tbnewpass.Text;
                string confirmPassword = tbconfirmpass.Text; 
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=useracc.accdb");
                string query = "UPDATE [user] SET [Password] = @Password WHERE Email = @Email";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password has been updated successfully.");
                    // Redirect to login form or close
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
               
            }
        }

        private void pbshow_Click(object sender, EventArgs e)
        {
            if (tbconfirmpass.PasswordChar == '*')
            {
                tbconfirmpass.PasswordChar = '\0';
            }
            pbshow.Hide();
            pbhide.Show();
        }

        private void pbhide_Click(object sender, EventArgs e)
        {
            if (tbconfirmpass.PasswordChar == '\0')
            {
                tbconfirmpass.PasswordChar = '*';
            }
            pbshow.Show();
            pbhide.Hide();
        }

        private void pbshow1_Click(object sender, EventArgs e)
        {
            if (tbnewpass.PasswordChar == '*')
            {
                tbnewpass.PasswordChar = '\0';
            }
            pbshow1.Hide();
            pbhide1.Show();
        }

        private void pbhide1_Click(object sender, EventArgs e)
        {
            if (tbnewpass.PasswordChar == '\0')
            {
                tbnewpass.PasswordChar = '*';
            }
            pbshow1.Show();
            pbhide1.Hide();
        }
    }
}
