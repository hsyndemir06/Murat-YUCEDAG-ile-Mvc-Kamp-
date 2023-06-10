using BusinessLayerr.Absract;
using DataAccessLayerr.Abstract;
using DataAccessLayerr.EntityFramework;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Concrete
{
    public class AdminManager:IAdminSevice
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminAdd(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public Admin GetByiD(int id)
        {
            return _adminDal.Get(x => x.AdminiD == id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }
    }
}
