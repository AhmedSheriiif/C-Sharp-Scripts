using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
    public partial class Form2 : Form
    {
        private Form1 ParentForm = null;
        public Form2(Form f)
        {
            ParentForm = f as Form1;
            InitializeComponent();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e) // Subscribe Button
        {
            string email = textBox1.Text;
            string mobile = textBox2.Text;

            if (radioButton1.Checked)
            {
                string result = ParentForm.SubsribersOperations(email, ParentForm.Email.AddEmailSubscriber);
                label1.Text = result;
            }

            else if(radioButton2.Checked)
            {
                string result = ParentForm.SubsribersOperations(mobile, ParentForm.Phone.AddPhoneSubscriber);
                label2.Text = result;
            }

            ParentForm.updateNotificationButton(true);

        }

        private void Button2_Click(object sender, EventArgs e) // Unsubscribe Button
        {
            string email = textBox1.Text;
            string mobile = textBox2.Text;
            if (radioButton1.Checked)
            {
                string result = ParentForm.SubsribersOperations(email, ParentForm.Email.RemoveEmailSubscriber);
                label1.Text = result;
            }

            else if (radioButton2.Checked)
            {
                string result = ParentForm.SubsribersOperations(mobile, ParentForm.Phone.RemovePhoneSubscriber);
                label2.Text = result;
            }

            if (ParentForm.Email.EmailSubscribers.Count == 0 && ParentForm.Phone.PhoneSubscribers.Count == 0)
                ParentForm.updateNotificationButton(false);
           
            
        }
    }
}
