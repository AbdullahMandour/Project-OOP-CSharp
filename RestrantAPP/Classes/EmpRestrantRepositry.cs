using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class EmpRestrantRepositry : IRepositry<CLSRestrant>
    {
        private List<CLSRestrant> restrantlist = new List<CLSRestrant>();
        public bool Add(CLSRestrant entity)
        {
            //throw new NotImplementedException();
            restrantlist.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            //throw new NotImplementedException();
            var restrant = GetById(id);
            if (restrant != null)
            {
                restrantlist.Remove(restrant);
                return true;

            }
            return false;


        }

        public bool Edit(CLSRestrant entity)
        {
            //throw new NotImplementedException();
            var oldRestrant = GetById(entity.UserId);
            if (oldRestrant != null)
            {
                int index = restrantlist.IndexOf(oldRestrant);
                restrantlist[index] = entity;
                return true;
            }
            return false;
        }

        public List<CLSRestrant> GetAll()
        {
            //throw new NotImplementedException();
            return restrantlist;
        }

        public CLSRestrant GetById(int id)
        {
            foreach(var restrant in restrantlist)
            {
                if(restrant.UserId == id)
                {
                    return restrant;
                }
            }
            return null;
        }
    

     //Mithod el Change 
     
    }
}
