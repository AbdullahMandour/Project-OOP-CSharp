using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public interface IRepositry<t> where t:class
    {
        public List<t> GetAll();
        public t GetById(int id);
        public bool Add(t entity);
        public bool Edit(t entity);
        public bool Delete(int id);

    }
}
