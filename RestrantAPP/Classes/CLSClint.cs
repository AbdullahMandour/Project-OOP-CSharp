using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class CLSClint:CLSUsers
    {
        public int FlatNumber { get; set; }

        public int FloorNumber { get; set; }    
        public string SecondePhone { get; set; } = string.Empty;

        private string _deliveryLocation;
        public string DelivaryLocation
        {
            get { return _deliveryLocation; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                    _deliveryLocation = value;
                else
                    _deliveryLocation = "Location_Not_Set";
            }
        }

        //Constractor
        public CLSClint(int flatnumber, int floornumber, string secondnumber, string delivaryLocation,int userid, string username, string email, string password, string phone, string city, string location) :base(userid,username, email, password,phone,city,location)
        {
            FlatNumber = flatnumber;
            FloorNumber = floornumber;
            SecondePhone = secondnumber;
            DelivaryLocation = delivaryLocation;

        }


        //methods
        public void SendOrder()
        {
            // Implement send order logic here
        }

        public void RecieveOrder()
        {
            // Implement receive order logic here
        }

        public override void ShowOrder()
        {
            // Implement show order logic here
            Console.WriteLine("order Clint");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Flat Number: {FlatNumber}");
            Console.WriteLine($"Floor Number: {FloorNumber}");
            Console.WriteLine($"Second Phone: {SecondePhone}");
            Console.WriteLine($"Delivery Location: {DelivaryLocation}");
            //عاوز انادي الديسبلاي اللي هناك + اللي هنا

        }

       
    }
}
