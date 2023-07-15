using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
    public partial class Form1 : Form
    {
        public SendViaEmail Email = new SendViaEmail();
        public SendViaMobile Phone = new SendViaMobile();

        

        //Delegate that takes string as an input, and outputs a string
        public delegate string CollectionDel(string str);

        public string SubsribersOperations(string str, CollectionDel func)
        {
            string answer = func(str);
            return answer;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }
        public void updateNotificationButton(bool val)
        {
            button2.Enabled = val;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
