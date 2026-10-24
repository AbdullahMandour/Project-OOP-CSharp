using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class EmpClintRepositry : IRepositry<CLSClint>
    {

        //List to store
       private List<CLSClint>DatatClints= new List<CLSClint>();
        public bool Add(CLSClint entity)
        {
            //throw new NotImplementedException();
            DatatClints.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            //throw new NotImplementedException();
            var Clint=GetById(id);
            if(Clint!=null )
            {
                //remove from list

                DatatClints.Remove(Clint);
                return true;
            }
            return false;
        }

        public bool Edit(CLSClint entity)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            var oldClint = GetById(entity.UserId);
            if (oldClint != null)
            {
                int index =DatatClints.IndexOf(oldClint);   

                DatatClints[index] = entity;
                return true;
            }
            return false;

        }

        public List<CLSClint> GetAll()
        {
            //throw new NotImplementedException();
            return DatatClints;
        }

        public CLSClint GetById(int id)
        {
            //throw new NotImplementedException();
           
            foreach(var clint in DatatClints)
            {
                if(clint.UserId == id)
                    return clint;
            }
            return null;

        }
    }
}
