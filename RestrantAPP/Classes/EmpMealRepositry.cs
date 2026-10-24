using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class EmpMealRepositry: IRepositry<CLSMeal>
    {
        private List<CLSMeal> LsMeals=new List<CLSMeal>();

        public bool Add(CLSMeal entity)
        {
            //throw new NotImplementedException();
            LsMeals.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var meal = GetById(id);
            if (meal!=null)
            {
                LsMeals.Remove(meal);
                return true;
            }
            return false;

            
        }

        public bool Edit(CLSMeal entity)
        {
            var oldmeal= GetById(entity.MealId);
            if (oldmeal!=null)
            {
                oldmeal.MealName=entity.MealName;
                oldmeal.MealPrice = entity.MealPrice;
                oldmeal.RestrantId = entity.RestrantId;
                return true;
            }
            else
            {
                return false;


            }


        }

        public List<CLSMeal> GetAll()
        {
            return LsMeals;
        }

        public CLSMeal GetById(int id)
        {
            foreach(var meal in LsMeals)
            {
                if(meal.MealId==id)
                {
                    return meal;
                }
            }
                return null;

            

        }
    }
}
