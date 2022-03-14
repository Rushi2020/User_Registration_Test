using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration_Test
{
    public class UserRegPattern
    {
        public static string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string Email = "^[a-z]{2,}[0-9]{2,}[@][a-z]{2,}[.][a-z]{1,4}$";
        public static string MobileNo = "^+91[5-9]{1}[0-9]{9}$";
        public static string Password = "^[A-Z][@#$%&*]{1}[1-9a-zA-Z]{1}[a-zA-Z0-9]{7,}$";
        public static string Email2 = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";


        public Func<string, string> LValidateFirstName = data => Regex.IsMatch(data, FirstName) ? "valid firstName" : throw new CustomException(CustomException.ExceptionType.INVALID_FIRSTNAME, "invalid firstName");
        public Func<string, string> LValidateLastName = data => Regex.IsMatch(data, LastName) ? "valid lastName" : throw new CustomException(CustomException.ExceptionType.INVALID_LASTNAME, "invalid lastName");
        public Func<string, string> LValidateEmail = data => Regex.IsMatch(data, Email) ? "valid email" : throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "invalid email");
        public Func<string, string> LValidateMobileNo = data => Regex.IsMatch(data, MobileNo) ? "valid mobileNo" : throw new CustomException(CustomException.ExceptionType.INVALID_MOBILE_NO, "invalid mobileNo");
        public Func<string, string> LValidatePassword = data => Regex.IsMatch(data, Password) ? "valid password" : throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "invalid password");







        public bool ValidateFirstName(string data)
        {     //first name validation
                bool result = Regex.IsMatch(data, FirstName) ? true : false;
                return result;
        }

        public bool ValidateLastName(string data)
        {
            //last name validation
                bool result = Regex.IsMatch(data, LastName) ? true : false;
                return result;
        }

        public bool ValidateEmail(string data)
        {   //Email validation
                bool result = Regex.IsMatch(data, Email) ? true : false;
                return result;
        }

        public bool ValidateMobileNo(string data)
        {
            //mobile number validation
                bool result = Regex.IsMatch(data, MobileNo) ? true : false;
                return result;
        }

        public bool ValidatePassword(string data)
        {
            //password validation
                bool result = Regex.IsMatch(data, Password) ? true : false;
                return result;
        }

    }
}