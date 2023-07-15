using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagementSystem
{
    public class SendViaEmail
    {
        public ArrayList EmailSubscribers = new ArrayList();


        public bool isEmailValid(string MailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(MailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public string AddEmailSubscriber(string str)
        {
            if (isEmailValid(str))
            {
                if (EmailSubscribers.Contains(str))
                {
                    return "Email Already Subscribed Before !!";
                }
                else
                {
                    EmailSubscribers.Add(str);
                    return "Email Subscribed";
                }
            }

            else
            {
                return "Email not valid !!";
            }
            
        }

        public string RemoveEmailSubscriber(string str)
        {
            if (isEmailValid(str))
            {
                if (EmailSubscribers.Contains(str))
                {
                    EmailSubscribers.Remove(str);
                    return "Email Unsubscribed";
                }
                else
                {
                    return "Email is Not Subscribed !!";
                }
            }

            else
            {
                return "Not valid Email !!";
            }
            
        }
    }
}
