using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactServices
    {
        List<Contact2> GetList();
        void ContactAddBL(Contact2 contact);
        Contact2 GetByID(int id);
        void ContactDelete(Contact2 contact);
        void ContactUpdate(Contact2 contact);
    }
}
