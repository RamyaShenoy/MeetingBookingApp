using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingBookingApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            var isValid = true;
                string email = tbEmail.Text;
                string pwd = tbPwd.Text;
                if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pwd))
                {
                    isValid = false;
                    errorMsg += "Enter missing details";
                }
                if(isValid)
                {
                //Add details into db
                MessageBox.Show($"Signup Successful \n Go back to Login.");
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loginhere = new Login();
            loginhere.Show();
        }
    }
}
