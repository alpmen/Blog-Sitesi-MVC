using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ContactManager: IContactServices
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void ContactAddBL(Contact2 contact)
        {
            contactDal.Insert(contact);
        }

        public void ContactDelete(Contact2 contact)
        {
            contactDal.Delete(contact);
        }

        public void ContactUpdate(Contact2 contact)
        {
            contactDal.Update(contact);
        }

        public Contact2 GetByID(int id)
        {
            return contactDal.Get(x => x.ContactID == id);
        }

        public List<Contact2> GetList()
        {
            return contactDal.List();
        }
    }
}
