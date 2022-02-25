
namespace MeetingBookingApp
{
    partial class Meetings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtSlot = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click here to Search Meeting";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book a new Meeting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emp ID";
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(81, 138);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(203, 20);
            this.tbEmpID.TabIndex = 3;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(81, 171);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(203, 20);
            this.tbFName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(81, 209);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(203, 20);
            this.tbLName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.Location = new System.Drawing.Point(81, 248);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(203, 20);
            this.tbRoomNo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(0, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Room Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(10, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Slot Timings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Book Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtSlot
            // 
            this.dtSlot.Location = new System.Drawing.Point(81, 287);
            this.dtSlot.Name = "dtSlot";
            this.dtSlot.Size = new System.Drawing.Size(200, 20);
            this.dtSlot.TabIndex = 13;
            // 
            // Meetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtSlot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRoomNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Meetings";
            this.Text = "Meetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtSlot;
    }
}