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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            var isValid = true;
            string email = tbEmail.Text;
            string pwd = tbPwd.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pwd))
            {
                isValid = false;
                errorMsg += "Enter missing details";
            }
            if (isValid)
            {
                //Check in db if found login
                var meet = new Meetings();
                meet.Show();

            }
            else
            {
                MessageBox.Show(errorMsg);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var signuphere = new Signup();
            signuphere.Show();
        }

        private void lbForgotPwd_Click(object sender, EventArgs e)
        {
            var reset = new ResetPassword();
            reset.Show();
        }
    }
}
