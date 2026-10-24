using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class ValidationHelper
    {
       
            public static bool IsValidName(string name)
            {
                if(string.IsNullOrWhiteSpace(name))
                {
                    return false;
                }
                return true;
            }


            public static bool IsValidEmail(string email)
            {
                if(string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

            public static bool IsValidPhone(string phone)
            {
                if(string.IsNullOrWhiteSpace(phone))return false;
            return phone.Length == 11 && phone.StartsWith("01") && phone.All(char.IsDigit);
        }


            public static bool IsValidPassword(string password)
            {
                if(string.IsNullOrWhiteSpace(password))return false;
                return password.Length >= 8;
            }

            public static bool IsValidPrice(decimal price)
            {
                return price > 0;
            }

            public static bool IsValidString(string text)
            {
                               return !string.IsNullOrWhiteSpace(text);
            }
        }

    }

