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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empID = tbEmpID.Text;
            var isValid = true;
            string errorMsg = "";
            if (string.IsNullOrWhiteSpace(empID))
            {
                isValid = false;
                errorMsg += "Enter missing details";
            }
            if (isValid)
            {
                //display table where empid matched

            }
            else
            {
                MessageBox.Show(errorMsg);
            }
        }
    }
    }

