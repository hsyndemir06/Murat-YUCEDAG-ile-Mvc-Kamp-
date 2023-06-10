using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Absract
{
    public interface IAdminSevice
    {
        List<Admin> GetList();
        void AdminAdd(Admin admin);

        Admin GetByiD(int id);

        void AdminDelete(Admin admin);

        void AdminUpdate(Admin admin);
    }
}
