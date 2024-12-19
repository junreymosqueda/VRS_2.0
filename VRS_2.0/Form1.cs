using Guna.UI2.WinForms.Suite;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace VRS_2._0
{
    public partial class Form1 : Form
    {
        private string loggedInEmail;
        private string profilePicturePath;
        private string firstName;
        private string lastName;
        private byte[] photoData;

        public Form1(string email, string picturePath, string firstName, string lastName, byte[] photoData)
        {
            InitializeComponent();
            loggedInEmail = email;
            profilePicturePath = picturePath;
            this.firstName = firstName;
            this.lastName = lastName;
            this.photoData = photoData;
            LoadUserDetails();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UC_profilepage uC_Profilepage = new UC_profilepage(loggedInEmail, profilePicturePath);           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_home uC_Home = new UC_home();
            panel2.Controls.Clear();
            panel2.Controls.Add(uC_Home);
            btnhome.BackColor = Color.FromArgb(80, 141, 78);
            btnrecord.BackColor = Color.FromArgb(35, 83, 38);
            btnrule.BackColor = Color.FromArgb(35, 83, 38);
            btnuserlist.BackColor = Color.FromArgb(35, 83, 38);
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_record uC_Record = new UC_record();
            panel2.Controls.Clear();
            uC_Record.Dock = DockStyle.Fill;
            panel2.Controls.Add(uC_Record);
            btnrecord.BackColor = Color.FromArgb(80, 141, 78);
            btnhome.BackColor = Color.FromArgb(35, 83, 38);
            btnrule.BackColor = Color.FromArgb(35, 83, 38);
            btnuserlist.BackColor = Color.FromArgb(35, 83, 38);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_rules uC_Rules = new UC_rules();
            panel2.Controls.Clear();
            uC_Rules.Dock = DockStyle.Fill;
            panel2.Controls.Add(uC_Rules);
            btnrule.BackColor = Color.FromArgb(80, 141, 78);
            btnhome.BackColor = Color.FromArgb(35, 83, 38);
            btnrecord.BackColor = Color.FromArgb(35, 83, 38);
            btnuserlist.BackColor = Color.FromArgb(35, 83, 38);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_userlist uC_Userlist = new UC_userlist();
            panel2.Controls.Clear();
            uC_Userlist.Dock = DockStyle.Fill;
            panel2.Controls.Add(uC_Userlist);
            btnuserlist.BackColor = Color.FromArgb(80, 141, 78);
            btnrule.BackColor = Color.FromArgb(35, 83, 38);
            btnhome.BackColor = Color.FromArgb(35, 83, 38);
            btnrecord.BackColor = Color.FromArgb(35, 83, 38);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
 
        }

        private void uC_Profile_MouseLeave(object sender, EventArgs e)
        {

        }       
        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void uC_home1_Load(object sender, EventArgs e)
        {

        }

        private void btneditpro_Click(object sender, EventArgs e)
        {
            UC_profilepage uC_Profilepage = new UC_profilepage(loggedInEmail, profilePicturePath);
            panel2.Controls.Clear();
            panel2.Controls.Add(uC_Profilepage);
            uC_Profilepage.BringToFront();

        }
        private bool isToggled = false;
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (isToggled)
            {
                panel2.Controls.Add(panel3);
                panel3.Show();
                panel3.BringToFront();
                btnname.BackColor = Color.FromArgb(80, 141, 78);
                btnuserlist.BackColor = Color.FromArgb(35, 83, 38);
                btnrule.BackColor = Color.FromArgb(35, 83, 38);
                btnhome.BackColor = Color.FromArgb(35, 83, 38);
                btnrecord.BackColor = Color.FromArgb(35, 83, 38);
            }
            else
            {
                panel3.Hide();
            }
            isToggled = !isToggled;
            LoadUserDetails();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            panel2.Controls.Add(panel4);
            panel4.Show();
            panel4.BringToFront();
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void btnarchive_Click(object sender, EventArgs e)
        {
            Archive archiveForm = new Archive();
            archiveForm.Show();
            panel3.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadUserDetails()
        {
            // Set full name on the button
            btnname.Text = $"{firstName} {lastName}";

            // Set profile picture in the PictureBox
            if (photoData != null)
            {
                using (MemoryStream ms = new MemoryStream(photoData))
                {
                    pbprofile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbprofile.Image = Properties.Resources.vrs_removebg_preview;
            }
        }

        private void pbprofile_Click(object sender, EventArgs e)
        {
            LoadUserDetails();
        }
    }
}
