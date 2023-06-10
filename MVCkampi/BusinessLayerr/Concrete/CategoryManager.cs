using BusinessLayerr.Absract;
using DataAccessLayerr.Abstract;
using DataAccessLayerr.Concrete.Repositories;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

      

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
           _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByiD(int id)
        {
            return _categoryDal.Get(x => x.CategoryiD == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
