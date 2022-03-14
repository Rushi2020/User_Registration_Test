using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Test
{
    public class CheckRegistration
    {
        private string message;

        public CheckRegistration(string message)
        {
            this.message = message;
        }

        //First name entry
        public string check_Firstname()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        //last name entry
        public string check_Lastname()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        //Email entry
        public string check_Email()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        //phoneno entry
        public string check_phoneno()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        //password entry
        public string check_Password()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public string check_MultipleEntries_Email(string email1, string email2, string email3, string email4)
        {
            UserRegPattern userRegPattern = new UserRegPattern();
            bool emailForEntry1 = userRegPattern.ValidateEmail(email1);
            bool emailForEntry2 = userRegPattern.ValidateEmail(email2);
            bool emailForEntry3 = userRegPattern.ValidateEmail(email3);
            bool emailForEntry4 = userRegPattern.ValidateEmail(email4);
            if (emailForEntry1 && emailForEntry2 && emailForEntry3 && emailForEntry4)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
    }
}
