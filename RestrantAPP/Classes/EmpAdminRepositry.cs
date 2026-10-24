using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;

namespace RestrantAPP.Classes
{
    public class EmpAdminRepositry : IRepositry<CLSAdmin>
    {
   private List<CLSAdmin> listempadmin=new List<CLSAdmin>();
        public bool Add(CLSAdmin entity)
        {
            //throw new NotImplementedException();
            listempadmin.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            //throw new NotImplementedException();
            var admin=GetById(id);
            if (admin != null)
            {
                listempadmin.Remove(admin);
            return true;
            }
            return false;
        }

        public bool Edit(CLSAdmin entity)
        {
            var oldAdmin = GetById(entity.UserId);
                if (oldAdmin != null)
                {
                int index=listempadmin.IndexOf(oldAdmin);   
                listempadmin[index] = entity;
                return true;
                }
                return false ;    
        }

        public List<CLSAdmin> GetAll()
        {
            //throw new NotImplementedException();
            return listempadmin;
        }

        public CLSAdmin GetById(int id)
        {
            //throw new NotImplementedException();
            foreach(var admin in listempadmin)
            {
                if(admin.UserId == id)
                {
                    return admin;
                }
            }
                return null;
        }
    }
}


