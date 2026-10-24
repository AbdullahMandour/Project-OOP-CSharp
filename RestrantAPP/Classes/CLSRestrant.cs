using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class CLSRestrant : CLSUsers
    {
        private string _logo;
        public string Logo
        {
            get { return _logo; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                {
                    _logo = value;
                }
                else
                {
                    _logo = "Default Logo";
                }
            }
        }
        private string _taxCard;
        public string TaxCard
        {
            get { return _taxCard; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                {
                    _taxCard = value;
                }
                else
                {
                    _taxCard = "Default Tax Card";
                }
            }
        }
        public string Telephone { get; set; } = string.Empty;


        //methods

        //Constractor
        public CLSRestrant(string logo, string taxCard, string telephone,int userid, string username, string email, string password, string phone, string city, string location)
    : base(userid,username, email, password, phone, city, location)
        {
            Logo = logo;
            TaxCard = taxCard;
            Telephone = telephone;
        }
        public void ApproveOrder()
        {
            // Implement approve order logic here
        }

        public void DeliverOrder()
        {
            // Implement deliver order logic here
        }

        public override void ShowOrder()
        {
            // Implement show order logic here
            Console.WriteLine("Show in Restrant");
        }

        public override void DisplayInfo()
        {
            // Implement display info logic
            // 
            base.DisplayInfo();
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Tax Card: {TaxCard}");
            Console.WriteLine($"Telephone: {Telephone}");
            Console.WriteLine("---------------------------\n");
            //Console.WriteLine("Display in Restrant");

        }


    }
}
