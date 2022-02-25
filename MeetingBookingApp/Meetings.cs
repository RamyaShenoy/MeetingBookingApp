﻿using System;
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
    public partial class Meetings : Form
    {
        public Meetings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var searchMeet = new Search();
            searchMeet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empID = tbEmpID.Text;
            string fName = tbFName.Text;
            string lName = tbLName.Text;
            string roomNo = tbRoomNo.Text;
            var slot = dtSlot.Value;
            var isValid = true;
            string errorMsg="";
            if(string.IsNullOrWhiteSpace(empID)||string.IsNullOrWhiteSpace(fName)||string.IsNullOrWhiteSpace(lName)||string.IsNullOrWhiteSpace(roomNo)||string.IsNullOrWhiteSpace(dtSlot.Text))
            {
                isValid = false;
                errorMsg += "Enter missing details";
            }
            if (isValid)
            {
                MessageBox.Show($"Meeting is Booked");
            }
            else
            {
                MessageBox.Show(errorMsg);
            }
        }
    }
}
