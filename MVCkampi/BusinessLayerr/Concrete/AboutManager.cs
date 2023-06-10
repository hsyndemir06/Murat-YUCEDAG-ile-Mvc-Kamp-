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
    public class AboutManager:IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutDelete(About about)
        {
            _aboutDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutDal.Update(about);
        }

        public void AboutAdd(About about)
        {
           _aboutDal.Insert(about);
        }

        public About GetByiD(int id)
        {
            return _aboutDal.Get(x => x.AboutiD == id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }
    }
}
