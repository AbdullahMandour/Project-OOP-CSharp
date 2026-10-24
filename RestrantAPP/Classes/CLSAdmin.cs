using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class CLSAdmin:CLSUsers
    {
        private string _jobName;
        public string JobName
        {
            get { return _jobName; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                    _jobName = value;
                else
                    _jobName = "General_Admin";
            }
        }


        //methods

        //Constractore
        public CLSAdmin(string jobName, int id, string username, string email, string password, string phone, string city, string location)
    : base(id, username, email, password, phone, city, location)
        {
            JobName = jobName;
        }


        public override void ShowOrder()
        {
            // Implement show order logic here
            Console.WriteLine("Show in Admin");
        }

        public override void DisplayInfo()
        {
            // Implement display info logic here
            //Console.WriteLine("Display in Admin");
            base.DisplayInfo();
            Console.WriteLine($"Job Name: {JobName}"); // بتطبع وظيفة الأدمن
            Console.WriteLine("-------------------------");
        }

        public void CancelOredr()
        {
            // Implement cancel order logic here
        }

        public void ContactUser()
        {
            // Implement contact user logic here
        }

       
    }
}
