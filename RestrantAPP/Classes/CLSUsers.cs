using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public abstract class CLSUsers
    {
        #region Propretes
        public int UserId { get; set; }
        private string _userName;
        public string UserName
        {
            get { return _userName; }

            set
            {
                if(ValidationHelper.IsValidName(value))
                {
                    _userName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid user name.");
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }

            set
            {
                if(ValidationHelper.IsValidEmail(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email format.");
                }
            }
        }

       private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (ValidationHelper.IsValidPassword(value))
                {
                   _password = value;
                }
                else
                {
                    throw new ArgumentException("Invalid password format. ");
                }
            }
        }

       private string _phone;
        public string Phone
            {
            get { return _phone; }
            set
            {
                if (ValidationHelper.IsValidPhone(value))
                {
                    _phone = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number format.");
                }
            }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                    _city = value;
                else
                    throw new ArgumentException("Invalid City Name.");
            }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                    _location = value;
                else
                    _location = "Unknown_Location";
            }
        }
        #endregion

        #region Mithdes
       
      
        public CLSUsers(int userid,string username, string email, string password,string phone,string city,string location)
        {
            UserId = userid;
            UserName = username;
            Email = email;
            Password = password;
            Phone = phone;
            City = city;
            Location = location;

        }

        public bool Login(string email, string password)
        {
            // Implement login logic here

            return Email==email&& Password==password;//Copilot

        }


        public abstract void ShowOrder();
       
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"User ID: {UserId}");
            Console.WriteLine($"User Name: {UserName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Location: {Location}");
        } 
        #endregion
    }
}
