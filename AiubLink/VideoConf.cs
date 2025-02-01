using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMeetApp
{
    public partial class VideoConf : Form
    {
        private Form previousForm;
        private string role;
        public VideoConf(Form previousForm, string role)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.role = role;
        }

        private void VideoConf_Load(object sender, EventArgs e)
        {
            if(role == "Student")
            {
                panel1.Visible = false;
            }
          
            else
            {
                panel1.Visible = true;
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {

            string meetLink = txtMeetLink.Text.Trim();

            if (!string.IsNullOrEmpty(meetLink))
            {
                // Open Google Meet link in the default browser
                Process.Start(new ProcessStartInfo(meetLink) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Please enter a valid Google Meet link.");
            }
        }

       
        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string meetLink = "https://meet.google.com/landing";
            Process.Start(new ProcessStartInfo(meetLink) { UseShellExecute = true });
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
