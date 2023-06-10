using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Absract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);

        Category GetByiD(int id);

        void CategoryDelete(Category category);

        void CategoryUpdate(Category category);
    }
}
