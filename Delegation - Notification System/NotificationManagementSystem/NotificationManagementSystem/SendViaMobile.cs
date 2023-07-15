using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NotificationManagementSystem
{
    public class SendViaMobile
    {
        public ArrayList PhoneSubscribers = new ArrayList();

        public bool isMobileValid(string MobileNumber)
        {
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
            if (regex.IsMatch(MobileNumber))
            {
                return true;
            }
            else
                return false;
        }

        public string AddPhoneSubscriber(string str)
        {
            if (isMobileValid(str))
            {
                if (PhoneSubscribers.Contains(str))
                {
                    return "Phone Already Subscribed Before !!";
                }
                else
                {
                    PhoneSubscribers.Add(str);
                    return "Phone Subscribed";
                }
            }
            else
                return "Invalid Phone Number Format:(xxx-xxx-xxxx)";
        }

        public string RemovePhoneSubscriber(string str)
        {
            if (isMobileValid(str))
            {
                if (PhoneSubscribers.Contains(str))
                {
                    PhoneSubscribers.Remove(str);
                    return "Phone Unsubscribed";
                }
                else
                {
                    return "Phone is Not Subscribed !!";
                }
            }
            else
                return "Invalid Phone Number Format:(xxx-xxx-xxxx)";
            
        }
    }
}
