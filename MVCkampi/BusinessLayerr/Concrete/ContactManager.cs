using BusinessLayerr.Absract;
using DataAccessLayerr.Abstract;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayerr.Concrete
{
    public class ContactManager:IContactService
    {
        IContactDdal _contactDal;

        public ContactManager(IContactDdal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public Contact GetByiD(int id)
        {
            return _contactDal.Get(x => x.ContactiD == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }
    }
}
