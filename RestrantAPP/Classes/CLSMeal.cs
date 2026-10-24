using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class CLSMeal
    {
        public int MealId { get; set; }

        private string _mealName;
        public string MealName
        {
            get { return _mealName; }
            set
            {
                if(ValidationHelper.IsValidString(value))
                {
                    _mealName = value;
                }
                else
                {
                    _mealName = "Default Meal Name";
                }
            }
        }
        private decimal _mealPrice;
        public decimal MealPrice
        {
            get { return _mealPrice; }

            set
            {
                if(ValidationHelper.IsValidPrice(value))
                {
                    _mealPrice = value;
                }
                else
                {
                    _mealPrice = 1;
                }
            }
        }
        public int RestrantId { get; set; }
        //Constructor
        public CLSMeal(int mealId, string mealName, decimal mealPrice, int restrantId)
        {
            MealId = mealId;
            MealName = mealName;
            MealPrice = mealPrice;
            RestrantId = restrantId;
        }

       
    }
}
