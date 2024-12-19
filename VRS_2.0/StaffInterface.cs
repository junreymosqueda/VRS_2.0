using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VRS_2._0
{
    public partial class StaffInterface : Form
    {
        private string loggedInEmail;
        private string profilePicturePath;
        private string firstName;
        private string lastName;
        private byte[] photoData;
        public StaffInterface(string email, string picturePath, string firstName, string lastName, byte[] photoData)
        {
            InitializeComponent();
            loggedInEmail = email;
            profilePicturePath = picturePath;
            this.firstName = firstName;
            this.lastName = lastName;
            this.photoData = photoData;
            LoadUserDetails();
        }

        private void btnstaffrecord_Click(object sender, EventArgs e)
        {

        }

        private void btnstaffrecord_Click_1(object sender, EventArgs e)
        {
            UC_Staffrecord uC_Staffrecord = new UC_Staffrecord();
            panel6.Controls.Clear();
            uC_Staffrecord.Dock = DockStyle.Fill;
            panel6.Controls.Add(uC_Staffrecord);
        }

        private void btnstaffhome_Click(object sender, EventArgs e)
        {
           UC_home uC_Home = new UC_home();
           panel6.Controls.Clear();
           uC_Home.Dock = DockStyle.Fill;  
           panel6.Controls.Add(uC_Home);   
        }

        private void btnstaffrules_Click(object sender, EventArgs e)
        {
           Staffrules staffrules = new Staffrules();
           panel6.Controls.Clear();
           staffrules.Dock = DockStyle.Fill;
           panel6.Controls.Add(staffrules);
        }

        private bool isToggled = false;
        private void btnstaffprofile_Click(object sender, EventArgs e)
        {
            if (isToggled)
            {
                panel6.Controls.Add(panel7);
                panel7.Show();
                panel7.BringToFront();
            }
            else
            {
                panel7.Hide();
            }
            isToggled = !isToggled;
        }

        private void btnstafflogout_Click(object sender, EventArgs e)
        {
            panel6.Controls.Add(panel8);
            panel8.Show();
            panel8.BringToFront();
        }

        private void btnstaffno_Click(object sender, EventArgs e)
        {
            panel8.Hide();
        }

        private void btnstaffyes_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnstaffedit_Click(object sender, EventArgs e)
        {
            UC_staffprofile profile = new UC_staffprofile(loggedInEmail, profilePicturePath);
            panel6.Controls.Clear();
            panel6.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.BringToFront();

        }
        private void LoadUserDetails()
        {
            // Set full name on the button
            btnstaffprofile.Text = $"{firstName} {lastName}";

            // Set profile picture in the PictureBox
            if (photoData != null)
            {
                using (MemoryStream ms = new MemoryStream(photoData))
                {
                    pbstaffprofile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbstaffprofile.Image = Properties.Resources.vrs_removebg_preview;
            }
        }
    }
}
